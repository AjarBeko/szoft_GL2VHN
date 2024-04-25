namespace Adatkotes
{
    partial class Szerkesztes
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
            Name = new Label();
            Population = new Label();
            AreaInSquareKm = new Label();
            OK = new Button();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(61, 53);
            Name.Name = "Name";
            Name.Size = new Size(39, 15);
            Name.TabIndex = 0;
            Name.Text = "Name";
            // 
            // Population
            // 
            Population.AutoSize = true;
            Population.Location = new Point(61, 106);
            Population.Name = "Population";
            Population.Size = new Size(65, 15);
            Population.TabIndex = 1;
            Population.Text = "Population";
            // 
            // AreaInSquareKm
            // 
            AreaInSquareKm.AutoSize = true;
            AreaInSquareKm.Location = new Point(61, 161);
            AreaInSquareKm.Name = "AreaInSquareKm";
            AreaInSquareKm.Size = new Size(95, 15);
            AreaInSquareKm.TabIndex = 2;
            AreaInSquareKm.Text = "AreaInSquareKm";
            // 
            // OK
            // 
            OK.Location = new Point(12, 244);
            OK.Name = "OK";
            OK.Size = new Size(269, 194);
            OK.TabIndex = 3;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBox1.Location = new Point(59, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 4;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBox2.Location = new Point(59, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBox3.Location = new Point(61, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 6;
            // 
            // Szerkesztes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(OK);
            Controls.Add(AreaInSquareKm);
            Controls.Add(Population);
            Controls.Add(Name);
            //Name = "Szerkesztes";
            //Text = "Szerkesztes";
            Load += Szerkesztes_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private Label Population;
        private Label AreaInSquareKm;
        private Button OK;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private BindingSource bindingSource1;
    }
}