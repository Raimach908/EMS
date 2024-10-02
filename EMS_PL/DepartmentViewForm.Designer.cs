namespace EMS_PL
{
    partial class DepartmentViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentViewForm));
            panel2 = new Panel();
            employeesTable = new DataGridView();
            searchButton = new Button();
            searchPlaceholderInput = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            employeeHeadingLabel = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(employeesTable);
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(searchPlaceholderInput);
            panel2.Location = new Point(365, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 587);
            panel2.TabIndex = 9;
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
            employeesTable.Location = new Point(0, 146);
            employeesTable.Name = "employeesTable";
            employeesTable.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(2);
            employeesTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            employeesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeesTable.Size = new Size(828, 438);
            employeesTable.TabIndex = 12;
            employeesTable.CellContentClick += employeesTable_CellContentClick;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom;
            searchButton.BackColor = Color.Green;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(655, 42);
            searchButton.Name = "searchButton";
            searchButton.Padding = new Padding(10);
            searchButton.Size = new Size(131, 75);
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
            searchPlaceholderInput.Location = new Point(110, 54);
            searchPlaceholderInput.Multiline = true;
            searchPlaceholderInput.Name = "searchPlaceholderInput";
            searchPlaceholderInput.PlaceholderText = " Search by dept id";
            searchPlaceholderInput.Size = new Size(504, 51);
            searchPlaceholderInput.TabIndex = 2;
            searchPlaceholderInput.TextChanged += searchPlaceholderInput_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(50, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 684);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 678);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // employeeHeadingLabel
            // 
            employeeHeadingLabel.Anchor = AnchorStyles.Top;
            employeeHeadingLabel.AutoSize = true;
            employeeHeadingLabel.FlatStyle = FlatStyle.Popup;
            employeeHeadingLabel.Font = new Font("Algerian", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeHeadingLabel.ForeColor = Color.White;
            employeeHeadingLabel.Location = new Point(582, 22);
            employeeHeadingLabel.Name = "employeeHeadingLabel";
            employeeHeadingLabel.Padding = new Padding(10);
            employeeHeadingLabel.Size = new Size(387, 55);
            employeeHeadingLabel.TabIndex = 7;
            employeeHeadingLabel.Text = "Department's Record";
            employeeHeadingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DepartmentViewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1208, 697);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(employeeHeadingLabel);
            Name = "DepartmentViewForm";
            Text = "DepartmentViewForm";
            Load += DepartmentViewForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button searchButton;
        private TextBox searchPlaceholderInput;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label employeeHeadingLabel;
        private DataGridView employeesTable;
    }
}