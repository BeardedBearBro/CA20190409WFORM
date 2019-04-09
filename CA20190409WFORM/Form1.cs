using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA20190409WFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tbtipp ---> object
        //.text ---> fentinek egy mezője, ami string típusú
        //értéke JELENLEG az ami ÉPPEN be van gépelve
        //tf "1 3 4 "
        //.TrimEnd(' ') stringből ---> stringet csinál, méghozzá úgy, hogy a paraméterben
        //felsorolt karaktereket(ha van) leszedi a sting végéről 
        //"1 3 4" ---> "1 3 4"
        //Split(' ') string ---> string[]
        //ellenszeparátorok a zárójelben felsorolt karakterek(jelen esetben a szóköz)
        //"1 3 4" ---> {"1", "3", "4"}
        //.Lenght (ez a fenti tömb tulajdonsága)
        //visszaadja egész számként, hogy hány elemű a tömb
        //esetünkben {"1", "3", "4"} ---> 3db

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            lbldb.Text = $"{tbtipp.Text.TrimEnd(' ').Split(' ').Length} db";
        }

        private void btnhozzaad_Click(object sender, EventArgs e)
        {
            if (NevStimmel() && DaranszamStimmel()) Hozzaad();
        }

        private void Hozzaad()
        {
            var sw = new StreamWriter("egyszamjatek.txt", true, Encoding.UTF8);
            sw.WriteLine($"{tbnev.Text} {tbtipp.Text.TrimEnd(' ')}");
            MessageBox.Show("Sikeres hozzáadás");
            sw.Close();
        }

        private bool DaranszamStimmel()
        {
            var sr = new StreamReader("egyszamjatek.txt", Encoding.UTF8);
            if (int.Parse(lbldb.Text.Split(' ')[0]) ==
            sr.ReadLine().Split(' ').Length - 1)

            {
                sr.Close();
                return true;
            }


            else
            {
                sr.Close();
                MessageBox.Show("A tippek száma nem megfelelő!");
                return false;
            }
        }

        private bool NevStimmel()
        {
            var sr = new StreamReader("egyszamjatek.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                if (tbnev.Text == sr.ReadLine().Split(' ')[0])
                {
                    sr.Close();
                    MessageBox.Show("Van már ilyen nevű játékos!");
                    return false;
                }
            }
            sr.Close();
            return true;
        }
    }
}
