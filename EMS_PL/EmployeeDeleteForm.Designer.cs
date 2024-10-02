namespace EMS_PL
{
    partial class EmployeeDeleteForm
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
            empDeleteIdInput = new TextBox();
            updateIdlabel = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // empDeleteIdInput
            // 
            empDeleteIdInput.Anchor = AnchorStyles.Top;
            empDeleteIdInput.Cursor = Cursors.IBeam;
            empDeleteIdInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empDeleteIdInput.Location = new Point(344, 78);
            empDeleteIdInput.Name = "empDeleteIdInput";
            empDeleteIdInput.Size = new Size(121, 45);
            empDeleteIdInput.TabIndex = 18;
            empDeleteIdInput.TextChanged += empDeleteIdInput_TextChanged;
            // 
            // updateIdlabel
            // 
            updateIdlabel.Anchor = AnchorStyles.Top;
            updateIdlabel.AutoSize = true;
            updateIdlabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            updateIdlabel.ForeColor = Color.White;
            updateIdlabel.Location = new Point(23, 75);
            updateIdlabel.Name = "updateIdlabel";
            updateIdlabel.Padding = new Padding(6);
            updateIdlabel.Size = new Size(315, 50);
            updateIdlabel.TabIndex = 17;
            updateIdlabel.Text = "Employee id to delete";
            updateIdlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom;
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(167, 168);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10);
            deleteButton.Size = new Size(138, 67);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click1;
            // 
            // EmployeeDeleteForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(512, 272);
            Controls.Add(deleteButton);
            Controls.Add(empDeleteIdInput);
            Controls.Add(updateIdlabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "EmployeeDeleteForm";
            Text = "EmployeeDeleteForm";
            Load += EmployeeDeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox empDeleteIdInput;
        private Label updateIdlabel;
        private Button deleteButton;
    }
}