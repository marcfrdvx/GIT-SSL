
namespace SSL
{
    partial class Jouer
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
            this.lblTrait = new System.Windows.Forms.Label();
            this.lblCG = new System.Windows.Forms.Label();
            this.picBoxCG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(141, 50);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblTrait
            // 
            this.lblTrait.AutoSize = true;
            this.lblTrait.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrait.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrait.Location = new System.Drawing.Point(192, 205);
            this.lblTrait.Name = "lblTrait";
            this.lblTrait.Size = new System.Drawing.Size(291, 36);
            this.lblTrait.TabIndex = 3;
            this.lblTrait.Text = "-----------------------";
            // 
            // lblCG
            // 
            this.lblCG.AutoSize = true;
            this.lblCG.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCG.Location = new System.Drawing.Point(152, 240);
            this.lblCG.Name = "lblCG";
            this.lblCG.Size = new System.Drawing.Size(379, 36);
            this.lblCG.TabIndex = 3;
            this.lblCG.Text = "CULTURE GENERALE";
            // 
            // picBoxCG
            // 
            this.picBoxCG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCG.Image = global::SSL.Properties.Resources.CG;
            this.picBoxCG.Location = new System.Drawing.Point(198, 69);
            this.picBoxCG.Name = "picBoxCG";
            this.picBoxCG.Size = new System.Drawing.Size(285, 132);
            this.picBoxCG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCG.TabIndex = 2;
            this.picBoxCG.TabStop = false;
            this.picBoxCG.Click += new System.EventHandler(this.picBoxCG_Click);
            // 
            // Jouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblCG);
            this.Controls.Add(this.lblTrait);
            this.Controls.Add(this.picBoxCG);
            this.Controls.Add(this.btnRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jouer";
            this.Text = "Jouer";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Jouer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox picBoxCG;
        private System.Windows.Forms.Label lblTrait;
        private System.Windows.Forms.Label lblCG;
    }
}