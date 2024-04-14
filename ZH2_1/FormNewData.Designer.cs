namespace ZH2_1
{
    partial class FormNewData
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
            components = new System.ComponentModel.Container();
            Szám = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            vizsgaKerdesekBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)vizsgaKerdesekBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Szám
            // 
            Szám.AutoSize = true;
            Szám.Location = new Point(12, 9);
            Szám.Name = "Szám";
            Szám.Size = new Size(45, 20);
            Szám.TabIndex = 0;
            Szám.Text = "Szám";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Kérdés";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 2;
            label3.Text = "V1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 178);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 3;
            label4.Text = "V2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 274);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 4;
            label5.Text = "V3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 349);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 5;
            label6.Text = "Helyes válasz";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(632, 385);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", vizsgaKerdesekBindingSource, "Szam", true));
            textBox1.Location = new Point(12, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 34);
            textBox1.TabIndex = 7;
            // 
            // vizsgaKerdesekBindingSource
            // 
            vizsgaKerdesekBindingSource.DataSource = typeof(VizsgaKerdesek);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", vizsgaKerdesekBindingSource, "Kerdes", true));
            textBox2.Location = new Point(12, 122);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 34);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", vizsgaKerdesekBindingSource, "V1", true));
            textBox3.Location = new Point(12, 218);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(340, 34);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", vizsgaKerdesekBindingSource, "V2", true));
            textBox4.Location = new Point(426, 218);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(340, 34);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", vizsgaKerdesekBindingSource, "V3", true));
            textBox5.Location = new Point(12, 312);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(340, 34);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", vizsgaKerdesekBindingSource, "HelyesValasz", true));
            textBox6.Location = new Point(12, 386);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(340, 34);
            textBox6.TabIndex = 12;
            // 
            // cancel
            // 
            cancel.DialogResult = DialogResult.Cancel;
            cancel.Location = new Point(515, 385);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 13;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // FormNewData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancel);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Szám);
            Name = "FormNewData";
            Text = "FormEditData";
            Load += FormNewData_Load;
            ((System.ComponentModel.ISupportInitialize)vizsgaKerdesekBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Szám;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button cancel;
        private BindingSource vizsgaKerdesekBindingSource;
    }
}