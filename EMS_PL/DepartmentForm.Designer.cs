namespace EMS_PL
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            button2 = new Button();
            button1 = new Button();
            deleteButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.MidnightBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(942, 202);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(271, 67);
            button2.TabIndex = 27;
            button2.Text = "View Department";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.MidnightBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(630, 202);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(290, 67);
            button1.TabIndex = 26;
            button1.Text = "Update Department";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom;
            deleteButton.BackColor = Color.MidnightBlue;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(942, 87);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10);
            deleteButton.Size = new Size(271, 67);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "Delete Department";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom;
            addButton.BackColor = Color.MidnightBlue;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(630, 87);
            addButton.Name = "addButton";
            addButton.Padding = new Padding(10);
            addButton.Size = new Size(290, 67);
            addButton.TabIndex = 24;
            addButton.Text = "Add Department";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1225, 820);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button deleteButton;
        private Button addButton;
    }
}