namespace PrintLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            printDialog1 = new PrintDialog();
            openFileDialog1 = new OpenFileDialog();
            b1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            b2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(324, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // b1
            // 
            b1.Location = new Point(367, 15);
            b1.Name = "b1";
            b1.Size = new Size(113, 48);
            b1.TabIndex = 1;
            b1.Text = "Открыть";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 151);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "Выберите препарат";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(354, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 85);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 4;
            label2.Text = "Введите номер серии";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 115);
            label3.Name = "label3";
            label3.Size = new Size(199, 20);
            label3.TabIndex = 7;
            label3.Text = "Введите дату производства";
            // 
            // b2
            // 
            b2.Location = new Point(367, 219);
            b2.Name = "b2";
            b2.Size = new Size(113, 48);
            b2.TabIndex = 8;
            b2.Text = "Печать";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(210, 115);
            maskedTextBox1.Mask = "00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(74, 27);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(b2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(b1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 302);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(210, 82);
            maskedTextBox2.Mask = "000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(74, 27);
            maskedTextBox2.TabIndex = 10;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(507, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 302);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вид";
            // 
            // label14
            // 
            label14.Location = new Point(313, 64);
            label14.Name = "label14";
            label14.Size = new Size(125, 20);
            label14.TabIndex = 11;
            label14.Text = "@DATA";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 64);
            label13.Name = "label13";
            label13.Size = new Size(166, 20);
            label13.TabIndex = 10;
            label13.Text = "ДАТА ПРОИЗВОДСТВА";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 179);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.Location = new Point(313, 144);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(125, 20);
            label12.TabIndex = 8;
            label12.Text = "@GTIN";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Location = new Point(313, 115);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 7;
            label11.Text = "@SERIA";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 118);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 6;
            label10.Text = "СЕРИЯ";
            // 
            // label9
            // 
            label9.Location = new Point(313, 89);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(125, 20);
            label9.TabIndex = 5;
            label9.Text = "@KOLVO";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(137, 267);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 4;
            label8.Text = "000000000000000000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 144);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 3;
            label7.Text = "GTIN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 115);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 89);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 1;
            label5.Text = "КОЛ-ВО";
            // 
            // label4
            // 
            label4.Location = new Point(15, 23);
            label4.Name = "label4";
            label4.Size = new Size(423, 50);
            label4.TabIndex = 0;
            label4.Text = "@NAME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 328);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "PrintLabel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private PrintDialog printDialog1;
        private OpenFileDialog openFileDialog1;
        private Button b1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button b2;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label13;
        private Label label14;
        private MaskedTextBox maskedTextBox2;
    }
}