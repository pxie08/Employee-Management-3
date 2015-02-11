namespace q428
{
    partial class q428
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
            this.listBoxOne = new System.Windows.Forms.ListBox();
            this.manageMenu = new System.Windows.Forms.MenuStrip();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmHireButton = new System.Windows.Forms.Button();
            this.classDropDown = new System.Windows.Forms.ComboBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.extraInfoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.manageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOne
            // 
            this.listBoxOne.FormattingEnabled = true;
            this.listBoxOne.Location = new System.Drawing.Point(9, 32);
            this.listBoxOne.Name = "listBoxOne";
            this.listBoxOne.Size = new System.Drawing.Size(234, 199);
            this.listBoxOne.TabIndex = 0;
            this.listBoxOne.Click += new System.EventHandler(this.listBoxOne_Click);
            // 
            // manageMenu
            // 
            this.manageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeesToolStripMenuItem});
            this.manageMenu.Location = new System.Drawing.Point(0, 0);
            this.manageMenu.Name = "manageMenu";
            this.manageMenu.Size = new System.Drawing.Size(529, 24);
            this.manageMenu.TabIndex = 1;
            this.manageMenu.Text = "menuStrip1";
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hireEmployeeToolStripMenuItem,
            this.fireEmployeeToolStripMenuItem});
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employees";
            // 
            // hireEmployeeToolStripMenuItem
            // 
            this.hireEmployeeToolStripMenuItem.Name = "hireEmployeeToolStripMenuItem";
            this.hireEmployeeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.hireEmployeeToolStripMenuItem.Text = "Hire New Employee";
            this.hireEmployeeToolStripMenuItem.Click += new System.EventHandler(this.hireEmployeeToolStripMenuItem_Click);
            // 
            // fireEmployeeToolStripMenuItem
            // 
            this.fireEmployeeToolStripMenuItem.Name = "fireEmployeeToolStripMenuItem";
            this.fireEmployeeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.fireEmployeeToolStripMenuItem.Text = "Fire Employee";
            this.fireEmployeeToolStripMenuItem.Click += new System.EventHandler(this.fireEmployeeToolStripMenuItem_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(370, 93);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(370, 119);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // confirmHireButton
            // 
            this.confirmHireButton.Location = new System.Drawing.Point(444, 208);
            this.confirmHireButton.Name = "confirmHireButton";
            this.confirmHireButton.Size = new System.Drawing.Size(75, 23);
            this.confirmHireButton.TabIndex = 6;
            this.confirmHireButton.Text = "Confirm";
            this.confirmHireButton.UseVisualStyleBackColor = true;
            this.confirmHireButton.Click += new System.EventHandler(this.confirmHireButton_Click);
            // 
            // classDropDown
            // 
            this.classDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classDropDown.FormattingEnabled = true;
            this.classDropDown.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Peon",
            "Trainer"});
            this.classDropDown.Location = new System.Drawing.Point(370, 66);
            this.classDropDown.Name = "classDropDown";
            this.classDropDown.Size = new System.Drawing.Size(149, 21);
            this.classDropDown.TabIndex = 7;
            this.classDropDown.TextChanged += new System.EventHandler(this.classDropDown_TextChanged);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(370, 145);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(149, 20);
            this.salaryTextBox.TabIndex = 4;
            // 
            // extraInfoTextBox
            // 
            this.extraInfoTextBox.Location = new System.Drawing.Point(370, 171);
            this.extraInfoTextBox.Name = "extraInfoTextBox";
            this.extraInfoTextBox.Size = new System.Drawing.Size(149, 20);
            this.extraInfoTextBox.TabIndex = 5;
            this.extraInfoTextBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter new employee information.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Employee Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Store:";
            this.label6.Visible = false;
            // 
            // q428
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(529, 237);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extraInfoTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.classDropDown);
            this.Controls.Add(this.confirmHireButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.listBoxOne);
            this.Controls.Add(this.manageMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.manageMenu;
            this.MaximizeBox = false;
            this.Name = "q428";
            this.Text = "Quest 428 -- Patrick Xie";
            this.manageMenu.ResumeLayout(false);
            this.manageMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOne;
        private System.Windows.Forms.MenuStrip manageMenu;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireEmployeeToolStripMenuItem;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button confirmHireButton;
        private System.Windows.Forms.ComboBox classDropDown;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox extraInfoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

