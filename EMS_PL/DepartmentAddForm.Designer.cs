namespace EMS_PL
{
    partial class DepartmentAddForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            employeesTable = new DataGridView();
            employeeHeadingLabel = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            departNameInput = new ComboBox();
            budgetInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            positionInput = new ComboBox();
            deleteButton = new Button();
            clearButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            salaryInput = new TextBox();
            departmentIdInput = new TextBox();
            departmentNameLabel = new Label();
            salaryLabel = new Label();
            positionLabel = new Label();
            departNameLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(employeesTable);
            panel1.Location = new Point(22, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 246);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // employeesTable
            // 
            employeesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeesTable.BackgroundColor = Color.Gainsboro;
            employeesTable.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            employeesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            employeesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesTable.Location = new Point(19, -6);
            employeesTable.Name = "employeesTable";
            employeesTable.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(2);
            employeesTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            employeesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeesTable.Size = new Size(976, 258);
            employeesTable.TabIndex = 6;
            // 
            // employeeHeadingLabel
            // 
            employeeHeadingLabel.Anchor = AnchorStyles.Top;
            employeeHeadingLabel.AutoSize = true;
            employeeHeadingLabel.FlatStyle = FlatStyle.Popup;
            employeeHeadingLabel.Font = new Font("Algerian", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeHeadingLabel.Location = new Point(344, 18);
            employeeHeadingLabel.Name = "employeeHeadingLabel";
            employeeHeadingLabel.Padding = new Padding(10);
            employeeHeadingLabel.Size = new Size(387, 55);
            employeeHeadingLabel.TabIndex = 3;
            employeeHeadingLabel.Text = "Department's Record";
            employeeHeadingLabel.TextAlign = ContentAlignment.TopCenter;
            employeeHeadingLabel.Click += employeeHeadingLabel_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(departNameInput);
            panel2.Controls.Add(budgetInput);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(positionInput);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(updateButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(salaryInput);
            panel2.Controls.Add(departmentIdInput);
            panel2.Controls.Add(departmentNameLabel);
            panel2.Controls.Add(salaryLabel);
            panel2.Controls.Add(positionLabel);
            panel2.Controls.Add(departNameLabel);
            panel2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(22, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(1015, 550);
            panel2.TabIndex = 4;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom;
            button5.BackColor = Color.FromArgb(75, 0, 118);
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(518, 409);
            button5.Name = "button5";
            button5.Padding = new Padding(10);
            button5.Size = new Size(132, 86);
            button5.TabIndex = 41;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom;
            button6.BackColor = Color.FromArgb(75, 0, 118);
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(692, 409);
            button6.Name = "button6";
            button6.Padding = new Padding(10);
            button6.Size = new Size(116, 86);
            button6.TabIndex = 40;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom;
            button7.BackColor = Color.FromArgb(75, 0, 118);
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(327, 409);
            button7.Name = "button7";
            button7.Padding = new Padding(10);
            button7.Size = new Size(141, 86);
            button7.TabIndex = 39;
            button7.Text = "Update";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom;
            button8.BackColor = Color.FromArgb(75, 0, 118);
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(166, 409);
            button8.Name = "button8";
            button8.Padding = new Padding(10);
            button8.Size = new Size(101, 86);
            button8.TabIndex = 38;
            button8.Text = "Add";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(75, 0, 118);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(970, 879);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(134, 67);
            button1.TabIndex = 28;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(75, 0, 118);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1144, 879);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(125, 67);
            button2.TabIndex = 27;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = Color.FromArgb(75, 0, 118);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(779, 879);
            button3.Name = "button3";
            button3.Padding = new Padding(10);
            button3.Size = new Size(148, 67);
            button3.TabIndex = 26;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.BackColor = Color.FromArgb(75, 0, 118);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(618, 879);
            button4.Name = "button4";
            button4.Padding = new Padding(10);
            button4.Size = new Size(110, 67);
            button4.TabIndex = 25;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            // 
            // departNameInput
            // 
            departNameInput.Anchor = AnchorStyles.None;
            departNameInput.Font = new Font("Segoe UI Light", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departNameInput.FormattingEnabled = true;
            departNameInput.Items.AddRange(new object[] { "Information Technology (IT)", "Computer Science (CS)", "Software Enineering (SE)", "Data Science (DS)", "Computer Engineering (CE)", "Other" });
            departNameInput.Location = new Point(472, 154);
            departNameInput.Name = "departNameInput";
            departNameInput.Size = new Size(327, 46);
            departNameInput.TabIndex = 22;
            // 
            // budgetInput
            // 
            budgetInput.Anchor = AnchorStyles.None;
            budgetInput.Cursor = Cursors.IBeam;
            budgetInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            budgetInput.Location = new Point(472, 282);
            budgetInput.Name = "budgetInput";
            budgetInput.Size = new Size(327, 45);
            budgetInput.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(166, 277);
            label2.Name = "label2";
            label2.Padding = new Padding(6);
            label2.Size = new Size(124, 50);
            label2.TabIndex = 20;
            label2.Text = "Budget";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(38, 41);
            label1.Name = "label1";
            label1.Padding = new Padding(6);
            label1.Size = new Size(294, 50);
            label1.TabIndex = 18;
            label1.Text = "Fill the Information:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // positionInput
            // 
            positionInput.Anchor = AnchorStyles.Right;
            positionInput.FormattingEnabled = true;
            positionInput.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract/Temporary", "Intern", "Sessional", "Freelancer", "Managerial ", "Executive ", "Exempt ", "Non-Exempt", "Apprentice", "Commission-Based" });
            positionInput.Location = new Point(2354, 589);
            positionInput.Name = "positionInput";
            positionInput.Size = new Size(240, 36);
            positionInput.TabIndex = 14;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom;
            deleteButton.BackColor = Color.FromArgb(75, 0, 118);
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(1348, 1326);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10);
            deleteButton.Size = new Size(119, 67);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom;
            clearButton.BackColor = Color.FromArgb(75, 0, 118);
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(1542, 1326);
            clearButton.Name = "clearButton";
            clearButton.Padding = new Padding(10);
            clearButton.Size = new Size(110, 67);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom;
            updateButton.BackColor = Color.FromArgb(75, 0, 118);
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(1158, 1326);
            updateButton.Name = "updateButton";
            updateButton.Padding = new Padding(10);
            updateButton.Size = new Size(139, 67);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom;
            addButton.BackColor = Color.FromArgb(75, 0, 118);
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(987, 1326);
            addButton.Name = "addButton";
            addButton.Padding = new Padding(10);
            addButton.Size = new Size(110, 67);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // salaryInput
            // 
            salaryInput.Anchor = AnchorStyles.Right;
            salaryInput.Cursor = Cursors.IBeam;
            salaryInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryInput.Location = new Point(2354, 692);
            salaryInput.Name = "salaryInput";
            salaryInput.Size = new Size(240, 35);
            salaryInput.TabIndex = 9;
            // 
            // departmentIdInput
            // 
            departmentIdInput.Anchor = AnchorStyles.None;
            departmentIdInput.Cursor = Cursors.IBeam;
            departmentIdInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentIdInput.Location = new Point(1348, 777);
            departmentIdInput.Name = "departmentIdInput";
            departmentIdInput.Size = new Size(300, 35);
            departmentIdInput.TabIndex = 7;
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.Anchor = AnchorStyles.None;
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentNameLabel.Location = new Point(1057, 777);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Padding = new Padding(6);
            departmentNameLabel.Size = new Size(190, 40);
            departmentNameLabel.TabIndex = 5;
            departmentNameLabel.Text = "Department Id";
            // 
            // salaryLabel
            // 
            salaryLabel.Anchor = AnchorStyles.Right;
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryLabel.Location = new Point(2188, 697);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Padding = new Padding(6);
            salaryLabel.Size = new Size(99, 40);
            salaryLabel.TabIndex = 4;
            salaryLabel.Text = "Salary";
            // 
            // positionLabel
            // 
            positionLabel.Anchor = AnchorStyles.Right;
            positionLabel.AutoSize = true;
            positionLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionLabel.Location = new Point(2198, 585);
            positionLabel.Name = "positionLabel";
            positionLabel.Padding = new Padding(6);
            positionLabel.Size = new Size(117, 40);
            positionLabel.TabIndex = 3;
            positionLabel.Text = "Position";
            // 
            // departNameLabel
            // 
            departNameLabel.Anchor = AnchorStyles.None;
            departNameLabel.AutoSize = true;
            departNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            departNameLabel.Location = new Point(166, 150);
            departNameLabel.Name = "departNameLabel";
            departNameLabel.Padding = new Padding(6);
            departNameLabel.Size = new Size(275, 50);
            departNameLabel.TabIndex = 0;
            departNameLabel.Text = "Department Name";
            // 
            // DepartmentAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 13, 173);
            ClientSize = new Size(1049, 931);
            Controls.Add(panel2);
            Controls.Add(employeeHeadingLabel);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "DepartmentAddForm";
            Text = "DepartmentAddForm";
            WindowState = FormWindowState.Maximized;
            Load += DepartmentAddForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeesTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label employeeHeadingLabel;
        private Panel panel2;
        private Label label1;
        private ComboBox positionInput;
        private Button deleteButton;
        private Button clearButton;
        private Button updateButton;
        private Button addButton;
        private TextBox salaryInput;
        private TextBox departmentIdInput;
        private TextBox lastNameInput;
        private Label departmentNameLabel;
        private Label salaryLabel;
        private Label positionLabel;
        private Label lastNameLebel;
        private TextBox firstNameInput;
        private Label departNameLabel;
        private ComboBox departNameInput;
        private TextBox budgetInput;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Label label4;
        private DataGridView employeesTable;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}