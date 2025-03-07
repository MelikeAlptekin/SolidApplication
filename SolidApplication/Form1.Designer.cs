namespace SolidApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nmrHour = new System.Windows.Forms.NumericUpDown();
            this.cmbAssign = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cmbFilterTaskState = new System.Windows.Forms.ComboBox();
            this.cmbFilterAssign = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.flwOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTeamMember = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.btnTaskStateChange = new System.Windows.Forms.Button();
            this.lstTaskList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmrHour)).BeginInit();
            this.flwOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(578, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "FİLTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Assign:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(578, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "TaskState";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(821, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Assign";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(33, 95);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(282, 32);
            this.txtTitle.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(30, 181);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(437, 66);
            this.txtDescription.TabIndex = 9;
            // 
            // nmrHour
            // 
            this.nmrHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrHour.Location = new System.Drawing.Point(30, 303);
            this.nmrHour.Name = "nmrHour";
            this.nmrHour.Size = new System.Drawing.Size(285, 32);
            this.nmrHour.TabIndex = 10;
            // 
            // cmbAssign
            // 
            this.cmbAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAssign.FormattingEnabled = true;
            this.cmbAssign.Location = new System.Drawing.Point(33, 378);
            this.cmbAssign.Name = "cmbAssign";
            this.cmbAssign.Size = new System.Drawing.Size(282, 34);
            this.cmbAssign.TabIndex = 11;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNew.Location = new System.Drawing.Point(341, 370);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(140, 48);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cmbFilterTaskState
            // 
            this.cmbFilterTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFilterTaskState.FormattingEnabled = true;
            this.cmbFilterTaskState.Location = new System.Drawing.Point(583, 141);
            this.cmbFilterTaskState.Name = "cmbFilterTaskState";
            this.cmbFilterTaskState.Size = new System.Drawing.Size(183, 34);
            this.cmbFilterTaskState.TabIndex = 13;
            // 
            // cmbFilterAssign
            // 
            this.cmbFilterAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFilterAssign.FormattingEnabled = true;
            this.cmbFilterAssign.Location = new System.Drawing.Point(811, 141);
            this.cmbFilterAssign.Name = "cmbFilterAssign";
            this.cmbFilterAssign.Size = new System.Drawing.Size(195, 34);
            this.cmbFilterAssign.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.Location = new System.Drawing.Point(1037, 132);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(146, 43);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // flwOperation
            // 
            this.flwOperation.Controls.Add(this.label9);
            this.flwOperation.Controls.Add(this.cmbTeamMember);
            this.flwOperation.Controls.Add(this.btnAssign);
            this.flwOperation.Controls.Add(this.label10);
            this.flwOperation.Controls.Add(this.cmbTaskState);
            this.flwOperation.Controls.Add(this.btnTaskStateChange);
            this.flwOperation.Location = new System.Drawing.Point(30, 713);
            this.flwOperation.Name = "flwOperation";
            this.flwOperation.Size = new System.Drawing.Size(1142, 117);
            this.flwOperation.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Team Member:";
            // 
            // cmbTeamMember
            // 
            this.cmbTeamMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTeamMember.FormattingEnabled = true;
            this.cmbTeamMember.Location = new System.Drawing.Point(155, 3);
            this.cmbTeamMember.Name = "cmbTeamMember";
            this.cmbTeamMember.Size = new System.Drawing.Size(165, 33);
            this.cmbTeamMember.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAssign.Location = new System.Drawing.Point(326, 3);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(147, 34);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(479, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "TaskState:";
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(593, 3);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(203, 33);
            this.cmbTaskState.TabIndex = 4;
            // 
            // btnTaskStateChange
            // 
            this.btnTaskStateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskStateChange.Location = new System.Drawing.Point(802, 3);
            this.btnTaskStateChange.Name = "btnTaskStateChange";
            this.btnTaskStateChange.Size = new System.Drawing.Size(201, 40);
            this.btnTaskStateChange.TabIndex = 18;
            this.btnTaskStateChange.Text = "TaskState Change";
            this.btnTaskStateChange.UseVisualStyleBackColor = true;
            this.btnTaskStateChange.Click += new System.EventHandler(this.btnTaskStateChange_Click);
            // 
            // lstTaskList
            // 
            this.lstTaskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstTaskList.HideSelection = false;
            this.lstTaskList.Location = new System.Drawing.Point(30, 454);
            this.lstTaskList.Name = "lstTaskList";
            this.lstTaskList.Size = new System.Drawing.Size(1142, 236);
            this.lstTaskList.TabIndex = 17;
            this.lstTaskList.UseCompatibleStateImageBehavior = false;
            this.lstTaskList.View = System.Windows.Forms.View.Details;
            this.lstTaskList.SelectedIndexChanged += new System.EventHandler(this.lstTaskList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "WorkHour";
            this.columnHeader2.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TaskState";
            this.columnHeader3.Width = 185;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Assigned";
            this.columnHeader4.Width = 204;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 856);
            this.Controls.Add(this.lstTaskList);
            this.Controls.Add(this.flwOperation);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbFilterAssign);
            this.Controls.Add(this.cmbFilterTaskState);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbAssign);
            this.Controls.Add(this.nmrHour);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrHour)).EndInit();
            this.flwOperation.ResumeLayout(false);
            this.flwOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nmrHour;
        private System.Windows.Forms.ComboBox cmbAssign;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cmbFilterTaskState;
        private System.Windows.Forms.ComboBox cmbFilterAssign;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.FlowLayoutPanel flwOperation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTeamMember;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.Button btnTaskStateChange;
        private System.Windows.Forms.ListView lstTaskList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

