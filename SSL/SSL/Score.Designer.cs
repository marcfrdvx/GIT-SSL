
namespace SSL
{
    partial class Score
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
            this.picBoxTrophy = new System.Windows.Forms.PictureBox();
            this.tblScore = new System.Windows.Forms.TableLayoutPanel();
            this.btnResetScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrophy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(143, 57);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // picBoxTrophy
            // 
            this.picBoxTrophy.Image = global::SSL.Properties.Resources.trophy;
            this.picBoxTrophy.Location = new System.Drawing.Point(478, 12);
            this.picBoxTrophy.Name = "picBoxTrophy";
            this.picBoxTrophy.Size = new System.Drawing.Size(262, 219);
            this.picBoxTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTrophy.TabIndex = 2;
            this.picBoxTrophy.TabStop = false;
            // 
            // tblScore
            // 
            this.tblScore.AutoSize = true;
            this.tblScore.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tblScore.ColumnCount = 3;
            this.tblScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblScore.Location = new System.Drawing.Point(430, 287);
            this.tblScore.Margin = new System.Windows.Forms.Padding(0);
            this.tblScore.Name = "tblScore";
            this.tblScore.RowCount = 1;
            this.tblScore.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblScore.Size = new System.Drawing.Size(368, 59);
            this.tblScore.TabIndex = 3;
            this.tblScore.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblScore_CellPaint);
            // 
            // btnResetScore
            // 
            this.btnResetScore.Location = new System.Drawing.Point(1125, 12);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(143, 57);
            this.btnResetScore.TabIndex = 1;
            this.btnResetScore.Text = "Remettre à zéro les scores";
            this.btnResetScore.UseVisualStyleBackColor = true;
            this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tblScore);
            this.Controls.Add(this.picBoxTrophy);
            this.Controls.Add(this.btnResetScore);
            this.Controls.Add(this.btnRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Score";
            this.Text = "Score";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrophy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox picBoxTrophy;
        private System.Windows.Forms.TableLayoutPanel tblScore;
        private System.Windows.Forms.Button btnResetScore;
    }
}