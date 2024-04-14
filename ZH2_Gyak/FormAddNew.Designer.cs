namespace ZH2_Gyak
{
    partial class FormAddNew
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
            ok = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // ok
            // 
            ok.DialogResult = DialogResult.OK;
            ok.Location = new Point(641, 434);
            ok.Name = "ok";
            ok.Size = new Size(126, 39);
            ok.TabIndex = 0;
            ok.Text = "&Ok";
            ok.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(487, 434);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(126, 39);
            Cancel.TabIndex = 1;
            Cancel.Text = "&Mégse";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 505);
            Controls.Add(Cancel);
            Controls.Add(ok);
            Name = "FormAddNew";
            Text = "FormAddNew";
            ResumeLayout(false);
        }

        #endregion

        private Button ok;
        private Button Cancel;
    }
}