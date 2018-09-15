using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duomenu_tyryba_1uzd_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Viesbutis> viesbuciaiAll = new List<Viesbutis>() {
                new Viesbutis("Congress", 3, 12.6, 40),
                new Viesbutis("Embassy", 4, 2, 150),
                new Viesbutis("Europa", 3, 0.6, 100),
                new Viesbutis("LR Seimo", 1, 0.5, 5)
        };
            foreach (var vies in viesbuciaiAll)
            {
                vAll.Text = vAll.Text + vies.Pavadinimas + " " + vies.Zvaigzdutes + " " + vies.Atstumas_iki_centro + "\n";
            }
        }
    }
}
