namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            label13 = new Label();
            textBox13 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage3 = new TabPage();
            label12 = new Label();
            textBox12 = new TextBox();
            button2 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            tabPage4 = new TabPage();
            button3 = new Button();
            label11 = new Label();
            textBox11 = new TextBox();
            backtomenu = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(37, 37);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1155, 754);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BackgroundImage = Properties.Resources.размытый;
            tabPage1.Controls.Add(listBox1);
            tabPage1.ImageKey = "(нет)";
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1147, 716);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SELECT";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(234, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(666, 404);
            listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.размытый;
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox13);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1147, 716);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "INSERT";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(690, 56);
            label13.Name = "label13";
            label13.Size = new Size(139, 25);
            label13.TabIndex = 12;
            label13.Text = "ID футболиста";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(322, 50);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(303, 31);
            textBox13.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(497, 590);
            button1.Name = "button1";
            button1.Size = new Size(190, 57);
            button1.TabIndex = 10;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(690, 477);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 9;
            label5.Text = "ID страны";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(690, 384);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 8;
            label4.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(690, 298);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 7;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(690, 210);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 6;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(690, 127);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 5;
            label1.Text = "Фамилия";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(322, 471);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(303, 31);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(322, 378);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(322, 292);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(322, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 31);
            textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.размытый;
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBox12);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox10);
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1147, 716);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "UPDATE";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(696, 60);
            label12.Name = "label12";
            label12.Size = new Size(139, 25);
            label12.TabIndex = 12;
            label12.Text = "ID футболиста";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(328, 54);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(303, 31);
            textBox12.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(500, 596);
            button2.Name = "button2";
            button2.Size = new Size(190, 57);
            button2.TabIndex = 10;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(696, 481);
            label10.Name = "label10";
            label10.Size = new Size(100, 25);
            label10.TabIndex = 9;
            label10.Text = "ID страны";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(696, 386);
            label9.Name = "label9";
            label9.Size = new Size(149, 25);
            label9.TabIndex = 8;
            label9.Text = "Дата рождения";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(696, 301);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 7;
            label8.Text = "Отчество";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(696, 215);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 6;
            label7.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(696, 138);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 5;
            label6.Text = "Фамилия";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(328, 475);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(303, 31);
            textBox10.TabIndex = 4;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(328, 380);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(303, 31);
            textBox9.TabIndex = 3;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(328, 295);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(303, 31);
            textBox8.TabIndex = 2;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(328, 209);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(303, 31);
            textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(328, 132);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(303, 31);
            textBox6.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(textBox11);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1147, 716);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "DELITE";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.Location = new Point(520, 190);
            button3.Name = "button3";
            button3.Size = new Size(190, 57);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(648, 105);
            label11.Name = "label11";
            label11.Size = new Size(133, 25);
            label11.TabIndex = 1;
            label11.Text = "ID футболиста";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(443, 102);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(150, 31);
            textBox11.TabIndex = 0;
            // 
            // backtomenu
            // 
            backtomenu.AutoSize = true;
            backtomenu.BackColor = Color.Transparent;
            backtomenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            backtomenu.ForeColor = SystemColors.Control;
            backtomenu.Location = new Point(989, 18);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(154, 25);
            backtomenu.TabIndex = 1;
            backtomenu.Text = "В главное меню";
            backtomenu.Click += backtomenu_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.футбол_без_текста;
            ClientSize = new Size(1221, 832);
            Controls.Add(backtomenu);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label backtomenu;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox10;
        private Label label6;
        private Button button2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button3;
        private Label label11;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox12;
        private Label label13;
        private TextBox textBox13;
    }
}