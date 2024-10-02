namespace EMS_PL
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel2 = new Panel();
            employeeButton = new Button();
            salaryButton = new Button();
            departmentButton = new Button();
            dashboardButton = new Button();
            welcome = new Label();
            ems_icon = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ems_icon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(employeeButton);
            panel1.Controls.Add(salaryButton);
            panel1.Controls.Add(departmentButton);
            panel1.Controls.Add(dashboardButton);
            panel1.Controls.Add(welcome);
            panel1.Controls.Add(ems_icon);
            panel1.Location = new Point(2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 814);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(422, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 1;
            // 
            // employeeButton
            // 
            employeeButton.Cursor = Cursors.Hand;
            employeeButton.FlatAppearance.BorderSize = 2;
            employeeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 0, 118);
            employeeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 118);
            employeeButton.FlatStyle = FlatStyle.Flat;
            employeeButton.ForeColor = Color.White;
            employeeButton.Image = (Image)resources.GetObject("employeeButton.Image");
            employeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            employeeButton.Location = new Point(43, 419);
            employeeButton.Name = "employeeButton";
            employeeButton.Padding = new Padding(8);
            employeeButton.Size = new Size(336, 69);
            employeeButton.TabIndex = 7;
            employeeButton.Text = "Add Employee";
            employeeButton.UseVisualStyleBackColor = true;
            employeeButton.Click += employeeButton_Click;
            // 
            // salaryButton
            // 
            salaryButton.Cursor = Cursors.Hand;
            salaryButton.FlatAppearance.BorderSize = 2;
            salaryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 0, 118);
            salaryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 118);
            salaryButton.FlatStyle = FlatStyle.Flat;
            salaryButton.ForeColor = Color.White;
            salaryButton.Image = (Image)resources.GetObject("salaryButton.Image");
            salaryButton.ImageAlign = ContentAlignment.MiddleLeft;
            salaryButton.Location = new Point(43, 660);
            salaryButton.Name = "salaryButton";
            salaryButton.Padding = new Padding(8);
            salaryButton.Size = new Size(336, 68);
            salaryButton.TabIndex = 6;
            salaryButton.Text = "Search";
            salaryButton.UseVisualStyleBackColor = true;
            salaryButton.Click += salaryButton_Click;
            // 
            // departmentButton
            // 
            departmentButton.Cursor = Cursors.Hand;
            departmentButton.FlatAppearance.BorderSize = 2;
            departmentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 0, 118);
            departmentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 118);
            departmentButton.FlatStyle = FlatStyle.Flat;
            departmentButton.ForeColor = Color.White;
            departmentButton.Image = (Image)resources.GetObject("departmentButton.Image");
            departmentButton.ImageAlign = ContentAlignment.MiddleLeft;
            departmentButton.Location = new Point(43, 536);
            departmentButton.Name = "departmentButton";
            departmentButton.Padding = new Padding(4);
            departmentButton.Size = new Size(336, 70);
            departmentButton.TabIndex = 5;
            departmentButton.Text = "Add Department";
            departmentButton.UseVisualStyleBackColor = true;
            departmentButton.Click += departmentButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderSize = 2;
            dashboardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 0, 118);
            dashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 118);
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(43, 298);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(8);
            dashboardButton.Size = new Size(336, 69);
            dashboardButton.TabIndex = 4;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // welcome
            // 
            welcome.Anchor = AnchorStyles.None;
            welcome.AutoSize = true;
            welcome.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.White;
            welcome.Location = new Point(102, 210);
            welcome.Name = "welcome";
            welcome.Padding = new Padding(14);
            welcome.Size = new Size(217, 56);
            welcome.TabIndex = 2;
            welcome.Text = "Welcome, User";
            welcome.TextAlign = ContentAlignment.MiddleCenter;
            welcome.Click += welcome_Click;
            // 
            // ems_icon
            // 
            ems_icon.Anchor = AnchorStyles.None;
            ems_icon.BackgroundImageLayout = ImageLayout.Zoom;
            ems_icon.Image = (Image)resources.GetObject("ems_icon.Image");
            ems_icon.Location = new Point(125, 22);
            ems_icon.Name = "ems_icon";
            ems_icon.Size = new Size(164, 157);
            ems_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            ems_icon.TabIndex = 1;
            ems_icon.TabStop = false;
            ems_icon.Click += ems_icon_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(434, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(664, 338);
            panel3.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1216, 801);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(800, 800);
            Name = "Dashboard";
            Text = "Employee Management System";
            WindowState = FormWindowState.Minimized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ems_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox ems_icon;
        private Label welcome;
        private Button dashboardButton;
        private Button departmentButton;
        private Button employeeButton;
        private Button salaryButton;
        private Panel panel2;
        private Panel panel3;
    }
}