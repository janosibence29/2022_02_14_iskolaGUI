using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iskolagui2
{
    public partial class Form1 : Form
    {
        List<Tanuló> tanulók = new List<Tanuló>();
        BindingSource bs;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKilépés_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBetöltés_Click(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("nevek.txt"))
            {
                tanulók.Add(new Tanuló(sor));
            }
            bs = new BindingSource();
            bs.DataSource = tanulók;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Név";
        }

        private void btnTörlés_Click(object sender, EventArgs e)
        {
            tanulók.RemoveAt(listBox1.SelectedIndex);
            bs.ResetBindings(false);
        }
    }
}
