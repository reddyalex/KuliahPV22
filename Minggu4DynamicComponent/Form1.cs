using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu4DynamicComponent
{
    
    public partial class Form1 : Form
    {
        const int borderWidth = 17;
        const int borderHeight = 40;
        public Form1()
        {
            InitializeComponent();
        }
        int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Text = timer / 10 +"";
            for (int i = 0; i < 3; i++)
            {

            }
            bola1.gerak();

            if (bola1.Top <= 0 || bola1.Bottom > this.Height  - borderHeight)
            {
                bola1.mantulY();
            }

            if (bola1.Left <= 0|| bola1.Right >= this.Width - borderWidth)
            {
                bola1.mantulX();
            }

            if(bola1.Bottom >= papan.Top && papan.Left<= bola1.Left && papan.Right>=bola1.Left)
            {
                bola1.dy = -(Math.Abs( bola1.dy));
            }


            timer++;
            if (timer % 50==0)
            {
                bola1.speedUp(1.1);
            }
        }
        Color[] colorBrick = { Color.Black,Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.White };

        List<Button> buttons;


        private void level1()
        {
            buttons = new List<Button>();            
            Random rnd = new Random();

            // Looping untuk baris
            for (int k = 0; k < 8; k++)
            {
                // Looping untuk 3 kolom
                for (int j = 0; j < 3; j++)
                {
                    var nyawa = rnd.Next(1, 6);
                    // 3 button dempet
                    for (int i = 0; i < 3; i++)
                    {
                        Button btn = new Button();
                        btn.Tag = nyawa;
                        btn.BackColor = colorBrick[nyawa];
                        btn.Left = 65 + 45 * i + j * 200;
                        btn.Top = 30 + 25*k;
                        btn.Width = 40;
                        btn.Height = 20;
                        btn.Click += new EventHandler(this.button1_Click);
                        this.Controls.Add(btn); // di tampilkan ke form
                        buttons.Add(btn);
                        btn.Enabled = false;
                    }
                }

            }




        }


        private void Form1_Load(object sender, EventArgs e)
        {
            level1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            
            btn.Tag = Convert.ToInt32(btn.Tag) - 1;
            btn.BackColor = colorBrick[(int)btn.Tag];
            if((int)btn.Tag == 0)
            {
                btn.Visible = false;
            }
        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            papan.Left = e.X - papan.Width / 2;
            if (papan.Left <=0) papan.Left = 0;
            if(papan.Right>= this.Width - borderWidth)
            {
                papan.Left = this.Width - borderWidth - papan.Width;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Test");
            if(e.KeyData == Keys.A)
            {
                papan.Left -= 5;
                if (papan.Left <= 0) papan.Left = 0;
            }
            if (e.KeyData == Keys.D)
            {
                papan.Left += 5;
                if (papan.Right >= this.Width - borderWidth)
                {
                    papan.Left = this.Width - borderWidth - papan.Width;
                }
            }
        }
    }
}
