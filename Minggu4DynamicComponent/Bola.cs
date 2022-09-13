using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu4DynamicComponent
{
    class Bola : RadioButton
    {

        public double dx, dy;


        public Bola() : base()
        {
            dx = 5;
            dy = 5;
        }

        public void gerak()
        {
            this.Top = Convert.ToInt32( this.Top + dy);
            this.Left= Convert.ToInt32(this.Left+ dx);            
        }
        public void mantulX()
        {
            dx = -dx;
        }
        public void mantulY()
        {
            dy = -dy;
        }
        public void speedUp(double factor)
        {
            dx *= factor;
            dy *= factor;

        }
    }
}
