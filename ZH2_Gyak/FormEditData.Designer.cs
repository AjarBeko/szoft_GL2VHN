namespace ZH2_Gyak
{
    partial class FormEditData
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button_Ok = new Button();
            sorszam_box = new TextBox();
            new_kerdes = new TextBox();
            new_1answer = new TextBox();
            new_2answer = new TextBox();
            new_3answer = new TextBox();
            right_answer = new TextBox();
            vizsgakérdésBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)vizsgakérdésBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Sorszám:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 80);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 1;
            label2.Text = "Kérdés szövege:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 178);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "1. válasz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 178);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "2. válasz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 266);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "3. válasz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 356);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 5;
            label6.Text = "Helyes válasz:";
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(679, 401);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(94, 29);
            button_Ok.TabIndex = 6;
            button_Ok.Text = "&Ok";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // sorszam_box
            // 
            sorszam_box.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "Szam", true));
            sorszam_box.Location = new Point(37, 32);
            sorszam_box.Name = "sorszam_box";
            sorszam_box.Size = new Size(115, 27);
            sorszam_box.TabIndex = 7;
            // 
            // new_kerdes
            // 
            new_kerdes.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "Kerdes", true));
            new_kerdes.Location = new Point(39, 103);
            new_kerdes.Multiline = true;
            new_kerdes.Name = "new_kerdes";
            new_kerdes.Size = new Size(734, 65);
            new_kerdes.TabIndex = 8;
            // 
            // new_1answer
            // 
            new_1answer.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "V1", true));
            new_1answer.Location = new Point(39, 201);
            new_1answer.Multiline = true;
            new_1answer.Name = "new_1answer";
            new_1answer.Size = new Size(346, 58);
            new_1answer.TabIndex = 9;
            // 
            // new_2answer
            // 
            new_2answer.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "V2", true));
            new_2answer.Location = new Point(442, 201);
            new_2answer.Multiline = true;
            new_2answer.Name = "new_2answer";
            new_2answer.Size = new Size(346, 58);
            new_2answer.TabIndex = 10;
            // 
            // new_3answer
            // 
            new_3answer.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "V3", true));
            new_3answer.Location = new Point(39, 289);
            new_3answer.Multiline = true;
            new_3answer.Name = "new_3answer";
            new_3answer.Size = new Size(346, 58);
            new_3answer.TabIndex = 11;
            // 
            // right_answer
            // 
            right_answer.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "HelyesValasz", true));
            right_answer.Location = new Point(39, 379);
            right_answer.Name = "right_answer";
            right_answer.Size = new Size(193, 27);
            right_answer.TabIndex = 12;
            // 
            // vizsgakérdésBindingSource
            // 
            vizsgakérdésBindingSource.DataSource = typeof(Vizsgakérdés);
            // 
            // FormEditData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(right_answer);
            Controls.Add(new_3answer);
            Controls.Add(new_2answer);
            Controls.Add(new_1answer);
            Controls.Add(new_kerdes);
            Controls.Add(sorszam_box);
            Controls.Add(button_Ok);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEditData";
            Text = "FormEditData";
            Load += FormEditData_Load;
            ((System.ComponentModel.ISupportInitialize)vizsgakérdésBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_Ok;
        private TextBox sorszam_box;
        private TextBox new_kerdes;
        private TextBox new_1answer;
        private TextBox new_2answer;
        private TextBox new_3answer;
        private TextBox right_answer;
        private BindingSource vizsgakérdésBindingSource;
    }
}