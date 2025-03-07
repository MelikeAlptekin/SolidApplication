using SolidApplication.Commands;
using SolidApplication.Enums;
using SolidApplication.Factories;
using SolidApplication.Models;
using SolidApplication.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void FillCombobox()
        {
            cmbAssign.Items.Clear();
            cmbTeamMember.Items.Clear();
            cmbFilterTaskState.Items.Clear();
            cmbFilterAssign.Items.Clear();
            cmbTaskState.Items.Clear();

            foreach (var item in Enum.GetValues(typeof(TaskState)))
            {
                cmbTaskState.Items.Add(item);
                cmbFilterTaskState.Items.Add(item);
            }
           


            var db = DbContextFactory.GetIntance();
            var userRepo = UserRepositoryFactory.GetInstance(db);
            var userList = userRepo.GetAll().ToArray();

            cmbAssign.Items.AddRange(userList);
            cmbTeamMember.Items.AddRange(userList);
            cmbFilterAssign.Items.AddRange(userList);

            flwOperation.Visible = false;
        }

        void FillTable()
        {
            this.lstTaskList.Items.Clear();

            var db = DbContextFactory.GetIntance();
            var taskRepo = TaskRepositoryFactory.GetInstance(db);
            var tasks = taskRepo.GetAll();

            foreach (var item in tasks)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Title;
                li.SubItems.Add(item.Hour.ToString());
                li.SubItems.Add((Enum.Parse(typeof(TaskState), item.State.ToString()).ToString()));
                li.SubItems.Add(item.User?.Name + " " +item.User?.SurName);
                li.Tag = item;

                lstTaskList.Items.Add(li);
            }

        }

        void FillFilteredTable(List<Models.Task> filteredTaskList)
        {
            lstTaskList.Items.Clear();

            foreach (var item in filteredTaskList)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Title;
                li.SubItems.Add(item.Hour.ToString());
                li.SubItems.Add((Enum.Parse(typeof(TaskState), item.State.ToString()).ToString()));
                li.SubItems.Add(item.User?.Name + " " + item.User?.SurName);
                li.Tag = item;

                lstTaskList.Items.Add(li);
            }
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var assigned_user = (Models.User)cmbAssign.SelectedItem;

            int? assigned_user_id = null;

            if (assigned_user != null)
            {
                assigned_user_id = assigned_user.Id;
            }

            var command = new TaskCreateCommand(
                txtTitle.Text,
                txtDescription.Text,
                assigned_user_id,
                (int)nmrHour.Value
                );

            var taskCreateHandler = TaskCreateHandlerFactory.GetInstance();
            var result = taskCreateHandler.Execute(command);


            MessageBox.Show(result.Message);

            FillTable();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCombobox();
            FillTable();
        }
        //Bir kişiye Görev atama
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbTeamMember.SelectedItem != null && lstTaskList.FocusedItem != null)
            {
                var selected_team_member = (Models.User)cmbTeamMember.SelectedItem;
                var selected_task = (Models.Task)lstTaskList.FocusedItem.Tag;

                if (selected_team_member !=null && selected_task != null)
                {
                    var command = new TaskAssignCommand(selected_task.Id, selected_team_member.Id);
                    var taskAssignHandler = TaskAssignHandlerFactory.GetInstance();
                    var result = taskAssignHandler.Execute(command);

                    MessageBox.Show(result.Message);

                    FillTable();
                }

            }

        }

        private void lstTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Models.Task)lstTaskList.FocusedItem.Tag;

            if (selected != null)
            {
                flwOperation.Visible = true;
            }
        }

        //Görevlerin durumlarıyla ilgili değişikliklerden sorumlu event.
        private void btnTaskStateChange_Click(object sender, EventArgs e)
        {
            if (lstTaskList.FocusedItem != null && cmbTaskState.SelectedItem != null)
            {
                var selected_task = (Models.Task)lstTaskList.FocusedItem.Tag;
                var selected_task_state = (TaskState)cmbTaskState.SelectedItem;

                if (selected_task_state == TaskState.Done)
                {
                    var command = new TaskDoneCommand(selected_task.Id);
                    var handler = TaskDoneHandlerFactory.GetIntance();
                    var result = handler.Execute(command);

                    MessageBox.Show(result.Message);
                }
                else if (selected_task_state == TaskState.InProgress)
                {
                    var command = new TaskInProgressCommand(selected_task.Id);
                    var handler = TaskInProgressHandlerFactory.GetInstance();
                    var result = handler.Execute(command);

                    MessageBox.Show(result.Message);
                }
                else if (selected_task_state == TaskState.Test)
                {
                    var command = new TaskTestCommand(selected_task.Id);
                    var handler = TaskTestHandlerFactory.GetInstance();
                    var result = handler.Execute(command);

                    MessageBox.Show(result.Message);
                }
                else if (selected_task_state == TaskState.Todo)
                {
                    var command = new TaskTodoCommand(selected_task.Id);
                    var handler = TaskTodoHandlerFactory.GetInstance();
                    var result = handler.Execute(command);

                    MessageBox.Show(result.Message);
                }

                FillTable();

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbFilterTaskState.SelectedItem != null && cmbFilterAssign.SelectedItem != null)
            {
                var selected_task_state = (TaskState)cmbFilterTaskState.SelectedItem;
                var selected_user = (User)cmbFilterAssign.SelectedItem;

                var query = new GetTaskAssignedToUserWithSpesificTaskStateQuery(selected_user.Id, selected_task_state);

                var handler = GetTaskAssignedToUserWithSpesificTaskStateQueryHandlerFactory.GetInstance();

                var filtered_task_list = handler.Execute(query);

                this.FillFilteredTable(filtered_task_list);
            }
            else if (cmbFilterTaskState.SelectedItem != null && cmbFilterAssign.SelectedItem == null)
            {
                var selected_task_state = (TaskState)cmbFilterTaskState.SelectedItem;

                var query = new GetTaskWithSpesificTaskStateQuery(selected_task_state);

                var handler = GetTaskWithSpesificTaskStateQueryHandlerFactory.GetInstance();

                var filtered_task_list = handler.Execute(query);

                this.FillFilteredTable(filtered_task_list);
            }
            else if (cmbFilterTaskState.SelectedItem == null && cmbFilterAssign.SelectedItem != null)
            {
                var selected_user = (User)cmbFilterAssign.SelectedItem;

                var query = new GetAssignedTaskToUserQuery(selected_user.Id);

                var handler = GetAssignedTaskToUserHandlerFactory.GetInstance();

                var filtered_task_list = handler.Execute(query);

                this.FillFilteredTable(filtered_task_list);

            }
            else
            {
                FillTable();
            }
        }
    }
}
