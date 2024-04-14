namespace Adatkotesek2
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
            countryDataBindingSource = new BindingSource(components);
            megnyitas = new Button();
            szerkesztes = new Button();
            torles = new Button();
            mentes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(762, 245);
            dataGridView1.TabIndex = 0;
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // megnyitas
            // 
            megnyitas.Location = new Point(688, 37);
            megnyitas.Name = "megnyitas";
            megnyitas.Size = new Size(94, 29);
            megnyitas.TabIndex = 1;
            megnyitas.Text = "Megnyitás";
            megnyitas.UseVisualStyleBackColor = true;
            megnyitas.Click += megnyitas_Click;
            // 
            // szerkesztes
            // 
            szerkesztes.Location = new Point(660, 413);
            szerkesztes.Name = "szerkesztes";
            szerkesztes.Size = new Size(94, 29);
            szerkesztes.TabIndex = 2;
            szerkesztes.Text = "Szerkesztés";
            szerkesztes.UseVisualStyleBackColor = true;
            szerkesztes.Click += szerkesztes_Click;
            // 
            // torles
            // 
            torles.Location = new Point(560, 413);
            torles.Name = "torles";
            torles.Size = new Size(94, 29);
            torles.TabIndex = 3;
            torles.Text = "Törlés";
            torles.UseVisualStyleBackColor = true;
            torles.Click += torles_Click;
            // 
            // mentes
            // 
            mentes.Location = new Point(465, 412);
            mentes.Name = "mentes";
            mentes.Size = new Size(89, 26);
            mentes.TabIndex = 4;
            mentes.Text = "Mentés";
            mentes.UseVisualStyleBackColor = true;
            mentes.Click += mentes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mentes);
            Controls.Add(torles);
            Controls.Add(szerkesztes);
            Controls.Add(megnyitas);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button megnyitas;
        private Button szerkesztes;
        private Button torles;
        private BindingSource countryDataBindingSource;
        private Button mentes;
    }
}
