namespace AffaManagementSoftware
{
    partial class ClubsPage
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
            this.dgw_clubs = new System.Windows.Forms.DataGridView();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_clubs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_clubs
            // 
            this.dgw_clubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_clubs.Location = new System.Drawing.Point(59, 109);
            this.dgw_clubs.Name = "dgw_clubs";
            this.dgw_clubs.RowTemplate.Height = 23;
            this.dgw_clubs.Size = new System.Drawing.Size(240, 373);
            this.dgw_clubs.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(59, 57);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(138, 21);
            this.tb_name.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Cyan;
            this.btn_save.Location = new System.Drawing.Point(223, 57);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Əlavə et";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ClubsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 505);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.dgw_clubs);
            this.Name = "ClubsPage";
            this.Text = "ClubsPage";
            this.Load += new System.EventHandler(this.ClubsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_clubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_clubs;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_save;
    }
}