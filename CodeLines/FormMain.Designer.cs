namespace CodeLines
{
    partial class FormMain
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.openFileDialogSelect = new System.Windows.Forms.OpenFileDialog();
            this.textBoxLineCounts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSelect.Location = new System.Drawing.Point(12, 12);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(160, 97);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select Repository";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // openFileDialogSelect
            // 
            this.openFileDialogSelect.FileName = ".gitignore";
            this.openFileDialogSelect.Filter = "Git Ignore Files | .gitignore";
            this.openFileDialogSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSelect_FileOk);
            // 
            // textBoxLineCounts
            // 
            this.textBoxLineCounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLineCounts.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLineCounts.Location = new System.Drawing.Point(12, 130);
            this.textBoxLineCounts.Multiline = true;
            this.textBoxLineCounts.Name = "textBoxLineCounts";
            this.textBoxLineCounts.ReadOnly = true;
            this.textBoxLineCounts.Size = new System.Drawing.Size(160, 0);
            this.textBoxLineCounts.TabIndex = 1;
            this.textBoxLineCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 121);
            this.Controls.Add(this.textBoxLineCounts);
            this.Controls.Add(this.buttonSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Code Lines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelect;
        private System.Windows.Forms.TextBox textBoxLineCounts;
    }
}

