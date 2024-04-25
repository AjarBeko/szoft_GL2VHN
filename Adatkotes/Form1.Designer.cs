namespace Adatkotes
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            populationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaInSquareKmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataBindingSource = new BindingSource(components);
            Törlés = new Button();
            Szerkesztés = new Button();
            Megnyitás = new Button();
            Mentés = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, populationDataGridViewTextBoxColumn, areaInSquareKmDataGridViewTextBoxColumn });
            dataGridView1.DataSource = countryDataBindingSource;
            dataGridView1.Location = new Point(12, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(746, 260);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn.HeaderText = "Population";
            populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // Törlés
            // 
            Törlés.Location = new Point(540, 407);
            Törlés.Name = "Törlés";
            Törlés.Size = new Size(75, 23);
            Törlés.TabIndex = 1;
            Törlés.Text = "Törlés";
            Törlés.UseVisualStyleBackColor = true;
            Törlés.Click += Törlés_Click;
            // 
            // Szerkesztés
            // 
            Szerkesztés.Location = new Point(659, 407);
            Szerkesztés.Name = "Szerkesztés";
            Szerkesztés.Size = new Size(75, 23);
            Szerkesztés.TabIndex = 2;
            Szerkesztés.Text = "Szerkesztés1";
            Szerkesztés.UseVisualStyleBackColor = true;
            Szerkesztés.Click += Szerkesztés_Click;
            // 
            // Megnyitás
            // 
            Megnyitás.Location = new Point(683, 46);
            Megnyitás.Name = "Megnyitás";
            Megnyitás.Size = new Size(75, 23);
            Megnyitás.TabIndex = 3;
            Megnyitás.Text = "Megnyitás";
            Megnyitás.UseVisualStyleBackColor = true;
            Megnyitás.Click += Megnyitás_Click;
            // 
            // Mentés
            // 
            Mentés.Location = new Point(419, 407);
            Mentés.Name = "Mentés";
            Mentés.Size = new Size(75, 23);
            Mentés.TabIndex = 4;
            Mentés.Text = "Mentés";
            Mentés.UseVisualStyleBackColor = true;
            Mentés.Click += Mentés_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mentés);
            Controls.Add(Megnyitás);
            Controls.Add(Szerkesztés);
            Controls.Add(Törlés);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Törlés;
        private Button Szerkesztés;
        private Button Megnyitás;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private BindingSource countryDataBindingSource;
        private Button Mentés;
    }
}