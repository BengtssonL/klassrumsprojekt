using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassrumsProjekt
{
    public partial class Form1 : Form
    { 
        //skapar en random variabel som senare ska användas 
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

        }
        //funktionen när man trycker på knapp 3 eller fight knappen. 
        private void Button3_Click(object sender, EventArgs e)
        {
           
            int random = rnd.Next(0, 2); 
            int attack = rnd.Next(0, 11);

            //randomiserar vilken knapp som ska minskas 
            if (random  == 1)
            {
                button1.Size = new Size(button1.Width - attack, button1.Height);
            }
            else 
            {
                button2.Size = new Size(button2.Width - attack, button2.Height);
            }
        }
        
    }
}
