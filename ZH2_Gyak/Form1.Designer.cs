namespace ZH2_Gyak
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
            open = new Button();
            dataGridView1 = new DataGridView();
            szamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kerdesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            helyesValaszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vizsgakérdésBindingSource = new BindingSource(components);
            save = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            delete = new Button();
            Addnew = new Button();
            Edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vizsgakérdésBindingSource).BeginInit();
            SuspendLayout();
            // 
            // open
            // 
            open.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            open.BackColor = Color.Fuchsia;
            open.Location = new Point(628, 69);
            open.Name = "open";
            open.Size = new Size(334, 50);
            open.TabIndex = 0;
            open.Text = "Megnyitás";
            open.UseVisualStyleBackColor = false;
            open.Click += open_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { szamDataGridViewTextBoxColumn, kerdesDataGridViewTextBoxColumn, v1DataGridViewTextBoxColumn, v2DataGridViewTextBoxColumn, v3DataGridViewTextBoxColumn, kepDataGridViewTextBoxColumn, helyesValaszDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vizsgakérdésBindingSource;
            dataGridView1.Location = new Point(19, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 469);
            dataGridView1.TabIndex = 1;
            // 
            // szamDataGridViewTextBoxColumn
            // 
            szamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            szamDataGridViewTextBoxColumn.MinimumWidth = 6;
            szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            szamDataGridViewTextBoxColumn.Width = 74;
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            kerdesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            kerdesDataGridViewTextBoxColumn.MinimumWidth = 6;
            kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            // 
            // v1DataGridViewTextBoxColumn
            // 
            v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            v1DataGridViewTextBoxColumn.HeaderText = "V1";
            v1DataGridViewTextBoxColumn.MinimumWidth = 6;
            v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            v1DataGridViewTextBoxColumn.Visible = false;
            v1DataGridViewTextBoxColumn.Width = 125;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            v2DataGridViewTextBoxColumn.HeaderText = "V2";
            v2DataGridViewTextBoxColumn.MinimumWidth = 6;
            v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            v2DataGridViewTextBoxColumn.Visible = false;
            v2DataGridViewTextBoxColumn.Width = 125;
            // 
            // v3DataGridViewTextBoxColumn
            // 
            v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            v3DataGridViewTextBoxColumn.HeaderText = "V3";
            v3DataGridViewTextBoxColumn.MinimumWidth = 6;
            v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            v3DataGridViewTextBoxColumn.Visible = false;
            v3DataGridViewTextBoxColumn.Width = 125;
            // 
            // kepDataGridViewTextBoxColumn
            // 
            kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            kepDataGridViewTextBoxColumn.MinimumWidth = 6;
            kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            kepDataGridViewTextBoxColumn.Visible = false;
            kepDataGridViewTextBoxColumn.Width = 125;
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.MinimumWidth = 6;
            helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            helyesValaszDataGridViewTextBoxColumn.Visible = false;
            helyesValaszDataGridViewTextBoxColumn.Width = 125;
            // 
            // vizsgakérdésBindingSource
            // 
            vizsgakérdésBindingSource.DataSource = typeof(Vizsgakérdés);
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            save.BackColor = Color.Fuchsia;
            save.Location = new Point(799, 492);
            save.Name = "save";
            save.Size = new Size(163, 46);
            save.TabIndex = 2;
            save.Text = "Mentés";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "Kerdes", true));
            textBox1.Location = new Point(628, 125);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 73);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "V1", true));
            textBox2.Location = new Point(628, 204);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 73);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "V2", true));
            textBox3.Location = new Point(628, 283);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(334, 73);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Right;
            textBox4.DataBindings.Add(new Binding("Text", vizsgakérdésBindingSource, "V3", true));
            textBox4.Location = new Point(628, 362);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(334, 73);
            textBox4.TabIndex = 7;
            // 
            // delete
            // 
            delete.BackColor = Color.Fuchsia;
            delete.Location = new Point(799, 441);
            delete.Name = "delete";
            delete.Size = new Size(163, 45);
            delete.TabIndex = 8;
            delete.Text = "Törlés";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Addnew
            // 
            Addnew.BackColor = Color.Fuchsia;
            Addnew.Location = new Point(628, 441);
            Addnew.Name = "Addnew";
            Addnew.Size = new Size(165, 45);
            Addnew.TabIndex = 9;
            Addnew.Text = "Új";
            Addnew.UseVisualStyleBackColor = false;
            Addnew.Click += Addnew_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.Fuchsia;
            Edit.Location = new Point(628, 492);
            Edit.Name = "Edit";
            Edit.Size = new Size(165, 46);
            Edit.TabIndex = 10;
            Edit.Text = "Szerkesztés";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 562);
            Controls.Add(Edit);
            Controls.Add(Addnew);
            Controls.Add(delete);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(save);
            Controls.Add(dataGridView1);
            Controls.Add(open);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vizsgakérdésBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button open;
        private DataGridView dataGridView1;
        private Button save;
        private BindingSource vizsgakérdésBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
        private Button delete;
        private Button Addnew;
        private Button Edit;
    }
}
