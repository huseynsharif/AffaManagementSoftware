namespace AffaManagementSoftware
{
    partial class AdminPanel
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
            this.btn_clubs = new System.Windows.Forms.Button();
            this.btn_games = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clubs
            // 
            this.btn_clubs.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_clubs.Font = new System.Drawing.Font("Gulim", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_clubs.Location = new System.Drawing.Point(58, 157);
            this.btn_clubs.Name = "btn_clubs";
            this.btn_clubs.Size = new System.Drawing.Size(129, 88);
            this.btn_clubs.TabIndex = 0;
            this.btn_clubs.Text = "Klublar";
            this.btn_clubs.UseVisualStyleBackColor = false;
            this.btn_clubs.Click += new System.EventHandler(this.btn_clubs_Click);
            // 
            // btn_games
            // 
            this.btn_games.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_games.Font = new System.Drawing.Font("Gulim", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_games.Location = new System.Drawing.Point(280, 157);
            this.btn_games.Name = "btn_games";
            this.btn_games.Size = new System.Drawing.Size(129, 88);
            this.btn_games.TabIndex = 1;
            this.btn_games.Text = "Oyunlar";
            this.btn_games.UseVisualStyleBackColor = false;
            this.btn_games.Click += new System.EventHandler(this.btn_games_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 402);
            this.Controls.Add(this.btn_games);
            this.Controls.Add(this.btn_clubs);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clubs;
        private System.Windows.Forms.Button btn_games;
    }
}