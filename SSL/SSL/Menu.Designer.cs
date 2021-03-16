
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
            this.button1 = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnJoueur = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnJouer = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.tblButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(575, 85);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(282, 77);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hide (test)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(240, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(778, 667);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxLogo.TabIndex = 2;
            this.picBoxLogo.TabStop = false;
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 3;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.Controls.Add(this.btnQuitter, 2, 1);
            this.tblButton.Controls.Add(this.btnJoueur, 0, 0);
            this.tblButton.Controls.Add(this.btnOption, 0, 1);
            this.tblButton.Controls.Add(this.btnJouer, 1, 0);
            this.tblButton.Controls.Add(this.btnScore, 2, 0);
            this.tblButton.Location = new System.Drawing.Point(193, 552);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 2;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Size = new System.Drawing.Size(860, 165);
            this.tblButton.TabIndex = 3;
            // 
            // btnJoueur
            // 
            this.btnJoueur.Location = new System.Drawing.Point(3, 3);
            this.btnJoueur.Name = "btnJoueur";
            this.btnJoueur.Size = new System.Drawing.Size(280, 76);
            this.btnJoueur.TabIndex = 0;
            this.btnJoueur.Text = "Joueur";
            this.btnJoueur.UseVisualStyleBackColor = true;
            this.btnJoueur.Click += new System.EventHandler(this.btnJoueur_Click);
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(3, 85);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(280, 76);
            this.btnOption.TabIndex = 0;
            this.btnOption.Text = "Option";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(289, 3);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(280, 76);
            this.btnJouer.TabIndex = 0;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(575, 3);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(280, 76);
            this.btnScore.TabIndex = 0;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tblButton);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.tblButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnJoueur;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Button btnScore;
    }
}