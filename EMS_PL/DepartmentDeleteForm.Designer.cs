namespace EMS_PL
{
    partial class DepartmentDeleteForm
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
            deleteButton = new Button();
            empDeleteIdInput = new TextBox();
            updateIdlabel = new Label();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom;
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(202, 193);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10);
            deleteButton.Size = new Size(137, 67);
            deleteButton.TabIndex = 22;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // empDeleteIdInput
            // 
            empDeleteIdInput.Anchor = AnchorStyles.Top;
            empDeleteIdInput.Cursor = Cursors.IBeam;
            empDeleteIdInput.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            empDeleteIdInput.Location = new Point(388, 95);
            empDeleteIdInput.Name = "empDeleteIdInput";
            empDeleteIdInput.Size = new Size(121, 45);
            empDeleteIdInput.TabIndex = 21;
            empDeleteIdInput.TextChanged += empDeleteIdInput_TextChanged;
            // 
            // updateIdlabel
            // 
            updateIdlabel.Anchor = AnchorStyles.Top;
            updateIdlabel.AutoSize = true;
            updateIdlabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            updateIdlabel.ForeColor = Color.White;
            updateIdlabel.Location = new Point(22, 92);
            updateIdlabel.Name = "updateIdlabel";
            updateIdlabel.Padding = new Padding(6);
            updateIdlabel.Size = new Size(347, 50);
            updateIdlabel.TabIndex = 20;
            updateIdlabel.Text = "Department id to delete";
            updateIdlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DepartmentDeleteForm
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(536, 336);
            Controls.Add(deleteButton);
            Controls.Add(empDeleteIdInput);
            Controls.Add(updateIdlabel);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "DepartmentDeleteForm";
            Text = "DepartmentDeleteForm";
            Load += DepartmentDeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private TextBox empDeleteIdInput;
        private Label updateIdlabel;
    }
}