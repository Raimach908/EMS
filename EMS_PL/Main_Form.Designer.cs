namespace EMS_PL
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            welcome = new Label();
            nameInput = new TextBox();
            nameLabel = new Label();
            startButton = new Button();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            welcome.AutoSize = true;
            welcome.BackColor = Color.WhiteSmoke;
            welcome.Font = new Font("Algerian", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.MidnightBlue;
            welcome.Location = new Point(95, 37);
            welcome.Name = "welcome";
            welcome.Padding = new Padding(17);
            welcome.Size = new Size(1056, 83);
            welcome.TabIndex = 2;
            welcome.Text = "Welcome to Employee Management System";
            welcome.TextAlign = ContentAlignment.MiddleCenter;
            welcome.Click += welcome_Click;
            // 
            // nameInput
            // 
            nameInput.Anchor = AnchorStyles.None;
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Cursor = Cursors.IBeam;
            nameInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameInput.ForeColor = Color.MidnightBlue;
            nameInput.Location = new Point(679, 541);
            nameInput.Multiline = true;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(319, 81);
            nameInput.TabIndex = 4;
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.MidnightBlue;
            nameLabel.Location = new Point(238, 541);
            nameLabel.Name = "nameLabel";
            nameLabel.Padding = new Padding(17);
            nameLabel.Size = new Size(333, 81);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Enter your name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Click += nameLabel_Click;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom;
            startButton.BackColor = Color.MidnightBlue;
            startButton.Cursor = Cursors.Hand;
            startButton.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
            startButton.FlatStyle = FlatStyle.Popup;
            startButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(553, 695);
            startButton.Margin = new Padding(0);
            startButton.Name = "startButton";
            startButton.Padding = new Padding(3);
            startButton.Size = new Size(140, 70);
            startButton.TabIndex = 5;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1225, 820);
            Controls.Add(startButton);
            Controls.Add(nameInput);
            Controls.Add(nameLabel);
            Controls.Add(welcome);
            Name = "Main_Form";
            Padding = new Padding(2);
            Text = "Main_Form";
            WindowState = FormWindowState.Minimized;
            Load += Main_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private TextBox nameInput;
        private Label nameLabel;
        private Button startButton;
    }
}