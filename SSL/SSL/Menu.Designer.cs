
namespace SSL
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnJoueur = new System.Windows.Forms.Button();
            this.btnJouer = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(1126, 12);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(142, 58);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(465, 50);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(406, 377);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 2;
            this.picBoxLogo.TabStop = false;
            // 
            // btnJoueur
            // 
            this.btnJoueur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoueur.Location = new System.Drawing.Point(420, 463);
            this.btnJoueur.Margin = new System.Windows.Forms.Padding(0);
            this.btnJoueur.Name = "btnJoueur";
            this.btnJoueur.Size = new System.Drawing.Size(150, 80);
            this.btnJoueur.TabIndex = 0;
            this.btnJoueur.Text = "Joueur";
            this.btnJoueur.UseVisualStyleBackColor = true;
            this.btnJoueur.Click += new System.EventHandler(this.btnJoueur_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(597, 463);
            this.btnJouer.Margin = new System.Windows.Forms.Padding(0);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(150, 80);
            this.btnJouer.TabIndex = 0;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // btnScore
            // 
            this.btnScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(782, 463);
            this.btnScore.Margin = new System.Windows.Forms.Padding(0);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(150, 80);
            this.btnScore.TabIndex = 0;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnJoueur);
            this.Controls.Add(this.picBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button btnJoueur;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Button btnScore;
    }
}