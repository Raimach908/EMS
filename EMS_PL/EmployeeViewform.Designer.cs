namespace EMS_PL
{
    partial class EmployeeViewform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeViewform));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            employeeHeadingLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            searchButton = new Button();
            searchPlaceholderInput = new TextBox();
            employeesTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).BeginInit();
            SuspendLayout();
            // 
            // employeeHeadingLabel
            // 
            employeeHeadingLabel.Anchor = AnchorStyles.Top;
            employeeHeadingLabel.AutoSize = true;
            employeeHeadingLabel.FlatStyle = FlatStyle.Popup;
            employeeHeadingLabel.Font = new Font("Algerian", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeHeadingLabel.ForeColor = Color.White;
            employeeHeadingLabel.Location = new Point(599, 39);
            employeeHeadingLabel.Name = "employeeHeadingLabel";
            employeeHeadingLabel.Padding = new Padding(10);
            employeeHeadingLabel.Size = new Size(346, 55);
            employeeHeadingLabel.TabIndex = 4;
            employeeHeadingLabel.Text = "Employee's Record";
            employeeHeadingLabel.TextAlign = ContentAlignment.TopCenter;
            employeeHeadingLabel.Click += employeeHeadingLabel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 684);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 681);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(searchPlaceholderInput);
            panel2.Controls.Add(employeesTable);
            panel2.Location = new Point(327, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 596);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom;
            searchButton.BackColor = Color.Green;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(710, 51);
            searchButton.Name = "searchButton";
            searchButton.Padding = new Padding(10);
            searchButton.Size = new Size(131, 69);
            searchButton.TabIndex = 11;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchPlaceholderInput
            // 
            searchPlaceholderInput.Anchor = AnchorStyles.Left;
            searchPlaceholderInput.Cursor = Cursors.IBeam;
            searchPlaceholderInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPlaceholderInput.ForeColor = Color.Black;
            searchPlaceholderInput.Location = new Point(179, 51);
            searchPlaceholderInput.Multiline = true;
            searchPlaceholderInput.Name = "searchPlaceholderInput";
            searchPlaceholderInput.PlaceholderText = " Search by name, position, dept id";
            searchPlaceholderInput.Size = new Size(504, 69);
            searchPlaceholderInput.TabIndex = 2;
            searchPlaceholderInput.TextChanged += searchPlaceholderInput_TextChanged;
            // 
            // employeesTable
            // 
            employeesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeesTable.BackgroundColor = Color.Gainsboro;
            employeesTable.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            employeesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            employeesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesTable.Location = new Point(0, 152);
            employeesTable.Name = "employeesTable";
            employeesTable.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(2);
            employeesTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            employeesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeesTable.Size = new Size(869, 441);
            employeesTable.TabIndex = 1;
            employeesTable.CellContentClick += employeesTable_CellContentClick;
            // 
            // EmployeeViewform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1208, 697);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(employeeHeadingLabel);
            Name = "EmployeeViewform";
            Text = "EmployeeViewform";
            Load += EmployeeViewform_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employeeHeadingLabel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView employeesTable;
        private TextBox searchPlaceholderInput;
        private Button searchButton;
    }
}