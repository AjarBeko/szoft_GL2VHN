namespace Adatkotesek2
{
    partial class Szerkeszt
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
            name = new Label();
            area = new Label();
            population = new Label();
            namebox = new TextBox();
            bindingSource1 = new BindingSource(components);
            areabox = new TextBox();
            populationbox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(48, 43);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // area
            // 
            area.AutoSize = true;
            area.Location = new Point(48, 199);
            area.Name = "area";
            area.Size = new Size(88, 20);
            area.TabIndex = 1;
            area.Text = "Area in km2";
            // 
            // population
            // 
            population.AutoSize = true;
            population.Location = new Point(48, 120);
            population.Name = "population";
            population.Size = new Size(80, 20);
            population.TabIndex = 2;
            population.Text = "Population";
            // 
            // namebox
            // 
            namebox.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            namebox.Location = new Point(57, 75);
            namebox.Name = "namebox";
            namebox.Size = new Size(240, 27);
            namebox.TabIndex = 3;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // areabox
            // 
            areabox.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            areabox.Location = new Point(57, 244);
            areabox.Name = "areabox";
            areabox.Size = new Size(240, 27);
            areabox.TabIndex = 4;
            // 
            // populationbox
            // 
            populationbox.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            populationbox.Location = new Point(57, 155);
            populationbox.Name = "populationbox";
            populationbox.Size = new Size(240, 27);
            populationbox.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Location = new Point(168, 313);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Szerkeszt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(populationbox);
            Controls.Add(areabox);
            Controls.Add(namebox);
            Controls.Add(population);
            Controls.Add(area);
            Controls.Add(name);
            Name = "Szerkeszt";
            Text = "Szerkeszt";
            Load += Szerkeszt_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label area;
        private Label population;
        private TextBox namebox;
        private TextBox areabox;
        private TextBox populationbox;
        private Button button1;
        private BindingSource bindingSource1;
    }
}