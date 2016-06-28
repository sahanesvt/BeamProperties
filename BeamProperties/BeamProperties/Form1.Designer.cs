using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeamProperties
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
            this.texttft = new System.Windows.Forms.TextBox();
            this.lbltft = new System.Windows.Forms.Label();
            this.lblbft = new System.Windows.Forms.Label();
            this.textbft = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.textD = new System.Windows.Forms.TextBox();
            this.lbltw = new System.Windows.Forms.Label();
            this.texttw = new System.Windows.Forms.TextBox();
            this.lbltfb = new System.Windows.Forms.Label();
            this.texttfb = new System.Windows.Forms.TextBox();
            this.lblbfb = new System.Windows.Forms.Label();
            this.textbfb = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.lblNA = new System.Windows.Forms.Label();
            this.txtNA = new System.Windows.Forms.TextBox();
            this.lblI = new System.Windows.Forms.Label();
            this.txtI = new System.Windows.Forms.TextBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.lblSbot = new System.Windows.Forms.Label();
            this.txtSbot = new System.Windows.Forms.TextBox();
            this.lblPNA = new System.Windows.Forms.Label();
            this.txtPNA = new System.Windows.Forms.TextBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // texttft
            // 
            this.texttft.AcceptsTab = true;
            this.texttft.Location = new System.Drawing.Point(86, 51);
            this.texttft.Name = "texttft";
            this.texttft.Size = new System.Drawing.Size(71, 20);
            this.texttft.TabIndex = 1;
            // 
            // lbltft
            // 
            this.lbltft.AutoSize = true;
            this.lbltft.Location = new System.Drawing.Point(37, 54);
            this.lbltft.Name = "lbltft";
            this.lbltft.Size = new System.Drawing.Size(43, 14);
            this.lbltft.TabIndex = 1;
            this.lbltft.Text = "tft, in =";
            // 
            // lblbft
            // 
            this.lblbft.AutoSize = true;
            this.lblbft.Location = new System.Drawing.Point(37, 28);
            this.lblbft.Name = "lblbft";
            this.lblbft.Size = new System.Drawing.Size(44, 14);
            this.lblbft.TabIndex = 3;
            this.lblbft.Text = "bft, in =";
            // 
            // textbft
            // 
            this.textbft.AcceptsTab = true;
            this.textbft.Location = new System.Drawing.Point(86, 25);
            this.textbft.Name = "textbft";
            this.textbft.Size = new System.Drawing.Size(71, 20);
            this.textbft.TabIndex = 0;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(37, 80);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(39, 14);
            this.lblD.TabIndex = 5;
            this.lblD.Text = "D, in =";
            // 
            // textD
            // 
            this.textD.AcceptsTab = true;
            this.textD.Location = new System.Drawing.Point(86, 77);
            this.textD.Name = "textD";
            this.textD.Size = new System.Drawing.Size(71, 20);
            this.textD.TabIndex = 2;
            // 
            // lbltw
            // 
            this.lbltw.AutoSize = true;
            this.lbltw.Location = new System.Drawing.Point(37, 106);
            this.lbltw.Name = "lbltw";
            this.lbltw.Size = new System.Drawing.Size(42, 14);
            this.lbltw.TabIndex = 7;
            this.lbltw.Text = "tw, in =";
            // 
            // texttw
            // 
            this.texttw.AcceptsTab = true;
            this.texttw.Location = new System.Drawing.Point(86, 103);
            this.texttw.Name = "texttw";
            this.texttw.Size = new System.Drawing.Size(71, 20);
            this.texttw.TabIndex = 3;
            // 
            // lbltfb
            // 
            this.lbltfb.AutoSize = true;
            this.lbltfb.Location = new System.Drawing.Point(37, 158);
            this.lbltfb.Name = "lbltfb";
            this.lbltfb.Size = new System.Drawing.Size(44, 14);
            this.lbltfb.TabIndex = 9;
            this.lbltfb.Text = "tfb, in =";
            // 
            // texttfb
            // 
            this.texttfb.AcceptsTab = true;
            this.texttfb.Location = new System.Drawing.Point(86, 155);
            this.texttfb.Name = "texttfb";
            this.texttfb.Size = new System.Drawing.Size(71, 20);
            this.texttfb.TabIndex = 5;
            // 
            // lblbfb
            // 
            this.lblbfb.AutoSize = true;
            this.lblbfb.Location = new System.Drawing.Point(37, 132);
            this.lblbfb.Name = "lblbfb";
            this.lblbfb.Size = new System.Drawing.Size(45, 14);
            this.lblbfb.TabIndex = 11;
            this.lblbfb.Text = "bfb, in =";
            // 
            // textbfb
            // 
            this.textbfb.AcceptsTab = true;
            this.textbfb.Location = new System.Drawing.Point(86, 129);
            this.textbfb.Name = "textbfb";
            this.textbfb.Size = new System.Drawing.Size(71, 20);
            this.textbfb.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(227, 28);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(62, 14);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Area, in    =";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(297, 25);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(71, 20);
            this.txtArea.TabIndex = 7;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(35, 279);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // lblNA
            // 
            this.lblNA.AutoSize = true;
            this.lblNA.Location = new System.Drawing.Point(227, 54);
            this.lblNA.Name = "lblNA";
            this.lblNA.Size = new System.Drawing.Size(47, 14);
            this.lblNA.TabIndex = 16;
            this.lblNA.Text = "NA, in =";
            // 
            // txtNA
            // 
            this.txtNA.Location = new System.Drawing.Point(297, 51);
            this.txtNA.Name = "txtNA";
            this.txtNA.ReadOnly = true;
            this.txtNA.Size = new System.Drawing.Size(71, 20);
            this.txtNA.TabIndex = 8;
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(227, 80);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(41, 14);
            this.lblI.TabIndex = 18;
            this.lblI.Text = "I, in   =";
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(297, 77);
            this.txtI.Name = "txtI";
            this.txtI.ReadOnly = true;
            this.txtI.Size = new System.Drawing.Size(71, 20);
            this.txtI.TabIndex = 9;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(227, 106);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(58, 14);
            this.lblStop.TabIndex = 20;
            this.lblStop.Text = "Stop, in   =";
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(297, 103);
            this.txtStop.Name = "txtStop";
            this.txtStop.ReadOnly = true;
            this.txtStop.Size = new System.Drawing.Size(71, 20);
            this.txtStop.TabIndex = 10;
            // 
            // lblSbot
            // 
            this.lblSbot.AutoSize = true;
            this.lblSbot.Location = new System.Drawing.Point(227, 132);
            this.lblSbot.Name = "lblSbot";
            this.lblSbot.Size = new System.Drawing.Size(57, 14);
            this.lblSbot.TabIndex = 22;
            this.lblSbot.Text = "Sbot, in   =";
            // 
            // txtSbot
            // 
            this.txtSbot.Location = new System.Drawing.Point(297, 129);
            this.txtSbot.Name = "txtSbot";
            this.txtSbot.ReadOnly = true;
            this.txtSbot.Size = new System.Drawing.Size(71, 20);
            this.txtSbot.TabIndex = 11;
            // 
            // lblPNA
            // 
            this.lblPNA.AutoSize = true;
            this.lblPNA.Location = new System.Drawing.Point(227, 158);
            this.lblPNA.Name = "lblPNA";
            this.lblPNA.Size = new System.Drawing.Size(54, 14);
            this.lblPNA.TabIndex = 24;
            this.lblPNA.Text = "PNA, in =";
            // 
            // txtPNA
            // 
            this.txtPNA.Location = new System.Drawing.Point(297, 155);
            this.txtPNA.Name = "txtPNA";
            this.txtPNA.ReadOnly = true;
            this.txtPNA.Size = new System.Drawing.Size(71, 20);
            this.txtPNA.TabIndex = 12;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(227, 184);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(44, 14);
            this.lblZ.TabIndex = 26;
            this.lblZ.Text = "Z, in   =";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(297, 181);
            this.txtZ.Name = "txtZ";
            this.txtZ.ReadOnly = true;
            this.txtZ.Size = new System.Drawing.Size(71, 20);
            this.txtZ.TabIndex = 13;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(268, 279);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 10);
            this.label1.TabIndex = 28;
            this.label1.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 10);
            this.label2.TabIndex = 29;
            this.label2.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 10);
            this.label3.TabIndex = 30;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 10);
            this.label4.TabIndex = 31;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 10);
            this.label5.TabIndex = 32;
            this.label5.Text = "3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "pictureBox1";
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(399, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 256);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.lblPNA);
            this.Controls.Add(this.txtPNA);
            this.Controls.Add(this.lblSbot);
            this.Controls.Add(this.txtSbot);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.txtStop);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.lblNA);
            this.Controls.Add(this.txtNA);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblbfb);
            this.Controls.Add(this.textbfb);
            this.Controls.Add(this.lbltfb);
            this.Controls.Add(this.texttfb);
            this.Controls.Add(this.lbltw);
            this.Controls.Add(this.texttw);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.textD);
            this.Controls.Add(this.lblbft);
            this.Controls.Add(this.textbft);
            this.Controls.Add(this.lbltft);
            this.Controls.Add(this.texttft);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "BeamProperties";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texttft;
        private System.Windows.Forms.Label lbltft;
        private System.Windows.Forms.Label lblbft;
        private System.Windows.Forms.TextBox textbft;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.Label lbltw;
        private System.Windows.Forms.TextBox texttw;
        private System.Windows.Forms.Label lbltfb;
        private System.Windows.Forms.TextBox texttfb;
        private System.Windows.Forms.Label lblbfb;
        private System.Windows.Forms.TextBox textbfb;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label lblNA;
        private System.Windows.Forms.TextBox txtNA;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.Label lblSbot;
        private System.Windows.Forms.TextBox txtSbot;
        private System.Windows.Forms.Label lblPNA;
        private System.Windows.Forms.TextBox txtPNA;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public PictureBox pictureBox1;
    }
    public class NCProperties
    {
        // beam dimension variables
        public static double bft, tft, D, tw, bfb, tfb;
        // beam property variables
        public static double Atf, Aweb, Abf, Ytf, Yweb, Ybf, Itf, Iweb, Ibf, area, I, CG, NA, Stop, Sbot, PNA, PCGtop, PCGbot, Z;
        // beam property calculations
        public static double PartArea(double width, double height)
        {
            area = width * height;
            return area;
        }
        public static double PartCG(double first, double second, double last)
        {
            CG = first + second + last / 2;
            return CG;
        }
        public static double BeamArea(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            Atf = NCProperties.PartArea(bft, tft);
            Aweb = NCProperties.PartArea(D, tw);
            Abf = NCProperties.PartArea(bfb, tfb);
            area = Atf + Aweb + Abf;
            return area;
        }
        public static double NeutralAxis(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            Atf = NCProperties.PartArea(bft, tft);
            Aweb = NCProperties.PartArea(D, tw);
            Abf = NCProperties.PartArea(bfb, tfb);
            Ytf = NCProperties.PartCG(tfb, D, tft);
            Yweb = NCProperties.PartCG(tfb, 0, D);
            Ybf = NCProperties.PartCG(0, 0, tfb);
            NA = (Atf * Ytf + Aweb * Yweb + Abf * Ybf) / (Atf + Aweb + Abf);
            return NA;
        }
        public static double PartMomOfInert(double width, double height)
        {
            I = width * Math.Pow(height, 3) / 12;
            return I;
        }
        public static double MomentOfIneria(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            Atf = NCProperties.PartArea(bft, tft);
            Aweb = NCProperties.PartArea(D, tw);
            Abf = NCProperties.PartArea(bfb, tfb);
            Ytf = NCProperties.PartCG(tfb, D, tft);
            Yweb = NCProperties.PartCG(tfb, 0, D);
            Ybf = NCProperties.PartCG(0, 0, tfb);
            NA = NCProperties.NeutralAxis(bft, tft, D, tw, bfb, tfb);
            Itf = NCProperties.PartMomOfInert(bft, tft);
            Iweb = NCProperties.PartMomOfInert(tw, D);
            Ibf = NCProperties.PartMomOfInert(bfb, tfb);
            I = Itf + Atf * Math.Pow(Ytf - NA, 2) + Iweb + Aweb * Math.Pow(Yweb - NA, 2) + Ibf + Abf * Math.Pow(Ybf - NA, 2);
            return I;
        }
        public static double ElastSectModTop(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            Ytf = NCProperties.PartCG(tfb, D, tft);
            NA = NCProperties.NeutralAxis(bft, tft, D, tw, bfb, tfb);
            I = NCProperties.MomentOfIneria(bft, tft, D, tw, bfb, tfb);
            Stop = I / (Ytf - NA + tft / 2);
            return Stop;
        }
        public static double ElastSectModBot(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            Ybf = NCProperties.PartCG(0, 0, tfb);
            NA = NCProperties.NeutralAxis(bft, tft, D, tw, bfb, tfb);
            I = NCProperties.MomentOfIneria(bft, tft, D, tw, bfb, tfb);
            Sbot = I / (NA - Ybf + tfb / 2);
            return Sbot;
        }
        public static double PlastNeutralAxis(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            PNA = tfb + (D + (bft * tft - bfb * tfb) / tw) / 2;
            return PNA;
        }
        public static double PNAtoTopCG(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            area = NCProperties.BeamArea(bft, tft, D, tw, bfb, tfb);
            PNA = NCProperties.PlastNeutralAxis(bft, tft, D, tw, bfb, tfb);
            PCGtop = (bft * tft * (tft / 2 + D + tfb - PNA) + tw * Math.Pow(D - PNA + tfb, 2) / 2) * 2 / area;
            return PCGtop;
        }
        public static double PNAtoBotCG(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            area = NCProperties.BeamArea(bft, tft, D, tw, bfb, tfb);
            PNA = NCProperties.PlastNeutralAxis(bft, tft, D, tw, bfb, tfb);
            PCGbot = (bfb * tfb * (PNA - tfb / 2) + tw * Math.Pow(PNA - tfb, 2) / 2) * 2 / area;
            return PCGbot;
        }
        public static double PlastSectMod(double bft, double tft, double D, double tw, double bfb, double tfb)
        {
            area = NCProperties.BeamArea(bft, tft, D, tw, bfb, tfb);
            PNA = NCProperties.PlastNeutralAxis(bft, tft, D, tw, bfb, tfb);
            PCGtop = NCProperties.PNAtoTopCG(bft, tft, D, tw, bfb, tfb);
            PCGbot = NCProperties.PNAtoBotCG(bft, tft, D, tw, bfb, tfb);
            Z = area / 2 * (PCGtop + PCGbot);
            return Z;
        }
    }

    public class Plot
    {
                public static float Height, Width, x,y,xt1, xt2, xw1, xw2, xb1, xb2, yt1, yt2, yb1, yb2;
                public static Bitmap PlotBeam(double bft, double tft, double D, double tw, double bfb, double tfb)
                 {
                        x = 310/2;
                        y = 256 / 2;
                        double scale = 256/(D+tft+tfb+50)*1.25;
                        xt1 = x - Convert.ToInt32(bft*scale / 2);
                        xt2 = xt1 + Convert.ToInt32(bft * scale);
                        yt1 = y - Convert.ToInt32(D * scale / 2);
                        yt2 = yt1 - Convert.ToInt32(tft * scale);
                        xw1 = x - Convert.ToInt32(tw * scale / 2);
                        xw2 = xw1 + Convert.ToInt32(tw * scale);
                        //yw1 = y + Convert.ToInt32(D * scale / 2);
                        //yw2 = yw1 - Convert.ToInt32(D * scale);
                        xb1 = x - Convert.ToInt32(bfb * scale / 2);
                        xb2 = xb1 + Convert.ToInt32(bfb * scale);
                        yb1 = y + Convert.ToInt32(D * scale / 2);
                        yb2 = yb1 + Convert.ToInt32(tfb * scale);
                        Height = Convert.ToInt32((tft + D + tfb) + 30);
                        Width = Convert.ToInt32(Math.Max(bft, bfb) + 30);
                        Bitmap bmp = new Bitmap(1000, 500);
                        Graphics g = Graphics.FromImage(bmp);
                        StringFormat justifyleft = new StringFormat();
                        justifyleft.Alignment = StringAlignment.Far;
                        StringFormat justifyright = new StringFormat();
                        justifyright.Alignment = StringAlignment.Near;
                        StringFormat justifycenter = new StringFormat();
                        justifycenter.Alignment = StringAlignment.Center;
                        // plot top flange
                        g.DrawLine(new Pen(Color.Black, 1), xt1, yt1, xt1, yt2);
                        g.DrawLine(new Pen(Color.Black, 1), xt1, yt2, xt2, yt2);
                        g.DrawLine(new Pen(Color.Black, 1), xt2, yt2, xt2, yt1);
                        g.DrawLine(new Pen(Color.Black, 1), xt2, yt1, xt1, yt1);
                        // plot bottom flange
                        g.DrawLine(new Pen(Color.Black, 1), xb1, yb1, xb1, yb2);
                        g.DrawLine(new Pen(Color.Black, 1), xb1, yb2, xb2, yb2);
                        g.DrawLine(new Pen(Color.Black, 1), xb2, yb2, xb2, yb1);
                        g.DrawLine(new Pen(Color.Black, 1), xb2, yb1, xb1, yb1);
                        // plot web    
                        g.DrawLine(new Pen(Color.Black, 1), xw1, yb1, xw1, yt1);
                        g.DrawLine(new Pen(Color.Black, 1), xw1, yt1, xw2, yt1);
                        g.DrawLine(new Pen(Color.Black, 1), xw2, yt1, xw2, yb1);
                        g.DrawLine(new Pen(Color.Black, 1), xw2, yb1, xw1, yb1);                
                        // plot top flange width dim lines
                        g.DrawLine(new Pen(Color.Red, 1), xt1, yt2 - 5, xt1, yt2 - 15);
                        g.DrawLine(new Pen(Color.Red, 1), xt2, yt2 - 5, xt2, yt2 - 15);
                        g.DrawLine(new Pen(Color.Red, 1), xt1, yt2 - 10, xt2, yt2 - 10);
                        g.DrawLine(new Pen(Color.Red, 1), xt1, yt2 - 10, xt1 + 5, yt2 - 7);
                        g.DrawLine(new Pen(Color.Red, 1), xt1, yt2 - 10, xt1 + 5, yt2 - 13);
                        g.DrawLine(new Pen(Color.Red, 1), xt2, yt2 - 10, xt2 - 5, yt2 - 7);
                        g.DrawLine(new Pen(Color.Red, 1), xt2, yt2 - 10, xt2 - 5, yt2 - 13);
                        g.DrawString(Convert.ToString(bft) + "in", new Font("Calibri", 8), new SolidBrush(Color.Black), x - 0, yt2 - 22, justifycenter);
                        // plot top flange thickness dim lines
                        g.DrawLine(new Pen(Color.Red, 1),xt1-5,yt1,xt1-15,yt1);
                        g.DrawLine(new Pen(Color.Red, 1), xt1 - 5, yt2, xt1 - 15, yt2);
                        g.DrawLine(new Pen(Color.Red, 1), xt1 - 10, yt2, xt1 - 10, yt2-10);
                        g.DrawLine(new Pen(Color.Red, 1), xt1 - 10, yt2, xt1 - 13, yt2-7);
                        g.DrawLine(new Pen(Color.Red, 1), xt1 - 10, yt2, xt1 - 7, yt2 - 7);
                        g.DrawLine(new Pen(Color.Red, 1), xt1 - 10, yt1, xt1 - 10, yt1 + 15);
                        g.DrawLine(new Pen(Color.Red, 1), xt1 - 10, yt1, xt1 - 13, yt1 + 7);
                        g.DrawLine(new Pen(Color.Red, 1), xt1 - 10, yt1, xt1 - 7, yt1 + 7);
                        g.DrawLine(new Pen(Color.Red, 1), xt1 - 10, yt1+15, xt1 - 20, yt1 + 15);
                        g.DrawString(Convert.ToString(tft) + "in", new Font("Calibri", 8), new SolidBrush(Color.Black), xt1 - 20, yt1 + 8, justifyleft);
                        // plot bottom flange width dim lines
                        g.DrawLine(new Pen(Color.Red, 1), xb1, yb2 + 5, xb1, yb2 + 15);
                        g.DrawLine(new Pen(Color.Red, 1), xb2, yb2 + 5, xb2, yb2 + 15);
                        g.DrawLine(new Pen(Color.Red, 1), xb1, yb2 + 10, xb2, yb2 + 10);
                        g.DrawLine(new Pen(Color.Red, 1), xb1, yb2 + 10, xb1 + 5, yb2 + 7);
                        g.DrawLine(new Pen(Color.Red, 1), xb1, yb2 + 10, xb1 + 5, yb2 + 13);
                        g.DrawLine(new Pen(Color.Red, 1), xb2, yb2 + 10, xb2 - 5, yb2 + 7);
                        g.DrawLine(new Pen(Color.Red, 1), xb2, yb2 + 10, xb2 - 5, yb2 + 13);
                        g.DrawString(Convert.ToString(bfb) + "in", new Font("Calibri", 8), new SolidBrush(Color.Black), x - 0, yb2 + 10, justifycenter);
                        // plot bot flange thickness dim lines
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 5, yb1, xb1 - 15, yb1);
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 5, yb2, xb1 - 15, yb2);
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 10, yb2, xb1 - 10, yb2 + 10);
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 10, yb2, xb1 - 13, yb2 + 7);
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 10, yb2, xb1 - 7, yb2 + 7);
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 10, yb1, xb1 - 10, yb1 - 15);
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 10, yb1, xb1 - 13, yb1 - 7);
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 10, yb1, xb1 - 7, yb1 - 7);
                        g.DrawLine(new Pen(Color.Red, 1), xb1 - 10, yb1 - 15, xb1 - 20, yb1 - 15);
                        g.DrawString(Convert.ToString(tfb) + "in", new Font("Calibri", 8), new SolidBrush(Color.Black), xb1 - 20, yb1 - 22, justifyleft);
                        // plot web depth dim lines
                        g.DrawLine(new Pen(Color.Red, 1), xb2 + 5, yb1, Math.Max(xb2, xt2) + 15, yb1);
                        g.DrawLine(new Pen(Color.Red, 1), xt2+5, yt1, Math.Max(xb2, xt2) + 15, yt1);
                        g.DrawLine(new Pen(Color.Red, 1), Math.Max(xb2, xt2) + 10, yt1, Math.Max(xb2, xt2) + 10, yb1);
                        g.DrawLine(new Pen(Color.Red, 1), Math.Max(xb2, xt2) + 10, yt1, Math.Max(xb2, xt2)+7, yt1 + 7);
                        g.DrawLine(new Pen(Color.Red, 1), Math.Max(xb2, xt2) + 10, yt1, Math.Max(xb2, xt2) + 13, yt1 + 7);
                        g.DrawLine(new Pen(Color.Red, 1), Math.Max(xb2, xt2) + 10, yb1, Math.Max(xb2, xt2) + 7, yb1 - 7);
                        g.DrawLine(new Pen(Color.Red, 1), Math.Max(xb2, xt2) + 10, yb1, Math.Max(xb2, xt2) + 13, yb1 - 7);
                        g.DrawString(Convert.ToString(D) + "in", new Font("Calibri", 8), new SolidBrush(Color.Black), Math.Max(xb2, xt2) +15, y-7,justifyright);
                        // plot web width dim lines
                        g.DrawLine(new Pen(Color.Red, 1), xw2 , y, xw2+10,y);
                        g.DrawLine(new Pen(Color.Red, 1), xw2, y, xw2 + 7, y+3);
                        g.DrawLine(new Pen(Color.Red, 1), xw2, y, xw2 + 7, y - 3);
                        g.DrawLine(new Pen(Color.Red, 1), xw1, y, xw1 - 15, y);
                        g.DrawLine(new Pen(Color.Red, 1), xw1, y, xw1 - 7, y + 3);
                        g.DrawLine(new Pen(Color.Red, 1), xw1, y, xw1 - 7, y - 3);
                        g.DrawString(Convert.ToString(tw) + "in", new Font("Calibri", 8), new SolidBrush(Color.Black), xw1 - 15, y - 7, justifyleft);
                        return bmp;
                 }
    }
}

