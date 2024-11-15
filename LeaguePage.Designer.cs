namespace AffaManagementSoftware
{
    partial class LeaguePage
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
            this.btn_export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_export.Location = new System.Drawing.Point(137, 467);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(132, 48);
            this.btn_export.TabIndex = 0;
            this.btn_export.Text = "Export To Excel";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // LeaguePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 527);
            this.Controls.Add(this.btn_export);
            this.Name = "LeaguePage";
            this.Text = "LeaguePage";
            this.Load += new System.EventHandler(this.LeaguePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_export;
    }
}