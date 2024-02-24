using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Taquarium aqua;
        private void Form1_Load(object sender, EventArgs e)
        {
            aqua = new Taquarium(pnl_aqua);
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
          aqua.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aqua.timer.Enabled = !aqua.timer.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aqua.pike.Next.Next.Next.Color.Name);
        }
    }
}
