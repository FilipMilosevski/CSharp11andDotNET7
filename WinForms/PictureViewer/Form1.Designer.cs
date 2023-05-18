namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            showbtn = new Button();
            clearbtn = new Button();
            backgroundbtn = new Button();
            closebtn = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(615, 318);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 289);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Strech";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(showbtn);
            flowLayoutPanel1.Controls.Add(clearbtn);
            flowLayoutPanel1.Controls.Add(backgroundbtn);
            flowLayoutPanel1.Controls.Add(closebtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(95, 289);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(517, 26);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // showbtn
            // 
            showbtn.AutoSize = true;
            showbtn.Location = new Point(419, 3);
            showbtn.Name = "showbtn";
            showbtn.Size = new Size(95, 25);
            showbtn.TabIndex = 0;
            showbtn.Text = "Show a picture";
            showbtn.UseVisualStyleBackColor = true;
            showbtn.Click += showbtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.AutoSize = true;
            clearbtn.Location = new Point(309, 3);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(104, 25);
            clearbtn.TabIndex = 1;
            clearbtn.Text = "Clear the picture";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // backgroundbtn
            // 
            backgroundbtn.AutoSize = true;
            backgroundbtn.Location = new Point(153, 3);
            backgroundbtn.Name = "backgroundbtn";
            backgroundbtn.Size = new Size(150, 25);
            backgroundbtn.TabIndex = 2;
            backgroundbtn.Text = "Set the background color";
            backgroundbtn.UseVisualStyleBackColor = true;
            backgroundbtn.Click += backgroundbtn_Click;
            // 
            // closebtn
            // 
            closebtn.AutoSize = true;
            closebtn.Location = new Point(72, 3);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(75, 25);
            closebtn.TabIndex = 3;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 280);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a picture";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 318);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Picture Viewer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button showbtn;
        private Button clearbtn;
        private Button backgroundbtn;
        private Button closebtn;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
    }
}