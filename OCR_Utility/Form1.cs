using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR_Utility
{
    public partial class Form1 : Form
    {
        public int[] F_Vertical_Proj;
        public int[] F_Horizontal_Proj;

        public int[] Ch_Vertical_Proj;
        public int[] Ch_Horizontal_Proj;

        public Bitmap F_Letter;
        public Bitmap Ch_Letter;
        public Form1()
        {
            InitializeComponent();
            F_Vertical_Proj = new int[pictureBox1.Width];
            F_Horizontal_Proj = new int[pictureBox1.Height];
            Ch_Vertical_Proj = new int[pictureBox1.Width];
            Ch_Horizontal_Proj = new int[pictureBox1.Height];
        }
        private void GKB_button_Click(object sender, EventArgs e)
        {
            F_Letter = new Bitmap(pictureBox1.Image);

            //Convert to Grayscale and make the projection
            for (int i = 0; i < F_Letter.Width; i++)//Cols => Width
            {
                F_Vertical_Proj[i] = 0;
                for (int j = 0; j < F_Letter.Height; j++) //Rows => Height
                {
                    Color tmp = F_Letter.GetPixel(i, j);
                    int Gray_Px = (tmp.R + tmp.G + tmp.B) / 3;

                    if (Gray_Px < 128) F_Vertical_Proj[i]++;
                }
            }

            //Alignment
            int pivot = 0;
            for (int i = 0; i < F_Vertical_Proj.Length; i++)
            {
                if (F_Vertical_Proj[i] != 0)
                {
                    pivot = i;
                    break;
                }
            }

            for (int i = 0; i < F_Vertical_Proj.Length - pivot; i++)
            {
                F_Vertical_Proj[i] = F_Vertical_Proj[pivot + i];
            }

            for (int i = F_Vertical_Proj.Length - pivot; i < F_Vertical_Proj.Length; i++)
                F_Vertical_Proj[i] = 0;

            //Display
            FH_ProjBox.Text = "";
            string S = "";
            for (int i = 0; i < F_Vertical_Proj.Length; i++)
            {
                S += F_Vertical_Proj[i].ToString() + " ";
            }
            FH_ProjBox.Text = S;

            //Convert to Grayscale and make the projection horizontal
            for (int j = 0; j < F_Letter.Height; j++)//Cols => Width
            {
                F_Horizontal_Proj[j] = 0;
                for (int i = 0; i < F_Letter.Width; i++) //Rows => Height
                {
                    Color tmp = F_Letter.GetPixel(i, j);
                    int Gray_Px = (tmp.R + tmp.G + tmp.B) / 3;

                    if (Gray_Px < 128) F_Horizontal_Proj[j]++;
                }
            }
            //start
            //alignment
            int pivot2 = 0;
            for (int i = 0; i < F_Horizontal_Proj.Length; i++)
            {
                if (F_Horizontal_Proj[i] != 0)
                {
                    pivot2 = i;
                    break;
                }
            }

            for (int i = 0; i < F_Horizontal_Proj.Length - pivot2; i++)
            {
                F_Horizontal_Proj[i] = F_Horizontal_Proj[pivot2 + i];
            }

            for (int i = F_Horizontal_Proj.Length - pivot2; i < F_Horizontal_Proj.Length; i++)
                F_Horizontal_Proj[i] = 0;

            //Display
            FV_ProjBox.Text = "";
            string Sh = "";
            for (int i = 0; i < F_Horizontal_Proj.Length; i++)
            {
                Sh += F_Horizontal_Proj[i].ToString() + " ";
            }
            FV_ProjBox.Text = Sh;
        }
        private void Recog_Button_Click(object sender, EventArgs e)
        {
            Bitmap Ch_Letter = new Bitmap(PathBox.Text);
            pictureBox2.Image = Ch_Letter;

            //Convert to Grayscale and make the projection
            for (int i = 0; i < Ch_Letter.Width; i++)//Cols => Width
            {
                Ch_Vertical_Proj[i] = 0;
                for (int j = 0; j < Ch_Letter.Height; j++) //Rows => Height
                {
                    Color tmp = Ch_Letter.GetPixel(i, j);
                    int Gray_Px = (tmp.R + tmp.G + tmp.B) / 3;

                    if (Gray_Px < 128) Ch_Vertical_Proj[i]++;
                }
            }

            //Alignment
            int pivot = 0;
            for (int i = 0; i < Ch_Vertical_Proj.Length; i++)
            {
                if (Ch_Vertical_Proj[i] != 0)
                {
                    pivot = i;
                    break;
                }
            }

            for (int i = 0; i < Ch_Vertical_Proj.Length - pivot; i++)
            {
                Ch_Vertical_Proj[i] = Ch_Vertical_Proj[pivot + i];
            }

            for (int i = Ch_Vertical_Proj.Length - pivot; i < Ch_Vertical_Proj.Length; i++)
                Ch_Vertical_Proj[i] = 0;

            //Display
            CH_ProjBox.Text = "";
            string S = "";
            for (int i = 0; i < Ch_Vertical_Proj.Length; i++)
            {
                S += Ch_Vertical_Proj[i].ToString() + " ";
            }
            CH_ProjBox.Text = S;

            //Convert to Grayscale and make the projection 
            for (int j = 0; j < Ch_Letter.Height; j++)//Cols => Width
            {
                Ch_Horizontal_Proj[j] = 0;
                for (int i = 0; i < Ch_Letter.Width; i++) //Rows => Height
                {
                    Color tmp = Ch_Letter.GetPixel(i, j);
                    int Gray_Px = (tmp.R + tmp.G + tmp.B) / 3;

                    if (Gray_Px < 128) Ch_Horizontal_Proj[j]++;
                }
            }

            int pivot2 = 0;
            for (int i = 0; i < Ch_Horizontal_Proj.Length; i++)
            {
                if (Ch_Horizontal_Proj[i] != 0)
                {
                    pivot2 = i;
                    break;
                }
            }

            for (int i = 0; i < Ch_Horizontal_Proj.Length - pivot2; i++)
            {
                Ch_Horizontal_Proj[i] = Ch_Horizontal_Proj[pivot2 + i];
            }

            for (int i = Ch_Horizontal_Proj.Length - pivot2; i < Ch_Horizontal_Proj.Length; i++)
                Ch_Horizontal_Proj[i] = 0;


            CV_ProjBox.Text = "";
            string Sh = "";
            for (int i = 0; i < Ch_Horizontal_Proj.Length; i++)
            {
                Sh += Ch_Horizontal_Proj[i].ToString() + " ";
            }
            CV_ProjBox.Text = Sh;

            int V_Diff = 0;
            for (int i = 0; i < F_Vertical_Proj.Length; i++)
            {
                V_Diff += Math.Abs(Ch_Vertical_Proj[i] - F_Vertical_Proj[i]);
            }
            HDiff_Box.Text = V_Diff.ToString();

            int H_Diff = 0;
            for (int i = 0; i < F_Horizontal_Proj.Length; i++)
            {
                H_Diff += Math.Abs(Ch_Horizontal_Proj[i] - F_Horizontal_Proj[i]);
            }
            VDiff_Box.Text = H_Diff.ToString();

            int Ecu_Dist = (int)Math.Sqrt(V_Diff * V_Diff + H_Diff * H_Diff);
            EcuBox.Text = Ecu_Dist.ToString();
        }

        private void EcuBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
