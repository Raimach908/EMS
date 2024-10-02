namespace EMS_PL
{
    partial class EmployeeAddForm
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
            employeeHeadingLabel = new Label();
            panel2 = new Panel();
            label1 = new Label();
            positionInput = new ComboBox();
            deleteButton = new Button();
            clearButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            salaryInput = new TextBox();
            departmentIdInput = new TextBox();
            lastNameInput = new TextBox();
            departmentNameLabel = new Label();
            salaryLabel = new Label();
            positionLabel = new Label();
            lastNameLebel = new Label();
            firstNameInput = new TextBox();
            firstNameLabel = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // employeeHeadingLabel
            // 
            employeeHeadingLabel.Anchor = AnchorStyles.Top;
            employeeHeadingLabel.AutoSize = true;
            employeeHeadingLabel.FlatStyle = FlatStyle.Popup;
            employeeHeadingLabel.Font = new Font("Algerian", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeHeadingLabel.ForeColor = Color.White;
            employeeHeadingLabel.Location = new Point(332, 23);
            employeeHeadingLabel.Name = "employeeHeadingLabel";
            employeeHeadingLabel.Padding = new Padding(10);
            employeeHeadingLabel.Size = new Size(430, 55);
            employeeHeadingLabel.TabIndex = 3;
            employeeHeadingLabel.Text = "Employee's Information";
            employeeHeadingLabel.TextAlign = ContentAlignment.TopCenter;
            employeeHeadingLabel.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(positionInput);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(updateButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(salaryInput);
            panel2.Controls.Add(departmentIdInput);
            panel2.Controls.Add(lastNameInput);
            panel2.Controls.Add(departmentNameLabel);
            panel2.Controls.Add(salaryLabel);
            panel2.Controls.Add(positionLabel);
            panel2.Controls.Add(lastNameLebel);
            panel2.Controls.Add(firstNameInput);
            panel2.Controls.Add(firstNameLabel);
            panel2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(30, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 635);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 98);
            label1.Name = "label1";
            label1.Padding = new Padding(6);
            label1.Size = new Size(12, 49);
            label1.TabIndex = 18;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // positionInput
            // 
            positionInput.Anchor = AnchorStyles.Right;
            positionInput.ForeColor = Color.Black;
            positionInput.FormattingEnabled = true;
            positionInput.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract/Temporary", "Intern", "Sessional", "Freelancer", "Managerial ", "Executive ", "Exempt ", "Non-Exempt", "Apprentice", "Commission-Based" });
            positionInput.Location = new Point(753, 92);
            positionInput.Name = "positionInput";
            positionInput.Size = new Size(240, 36);
            positionInput.TabIndex = 14;
            positionInput.SelectedIndexChanged += positionInput_SelectedIndexChanged;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom;
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(552, 442);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10);
            deleteButton.Size = new Size(119, 67);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom;
            clearButton.BackColor = Color.FromArgb(128, 64, 64);
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(746, 442);
            clearButton.Name = "clearButton";
            clearButton.Padding = new Padding(10);
            clearButton.Size = new Size(110, 67);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom;
            updateButton.BackColor = Color.Orange;
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(362, 442);
            updateButton.Name = "updateButton";
            updateButton.Padding = new Padding(10);
            updateButton.Size = new Size(139, 67);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom;
            addButton.BackColor = Color.Green;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(191, 442);
            addButton.Name = "addButton";
            addButton.Padding = new Padding(10);
            addButton.Size = new Size(110, 67);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // salaryInput
            // 
            salaryInput.Anchor = AnchorStyles.Right;
            salaryInput.Cursor = Cursors.IBeam;
            salaryInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryInput.ForeColor = Color.Black;
            salaryInput.Location = new Point(753, 195);
            salaryInput.Name = "salaryInput";
            salaryInput.Size = new Size(240, 35);
            salaryInput.TabIndex = 9;
            salaryInput.TextChanged += salaryInput_TextChanged;
            // 
            // departmentIdInput
            // 
            departmentIdInput.Anchor = AnchorStyles.None;
            departmentIdInput.Cursor = Cursors.IBeam;
            departmentIdInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentIdInput.ForeColor = Color.Black;
            departmentIdInput.Location = new Point(523, 311);
            departmentIdInput.Name = "departmentIdInput";
            departmentIdInput.Size = new Size(300, 35);
            departmentIdInput.TabIndex = 7;
            departmentIdInput.TextChanged += departmentNameInput_TextChanged;
            // 
            // lastNameInput
            // 
            lastNameInput.Anchor = AnchorStyles.Left;
            lastNameInput.Cursor = Cursors.IBeam;
            lastNameInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameInput.ForeColor = Color.Black;
            lastNameInput.Location = new Point(237, 200);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(240, 35);
            lastNameInput.TabIndex = 6;
            lastNameInput.TextChanged += lastNameInput_TextChanged;
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.Anchor = AnchorStyles.None;
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentNameLabel.ForeColor = Color.White;
            departmentNameLabel.Location = new Point(254, 306);
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
            salaryLabel.ForeColor = Color.White;
            salaryLabel.Location = new Point(587, 200);
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
            positionLabel.ForeColor = Color.White;
            positionLabel.Location = new Point(597, 88);
            positionLabel.Name = "positionLabel";
            positionLabel.Padding = new Padding(6);
            positionLabel.Size = new Size(117, 40);
            positionLabel.TabIndex = 3;
            positionLabel.Text = "Position";
            positionLabel.Click += label2_Click;
            // 
            // lastNameLebel
            // 
            lastNameLebel.Anchor = AnchorStyles.Left;
            lastNameLebel.AutoSize = true;
            lastNameLebel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLebel.ForeColor = Color.White;
            lastNameLebel.Location = new Point(64, 195);
            lastNameLebel.Name = "lastNameLebel";
            lastNameLebel.Padding = new Padding(6);
            lastNameLebel.Size = new Size(146, 40);
            lastNameLebel.TabIndex = 2;
            lastNameLebel.Text = "Last Name";
            // 
            // firstNameInput
            // 
            firstNameInput.Anchor = AnchorStyles.Left;
            firstNameInput.Cursor = Cursors.IBeam;
            firstNameInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameInput.ForeColor = Color.Black;
            firstNameInput.Location = new Point(237, 88);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(240, 35);
            firstNameInput.TabIndex = 1;
            firstNameInput.TextChanged += firstNameInput_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.Left;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.White;
            firstNameLabel.Location = new Point(64, 85);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Padding = new Padding(6);
            firstNameLabel.Size = new Size(150, 40);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // EmployeeAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1098, 741);
            Controls.Add(employeeHeadingLabel);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            Name = "EmployeeAddForm";
            Text = "Employee Management System";
            WindowState = FormWindowState.Minimized;
            Load += EmployeeAddForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private TextBox firstNameInput;
        private Label firstNameLabel;
        private Label lastNameLebel;
        private Label positionLabel;
        private Label salaryLabel;
        private Label departmentNameLabel;
        private Button addButton;
        private TextBox salaryInput;
        private TextBox departmentIdInput;
        private TextBox lastNameInput;
        private Button deleteButton;
        private Button clearButton;
        private Button updateButton;
        private Label employeeHeadingLabel;
        private ComboBox positionInput;
        private Label label1;
    }
}