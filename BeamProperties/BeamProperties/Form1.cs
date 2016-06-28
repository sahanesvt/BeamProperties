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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // beam dimension variables
        double bft, tft, D, tw, bfb, tfb;
        private void Calculate_Click(object sender, EventArgs e)
        {
            Double val;
            if (Double.TryParse(textbft.Text, out val) && Double.TryParse(texttft.Text, out val) && Double.TryParse(textD.Text, out val) && Double.TryParse(texttw.Text, out val) && Double.TryParse(textbfb.Text, out val) && Double.TryParse(texttfb.Text, out val))
            {

                //define input values ||
                bft = Convert.ToDouble(textbft.Text);
                tft = Convert.ToDouble(texttft.Text);
                D = Convert.ToDouble(textD.Text);
                tw = Convert.ToDouble(texttw.Text);
                bfb = Convert.ToDouble(textbfb.Text);
                tfb = Convert.ToDouble(texttfb.Text);

                Bitmap bmp = Plot.PlotBeam(bft , tft , D , tw , bfb , tfb );
                pictureBox1.Image = bmp;



                double Area = NCProperties.BeamArea(bft, tft, D, tw, bfb, tfb);
                double NA = NCProperties.NeutralAxis(bft, tft, D, tw, bfb, tfb);
                double I = NCProperties.MomentOfIneria(bft, tft, D, tw, bfb, tfb);
                double Stop = NCProperties.ElastSectModTop(bft, tft, D, tw, bfb, tfb);
                double Sbot = NCProperties.ElastSectModBot(bft, tft, D, tw, bfb, tfb);
                double PNA = NCProperties.PlastNeutralAxis(bft, tft, D, tw, bfb, tfb);
                double Z = NCProperties.PlastSectMod(bft, tft, D, tw, bfb, tfb);

                txtArea.Text = Convert.ToString(Math.Round(Area, 2));
                txtNA.Text = Convert.ToString(Math.Round(NA, 2));
                txtI.Text = Convert.ToString(Math.Round(I, 2));
                txtStop.Text = Convert.ToString(Math.Round(Stop, 2));
                txtSbot.Text = Convert.ToString(Math.Round(Sbot, 2));
                txtPNA.Text = Convert.ToString(Math.Round(PNA, 2));
                txtZ.Text = Convert.ToString(Math.Round(Z, 2));
            }
                else{
                MessageBox.Show("Invalid Input!");

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // exit the program
            Application.Exit(); 
        }

    }
}
