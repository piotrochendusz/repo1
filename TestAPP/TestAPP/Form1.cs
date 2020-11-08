using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
//test1
//update test

namespace TestAPP
{



    public partial class Form1 : Form
    {
public class zapalka
        {

            public zapalka(int num)
            {
                number = num;

            }
            private int number;     
        }

        public class pudelko
        {
            public void dodajzapalke(zapalka item)
            {
                zapalki.Add(item);
            }

            List<zapalka> zapalki = new List<zapalka>();

        }









        private Bitmap _imgDuszek;
        private int _x = 0;
        private int _y = 0;
        int x1 = 1;
        bool przod = true;

        public Form1()
        {
            pudelko p1 = new pudelko();
 

            for (int a = 0; a < 38; a++)
            {
                p1.dodajzapalke(new zapalka(a));
            }


            InitializeComponent();
            label1.Text = "dev3 change";
            label2.Text = "master dev3 changes";

            _imgDuszek = new Bitmap(@"C:\Piotr\test.png");


        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int[,] barttab = new int[3, 3];
            barttab[0, 0] = 1;
            barttab[0, 1] = 1;
            barttab[0, 2] = 1;

            //for (int i = 0; i < 5; i++)
            for (int a = 0; a < 3; a++)
                for (int b = 0; b < 3; b++)
                    barttab[a, b] = 1;




        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ///MessageBox.Show("call from master main  window");
            //3

   
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           // base.OnPaint(e);
           if(przod)
            e.Graphics.DrawImage(_imgDuszek, _x++, 0);
           else
                e.Graphics.DrawImage(_imgDuszek, _x--, 0);

            if (_x > 800)
                przod = false;
            else if(_x < 0 )
                przod = true;

            Invalidate();
        }
    }
}
