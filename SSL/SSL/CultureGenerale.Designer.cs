
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
            this.btnRepDuo = new System.Windows.Forms.Button();
            this.btnRepCarre = new System.Windows.Forms.Button();
            this.btnRepCash = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.picBoxLeft = new System.Windows.Forms.PictureBox();
            this.picBoxRight = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRep1 = new System.Windows.Forms.Label();
            this.lblRep2 = new System.Windows.Forms.Label();
            this.lblRep3 = new System.Windows.Forms.Label();
            this.lblRep4 = new System.Windows.Forms.Label();
            this.tblCarre = new System.Windows.Forms.TableLayoutPanel();
            this.tblDuo = new System.Windows.Forms.TableLayoutPanel();
            this.lblDuo2 = new System.Windows.Forms.Label();
            this.lblDuo1 = new System.Windows.Forms.Label();
            this.lblJason = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRight)).BeginInit();
            this.tblCarre.SuspendLayout();
            this.tblDuo.SuspendLayout();
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
            this.lblJoueur.Location = new System.Drawing.Point(545, 188);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(190, 31);
            this.lblJoueur.TabIndex = 2;
            this.lblJoueur.Text = "Nom du joueur";
            // 
            // btnRepDuo
            // 
            this.btnRepDuo.Location = new System.Drawing.Point(24, 440);
            this.btnRepDuo.Name = "btnRepDuo";
            this.btnRepDuo.Size = new System.Drawing.Size(168, 66);
            this.btnRepDuo.TabIndex = 3;
            this.btnRepDuo.Text = "Duo";
            this.btnRepDuo.UseVisualStyleBackColor = true;
            this.btnRepDuo.Visible = false;
            this.btnRepDuo.Click += new System.EventHandler(this.btnRepDuo_Click);
            // 
            // btnRepCarre
            // 
            this.btnRepCarre.Location = new System.Drawing.Point(551, 402);
            this.btnRepCarre.Name = "btnRepCarre";
            this.btnRepCarre.Size = new System.Drawing.Size(168, 66);
            this.btnRepCarre.TabIndex = 3;
            this.btnRepCarre.Text = "Carré";
            this.btnRepCarre.UseVisualStyleBackColor = true;
            this.btnRepCarre.Click += new System.EventHandler(this.btnRepCarre_Click);
            // 
            // btnRepCash
            // 
            this.btnRepCash.Location = new System.Drawing.Point(887, 402);
            this.btnRepCash.Name = "btnRepCash";
            this.btnRepCash.Size = new System.Drawing.Size(168, 66);
            this.btnRepCash.TabIndex = 3;
            this.btnRepCash.Text = "Cash";
            this.btnRepCash.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(229, 275);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(123, 31);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question";
            // 
            // picBoxLeft
            // 
            this.picBoxLeft.Image = global::SSL.Properties.Resources.left_arrow;
            this.picBoxLeft.Location = new System.Drawing.Point(24, 85);
            this.picBoxLeft.Name = "picBoxLeft";
            this.picBoxLeft.Size = new System.Drawing.Size(100, 50);
            this.picBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLeft.TabIndex = 5;
            this.picBoxLeft.TabStop = false;
            // 
            // picBoxRight
            // 
            this.picBoxRight.Image = global::SSL.Properties.Resources.right_arrow;
            this.picBoxRight.Location = new System.Drawing.Point(1131, 85);
            this.picBoxRight.Name = "picBoxRight";
            this.picBoxRight.Size = new System.Drawing.Size(100, 50);
            this.picBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxRight.TabIndex = 5;
            this.picBoxRight.TabStop = false;
            this.picBoxRight.Click += new System.EventHandler(this.picBoxRight_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(551, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(168, 66);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRep1
            // 
            this.lblRep1.AutoSize = true;
            this.lblRep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep1.Location = new System.Drawing.Point(3, 0);
            this.lblRep1.Name = "lblRep1";
            this.lblRep1.Size = new System.Drawing.Size(29, 31);
            this.lblRep1.TabIndex = 2;
            this.lblRep1.Text = "1";
            // 
            // lblRep2
            // 
            this.lblRep2.AutoSize = true;
            this.lblRep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep2.Location = new System.Drawing.Point(3, 89);
            this.lblRep2.Name = "lblRep2";
            this.lblRep2.Size = new System.Drawing.Size(29, 31);
            this.lblRep2.TabIndex = 2;
            this.lblRep2.Text = "2";
            // 
            // lblRep3
            // 
            this.lblRep3.AutoSize = true;
            this.lblRep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep3.Location = new System.Drawing.Point(171, 0);
            this.lblRep3.Name = "lblRep3";
            this.lblRep3.Size = new System.Drawing.Size(29, 31);
            this.lblRep3.TabIndex = 2;
            this.lblRep3.Text = "3";
            // 
            // lblRep4
            // 
            this.lblRep4.AutoSize = true;
            this.lblRep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep4.Location = new System.Drawing.Point(171, 89);
            this.lblRep4.Name = "lblRep4";
            this.lblRep4.Size = new System.Drawing.Size(29, 31);
            this.lblRep4.TabIndex = 2;
            this.lblRep4.Text = "4";
            // 
            // tblCarre
            // 
            this.tblCarre.ColumnCount = 2;
            this.tblCarre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCarre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCarre.Controls.Add(this.lblRep1, 0, 0);
            this.tblCarre.Controls.Add(this.lblRep2, 0, 1);
            this.tblCarre.Controls.Add(this.lblRep3, 1, 0);
            this.tblCarre.Controls.Add(this.lblRep4, 1, 1);
            this.tblCarre.Location = new System.Drawing.Point(521, 484);
            this.tblCarre.Name = "tblCarre";
            this.tblCarre.RowCount = 2;
            this.tblCarre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCarre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCarre.Size = new System.Drawing.Size(336, 179);
            this.tblCarre.TabIndex = 6;
            this.tblCarre.Visible = false;
            // 
            // tblDuo
            // 
            this.tblDuo.ColumnCount = 1;
            this.tblDuo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDuo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDuo.Controls.Add(this.lblDuo2, 0, 1);
            this.tblDuo.Controls.Add(this.lblDuo1, 0, 0);
            this.tblDuo.Location = new System.Drawing.Point(24, 512);
            this.tblDuo.Name = "tblDuo";
            this.tblDuo.RowCount = 2;
            this.tblDuo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDuo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDuo.Size = new System.Drawing.Size(336, 179);
            this.tblDuo.TabIndex = 6;
            this.tblDuo.Visible = false;
            // 
            // lblDuo2
            // 
            this.lblDuo2.AutoSize = true;
            this.lblDuo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuo2.Location = new System.Drawing.Point(3, 89);
            this.lblDuo2.Name = "lblDuo2";
            this.lblDuo2.Size = new System.Drawing.Size(29, 31);
            this.lblDuo2.TabIndex = 4;
            this.lblDuo2.Text = "2";
            // 
            // lblDuo1
            // 
            this.lblDuo1.AutoSize = true;
            this.lblDuo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuo1.Location = new System.Drawing.Point(3, 0);
            this.lblDuo1.Name = "lblDuo1";
            this.lblDuo1.Size = new System.Drawing.Size(29, 31);
            this.lblDuo1.TabIndex = 3;
            this.lblDuo1.Text = "1";
            // 
            // lblJason
            // 
            this.lblJason.AutoSize = true;
            this.lblJason.Location = new System.Drawing.Point(41, 331);
            this.lblJason.Name = "lblJason";
            this.lblJason.Size = new System.Drawing.Size(42, 13);
            this.lblJason.TabIndex = 7;
            this.lblJason.Text = "JASON";
            // 
            // CultureGenerale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblJason);
            this.Controls.Add(this.tblCarre);
            this.Controls.Add(this.picBoxLeft);
            this.Controls.Add(this.picBoxRight);
            this.Controls.Add(this.btnRepCash);
            this.Controls.Add(this.btnRepCarre);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.tblDuo);
            this.Controls.Add(this.btnRepDuo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CultureGenerale";
            this.Text = " ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CultureGenerale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRight)).EndInit();
            this.tblCarre.ResumeLayout(false);
            this.tblCarre.PerformLayout();
            this.tblDuo.ResumeLayout(false);
            this.tblDuo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.Button btnRepDuo;
        private System.Windows.Forms.Button btnRepCarre;
        private System.Windows.Forms.Button btnRepCash;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox picBoxRight;
        private System.Windows.Forms.PictureBox picBoxLeft;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRep1;
        private System.Windows.Forms.Label lblRep2;
        private System.Windows.Forms.Label lblRep3;
        private System.Windows.Forms.Label lblRep4;
        private System.Windows.Forms.TableLayoutPanel tblCarre;
        private System.Windows.Forms.TableLayoutPanel tblDuo;
        private System.Windows.Forms.Label lblDuo2;
        private System.Windows.Forms.Label lblDuo1;
        private System.Windows.Forms.Label lblJason;
    }
}