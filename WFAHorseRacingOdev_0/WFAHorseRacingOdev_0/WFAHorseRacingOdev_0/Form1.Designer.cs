﻿namespace WFAHorseRacingOdev_0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.pibeyazSaray = new System.Windows.Forms.PictureBox();
            this.pcikolata = new System.Windows.Forms.PictureBox();
            this.pgunes = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnbahis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtatbahis = new System.Windows.Forms.TextBox();
            this.txtbahistutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbakiye = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibeyazSaray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcikolata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgunes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1425, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1425, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1425, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.Location = new System.Drawing.Point(1421, 19);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(34, 332);
            this.lblFinish.TabIndex = 1;
            this.lblFinish.Text = "Finish";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pibeyazSaray
            // 
            this.pibeyazSaray.Image = global::WFAHorseRacingOdev_0.Properties.Resources.at1;
            this.pibeyazSaray.Location = new System.Drawing.Point(3, 192);
            this.pibeyazSaray.Name = "pibeyazSaray";
            this.pibeyazSaray.Size = new System.Drawing.Size(105, 67);
            this.pibeyazSaray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibeyazSaray.TabIndex = 2;
            this.pibeyazSaray.TabStop = false;
            // 
            // pcikolata
            // 
            this.pcikolata.Image = ((System.Drawing.Image)(resources.GetObject("pcikolata.Image")));
            this.pcikolata.Location = new System.Drawing.Point(3, 96);
            this.pcikolata.Name = "pcikolata";
            this.pcikolata.Size = new System.Drawing.Size(105, 67);
            this.pcikolata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcikolata.TabIndex = 2;
            this.pcikolata.TabStop = false;
            // 
            // pgunes
            // 
            this.pgunes.Image = global::WFAHorseRacingOdev_0.Properties.Resources.at3;
            this.pgunes.Location = new System.Drawing.Point(3, 0);
            this.pgunes.Name = "pgunes";
            this.pgunes.Size = new System.Drawing.Size(105, 67);
            this.pgunes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pgunes.TabIndex = 2;
            this.pgunes.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(1351, 380);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(104, 42);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Start";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnbahis
            // 
            this.btnbahis.Location = new System.Drawing.Point(804, 408);
            this.btnbahis.Name = "btnbahis";
            this.btnbahis.Size = new System.Drawing.Size(98, 30);
            this.btnbahis.TabIndex = 4;
            this.btnbahis.Text = "Bahis Yatır";
            this.btnbahis.UseVisualStyleBackColor = true;
            this.btnbahis.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(724, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "At Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(670, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bahis Tutarı:";
            // 
            // txtatbahis
            // 
            this.txtatbahis.Location = new System.Drawing.Point(804, 356);
            this.txtatbahis.Name = "txtatbahis";
            this.txtatbahis.Size = new System.Drawing.Size(100, 20);
            this.txtatbahis.TabIndex = 7;
            // 
            // txtbahistutar
            // 
            this.txtbahistutar.Location = new System.Drawing.Point(804, 382);
            this.txtbahistutar.Name = "txtbahistutar";
            this.txtbahistutar.Size = new System.Drawing.Size(100, 20);
            this.txtbahistutar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-1, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bakiye:";
            // 
            // lblbakiye
            // 
            this.lblbakiye.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblbakiye.Location = new System.Drawing.Point(82, 341);
            this.lblbakiye.Name = "lblbakiye";
            this.lblbakiye.Size = new System.Drawing.Size(100, 23);
            this.lblbakiye.TabIndex = 9;
            this.lblbakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1480, 450);
            this.Controls.Add(this.lblbakiye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbahistutar);
            this.Controls.Add(this.txtatbahis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbahis);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pibeyazSaray);
            this.Controls.Add(this.pcikolata);
            this.Controls.Add(this.pgunes);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibeyazSaray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcikolata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgunes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.PictureBox pgunes;
        private System.Windows.Forms.PictureBox pcikolata;
        private System.Windows.Forms.PictureBox pibeyazSaray;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnbahis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtatbahis;
        private System.Windows.Forms.TextBox txtbahistutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbakiye;
    }
}

