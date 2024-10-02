namespace EMS_PL
{
    partial class DepartmentUpdateForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            departNameInput = new ComboBox();
            budgetInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            departNameLabel = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            employeeHeadingLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(706, 603);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(132, 76);
            button1.TabIndex = 37;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(885, 603);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(116, 76);
            button2.TabIndex = 36;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = Color.Orange;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(508, 603);
            button3.Name = "button3";
            button3.Padding = new Padding(10);
            button3.Size = new Size(141, 76);
            button3.TabIndex = 35;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.BackColor = Color.Green;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(341, 603);
            button4.Name = "button4";
            button4.Padding = new Padding(10);
            button4.Size = new Size(101, 76);
            button4.TabIndex = 34;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // departNameInput
            // 
            departNameInput.Anchor = AnchorStyles.None;
            departNameInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departNameInput.ForeColor = Color.Black;
            departNameInput.FormattingEnabled = true;
            departNameInput.Items.AddRange(new object[] { "Information Technology (IT)", "Computer Science (CS)", "Software Enineering (SE)", "Data Science (DS)", "Computer Engineering (CE)", "Other" });
            departNameInput.Location = new Point(647, 361);
            departNameInput.Name = "departNameInput";
            departNameInput.Size = new Size(354, 46);
            departNameInput.TabIndex = 33;
            departNameInput.SelectedIndexChanged += departNameInput_SelectedIndexChanged;
            // 
            // budgetInput
            // 
            budgetInput.Anchor = AnchorStyles.None;
            budgetInput.Cursor = Cursors.IBeam;
            budgetInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            budgetInput.ForeColor = Color.Black;
            budgetInput.Location = new Point(647, 465);
            budgetInput.Name = "budgetInput";
            budgetInput.Size = new Size(354, 45);
            budgetInput.TabIndex = 32;
            budgetInput.TextChanged += budgetInput_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(348, 460);
            label2.Name = "label2";
            label2.Padding = new Padding(6);
            label2.Size = new Size(124, 50);
            label2.TabIndex = 31;
            label2.Text = "Budget";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 263);
            label1.Name = "label1";
            label1.Padding = new Padding(6);
            label1.Size = new Size(411, 50);
            label1.TabIndex = 30;
            label1.Text = "Fill the updated Information:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // departNameLabel
            // 
            departNameLabel.Anchor = AnchorStyles.None;
            departNameLabel.AutoSize = true;
            departNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            departNameLabel.ForeColor = Color.White;
            departNameLabel.Location = new Point(328, 361);
            departNameLabel.Name = "departNameLabel";
            departNameLabel.Padding = new Padding(6);
            departNameLabel.Size = new Size(275, 50);
            departNameLabel.TabIndex = 29;
            departNameLabel.Text = "Department Name";
            departNameLabel.Click += departNameLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(489, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 45);
            textBox1.TabIndex = 39;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(76, 160);
            label3.Name = "label3";
            label3.Padding = new Padding(6);
            label3.Size = new Size(366, 50);
            label3.TabIndex = 38;
            label3.Text = "Department id to update:";
            // 
            // employeeHeadingLabel
            // 
            employeeHeadingLabel.Anchor = AnchorStyles.Top;
            employeeHeadingLabel.AutoSize = true;
            employeeHeadingLabel.FlatStyle = FlatStyle.Popup;
            employeeHeadingLabel.Font = new Font("Algerian", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeHeadingLabel.ForeColor = Color.White;
            employeeHeadingLabel.Location = new Point(404, 45);
            employeeHeadingLabel.Name = "employeeHeadingLabel";
            employeeHeadingLabel.Padding = new Padding(10);
            employeeHeadingLabel.Size = new Size(387, 55);
            employeeHeadingLabel.TabIndex = 41;
            employeeHeadingLabel.Text = "Department's Record";
            employeeHeadingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DepartmentUpdateForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1225, 729);
            Controls.Add(employeeHeadingLabel);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(departNameInput);
            Controls.Add(budgetInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(departNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DepartmentUpdateForm";
            Text = "DepartmentUpdateForm";
            WindowState = FormWindowState.Minimized;
            Load += DepartmentUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox departNameInput;
        private TextBox budgetInput;
        private Label label2;
        private Label label1;
        private Label departNameLabel;
        private TextBox textBox1;
        private Label label3;
        private Label employeeHeadingLabel;
    }
}