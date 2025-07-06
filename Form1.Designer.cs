namespace avatar_toolset
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            load_avatars = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(2, 346);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(421, 23);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 330);
            label1.Name = "label1";
            label1.Size = new Size(35, 13);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(157, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(357, 21);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(157, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(357, 21);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(157, 101);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(357, 21);
            comboBox3.TabIndex = 4;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(157, 128);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(357, 21);
            comboBox4.TabIndex = 5;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // load_avatars
            // 
            load_avatars.Location = new Point(12, 12);
            load_avatars.Name = "load_avatars";
            load_avatars.Size = new Size(92, 28);
            load_avatars.TabIndex = 6;
            load_avatars.Text = "load avatar list";
            load_avatars.UseVisualStyleBackColor = true;
            load_avatars.Click += load_avatars_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 21);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 50);
            label2.Name = "label2";
            label2.Size = new Size(81, 13);
            label2.TabIndex = 8;
            label2.Text = "outfit Item guid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 77);
            label3.Name = "label3";
            label3.Size = new Size(128, 13);
            label3.TabIndex = 9;
            label3.Text = "avatar Color Swatch guid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 104);
            label4.Name = "label4";
            label4.Size = new Size(89, 13);
            label4.TabIndex = 10;
            label4.Text = "avatar Mask guid";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 131);
            label5.Name = "label5";
            label5.Size = new Size(91, 13);
            label5.TabIndex = 11;
            label5.Text = "avatar Decal guid";
            // 
            // button1
            // 
            button1.Location = new Point(12, 249);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 381);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(load_avatars);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button load_avatars;
        private OpenFileDialog openFileDialog1;
        public ProgressBar progressBar1;
        public Label label1;
        public ComboBox comboBox1;
        public ComboBox comboBox2;
        public ComboBox comboBox3;
        public ComboBox comboBox4;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
