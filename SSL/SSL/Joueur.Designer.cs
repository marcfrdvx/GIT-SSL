
namespace SSL
{
    partial class Joueur
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAddPlayer = new System.Windows.Forms.TextBox();
            this.splitContainerJoueur = new System.Windows.Forms.SplitContainer();
            this.picBoxDelPlayer = new System.Windows.Forms.PictureBox();
            this.picBoxAddPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerJoueur)).BeginInit();
            this.splitContainerJoueur.Panel2.SuspendLayout();
            this.splitContainerJoueur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(143, 57);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(474, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des Joueurs";
            // 
            // tbxAddPlayer
            // 
            this.tbxAddPlayer.Location = new System.Drawing.Point(462, 363);
            this.tbxAddPlayer.Name = "tbxAddPlayer";
            this.tbxAddPlayer.Size = new System.Drawing.Size(248, 20);
            this.tbxAddPlayer.TabIndex = 3;
            this.tbxAddPlayer.Text = "Ajouter un joueur";
            // 
            // splitContainerJoueur
            // 
            this.splitContainerJoueur.Location = new System.Drawing.Point(480, 428);
            this.splitContainerJoueur.Name = "splitContainerJoueur";
            // 
            // splitContainerJoueur.Panel2
            // 
            this.splitContainerJoueur.Panel2.Controls.Add(this.picBoxDelPlayer);
            this.splitContainerJoueur.Size = new System.Drawing.Size(319, 151);
            this.splitContainerJoueur.SplitterDistance = 229;
            this.splitContainerJoueur.TabIndex = 6;
            // 
            // picBoxDelPlayer
            // 
            this.picBoxDelPlayer.Image = global::SSL.Properties.Resources.iconMinus;
            this.picBoxDelPlayer.Location = new System.Drawing.Point(21, 3);
            this.picBoxDelPlayer.Name = "picBoxDelPlayer";
            this.picBoxDelPlayer.Size = new System.Drawing.Size(44, 31);
            this.picBoxDelPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDelPlayer.TabIndex = 0;
            this.picBoxDelPlayer.TabStop = false;
            // 
            // picBoxAddPlayer
            // 
            this.picBoxAddPlayer.Image = global::SSL.Properties.Resources.iconPlus;
            this.picBoxAddPlayer.Location = new System.Drawing.Point(773, 353);
            this.picBoxAddPlayer.Name = "picBoxAddPlayer";
            this.picBoxAddPlayer.Size = new System.Drawing.Size(45, 39);
            this.picBoxAddPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAddPlayer.TabIndex = 5;
            this.picBoxAddPlayer.TabStop = false;
            this.picBoxAddPlayer.Click += new System.EventHandler(this.picBoxAddPlayer_Click);
            this.picBoxAddPlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxAddPlayer_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SSL.Properties.Resources.logoSSL;
            this.pictureBox1.Location = new System.Drawing.Point(462, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.splitContainerJoueur);
            this.Controls.Add(this.picBoxAddPlayer);
            this.Controls.Add(this.tbxAddPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Joueur";
            this.Text = "Joueur";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainerJoueur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerJoueur)).EndInit();
            this.splitContainerJoueur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAddPlayer;
        private System.Windows.Forms.PictureBox picBoxAddPlayer;
        private System.Windows.Forms.SplitContainer splitContainerJoueur;
        private System.Windows.Forms.PictureBox picBoxDelPlayer;
    }
}