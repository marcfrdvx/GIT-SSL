
namespace SSL
{
    partial class CultureGenerale
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
            this.lblJoueur = new System.Windows.Forms.Label();
            this.btnRepCarre = new System.Windows.Forms.Button();
            this.btnRepCash = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.picBoxRight = new System.Windows.Forms.PictureBox();
            this.panelChoixReponse = new System.Windows.Forms.Panel();
            this.tableCarre = new System.Windows.Forms.TableLayoutPanel();
            this.lblRep4 = new System.Windows.Forms.Label();
            this.lblRep2 = new System.Windows.Forms.Label();
            this.lblRep1 = new System.Windows.Forms.Label();
            this.lblRep3 = new System.Windows.Forms.Label();
            this.panelRepCash = new System.Windows.Forms.Panel();
            this.btnCashCorrect = new System.Windows.Forms.Button();
            this.lblRepCash = new System.Windows.Forms.Label();
            this.lblNumQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRight)).BeginInit();
            this.panelChoixReponse.SuspendLayout();
            this.tableCarre.SuspendLayout();
            this.panelRepCash.SuspendLayout();
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
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur.Location = new System.Drawing.Point(531, 38);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(190, 31);
            this.lblJoueur.TabIndex = 2;
            this.lblJoueur.Text = "Nom du joueur";
            // 
            // btnRepCarre
            // 
            this.btnRepCarre.Location = new System.Drawing.Point(3, 3);
            this.btnRepCarre.Name = "btnRepCarre";
            this.btnRepCarre.Size = new System.Drawing.Size(184, 77);
            this.btnRepCarre.TabIndex = 3;
            this.btnRepCarre.Text = "Carré";
            this.btnRepCarre.UseVisualStyleBackColor = true;
            this.btnRepCarre.Click += new System.EventHandler(this.btnRepCarre_Click);
            // 
            // btnRepCash
            // 
            this.btnRepCash.Location = new System.Drawing.Point(410, 3);
            this.btnRepCash.Name = "btnRepCash";
            this.btnRepCash.Size = new System.Drawing.Size(184, 77);
            this.btnRepCash.TabIndex = 3;
            this.btnRepCash.Text = "Cash";
            this.btnRepCash.UseVisualStyleBackColor = true;
            this.btnRepCash.Click += new System.EventHandler(this.btnRepCash_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(23, 166);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(168, 42);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question";
            // 
            // picBoxRight
            // 
            this.picBoxRight.Enabled = false;
            this.picBoxRight.Image = global::SSL.Properties.Resources.right_arrow;
            this.picBoxRight.Location = new System.Drawing.Point(1168, 12);
            this.picBoxRight.Name = "picBoxRight";
            this.picBoxRight.Size = new System.Drawing.Size(100, 50);
            this.picBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxRight.TabIndex = 5;
            this.picBoxRight.TabStop = false;
            this.picBoxRight.Click += new System.EventHandler(this.picBoxRight_Click);
            // 
            // panelChoixReponse
            // 
            this.panelChoixReponse.Controls.Add(this.btnRepCash);
            this.panelChoixReponse.Controls.Add(this.btnRepCarre);
            this.panelChoixReponse.Location = new System.Drawing.Point(337, 391);
            this.panelChoixReponse.Name = "panelChoixReponse";
            this.panelChoixReponse.Size = new System.Drawing.Size(597, 88);
            this.panelChoixReponse.TabIndex = 9;
            // 
            // tableCarre
            // 
            this.tableCarre.ColumnCount = 2;
            this.tableCarre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCarre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCarre.Controls.Add(this.lblRep4, 1, 1);
            this.tableCarre.Controls.Add(this.lblRep2, 1, 0);
            this.tableCarre.Controls.Add(this.lblRep1, 0, 0);
            this.tableCarre.Controls.Add(this.lblRep3, 0, 1);
            this.tableCarre.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableCarre.Location = new System.Drawing.Point(231, 349);
            this.tableCarre.Name = "tableCarre";
            this.tableCarre.RowCount = 2;
            this.tableCarre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCarre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCarre.Size = new System.Drawing.Size(803, 240);
            this.tableCarre.TabIndex = 11;
            this.tableCarre.Visible = false;
            // 
            // lblRep4
            // 
            this.lblRep4.AutoSize = true;
            this.lblRep4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep4.Location = new System.Drawing.Point(404, 120);
            this.lblRep4.Name = "lblRep4";
            this.lblRep4.Size = new System.Drawing.Size(68, 31);
            this.lblRep4.TabIndex = 2;
            this.lblRep4.Text = "rep4";
            this.lblRep4.Click += new System.EventHandler(this.lblRep1_Click);
            // 
            // lblRep2
            // 
            this.lblRep2.AutoSize = true;
            this.lblRep2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep2.Location = new System.Drawing.Point(404, 0);
            this.lblRep2.Name = "lblRep2";
            this.lblRep2.Size = new System.Drawing.Size(68, 31);
            this.lblRep2.TabIndex = 2;
            this.lblRep2.Text = "rep2";
            this.lblRep2.Click += new System.EventHandler(this.lblRep1_Click);
            // 
            // lblRep1
            // 
            this.lblRep1.AutoSize = true;
            this.lblRep1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep1.Location = new System.Drawing.Point(3, 0);
            this.lblRep1.Name = "lblRep1";
            this.lblRep1.Size = new System.Drawing.Size(68, 31);
            this.lblRep1.TabIndex = 2;
            this.lblRep1.Text = "rep1";
            this.lblRep1.Click += new System.EventHandler(this.lblRep1_Click);
            // 
            // lblRep3
            // 
            this.lblRep3.AutoSize = true;
            this.lblRep3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep3.Location = new System.Drawing.Point(3, 120);
            this.lblRep3.Name = "lblRep3";
            this.lblRep3.Size = new System.Drawing.Size(68, 31);
            this.lblRep3.TabIndex = 2;
            this.lblRep3.Text = "rep3";
            this.lblRep3.Click += new System.EventHandler(this.lblRep1_Click);
            // 
            // panelRepCash
            // 
            this.panelRepCash.Controls.Add(this.btnCashCorrect);
            this.panelRepCash.Controls.Add(this.lblRepCash);
            this.panelRepCash.Location = new System.Drawing.Point(384, 434);
            this.panelRepCash.Name = "panelRepCash";
            this.panelRepCash.Size = new System.Drawing.Size(512, 183);
            this.panelRepCash.TabIndex = 12;
            this.panelRepCash.Visible = false;
            // 
            // btnCashCorrect
            // 
            this.btnCashCorrect.Location = new System.Drawing.Point(168, 135);
            this.btnCashCorrect.Name = "btnCashCorrect";
            this.btnCashCorrect.Size = new System.Drawing.Size(169, 48);
            this.btnCashCorrect.TabIndex = 3;
            this.btnCashCorrect.Text = "Correct";
            this.btnCashCorrect.UseVisualStyleBackColor = true;
            this.btnCashCorrect.Click += new System.EventHandler(this.btnCashCorrect_Click);
            // 
            // lblRepCash
            // 
            this.lblRepCash.AutoSize = true;
            this.lblRepCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRepCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepCash.Location = new System.Drawing.Point(3, 0);
            this.lblRepCash.Name = "lblRepCash";
            this.lblRepCash.Size = new System.Drawing.Size(155, 31);
            this.lblRepCash.TabIndex = 2;
            this.lblRepCash.Text = "lblRepCash";
            // 
            // lblNumQuestion
            // 
            this.lblNumQuestion.AutoSize = true;
            this.lblNumQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestion.Location = new System.Drawing.Point(1194, 74);
            this.lblNumQuestion.Name = "lblNumQuestion";
            this.lblNumQuestion.Size = new System.Drawing.Size(50, 31);
            this.lblNumQuestion.TabIndex = 2;
            this.lblNumQuestion.Text = "1/x";
            // 
            // CultureGenerale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelRepCash);
            this.Controls.Add(this.tableCarre);
            this.Controls.Add(this.panelChoixReponse);
            this.Controls.Add(this.picBoxRight);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblNumQuestion);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.btnRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CultureGenerale";
            this.Text = " ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CultureGenerale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRight)).EndInit();
            this.panelChoixReponse.ResumeLayout(false);
            this.tableCarre.ResumeLayout(false);
            this.tableCarre.PerformLayout();
            this.panelRepCash.ResumeLayout(false);
            this.panelRepCash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.Button btnRepCarre;
        private System.Windows.Forms.Button btnRepCash;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox picBoxRight;
        private System.Windows.Forms.Panel panelChoixReponse;
        private System.Windows.Forms.Label lblRep2;
        private System.Windows.Forms.Label lblRep3;
        private System.Windows.Forms.Label lblRep4;
        private System.Windows.Forms.Label lblRep1;
        private System.Windows.Forms.TableLayoutPanel tableCarre;
        private System.Windows.Forms.Panel panelRepCash;
        private System.Windows.Forms.Label lblRepCash;
        private System.Windows.Forms.Label lblNumQuestion;
        private System.Windows.Forms.Button btnCashCorrect;
    }
}