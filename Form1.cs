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
            if (rdbKarp.Checked)
            {
                aqua.AddKarp(new Random());
                rdbKarp.Text = "Карп(" + aqua.karpCount + ")";
            }
            if (rdbPike.Checked)
            {
                aqua.AddPike(new Random());
                rdbPike.Text = "Щука(" + aqua.CountPike + ")";
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (NUDOrder.Value < 0)
            {
                MessageBox.Show("Ошибка валидации, очередь не может быть отрицательной");
            }
            if (rdbKarp.Checked)
            {
                aqua.DelKarp((int) NUDOrder.Value);
                rdbKarp.Text = "Карп(" + aqua.karpCount + ")";
            }
            if (rdbPike.Checked)
            {
                aqua.DelPike((int)NUDOrder.Value);
                rdbPike.Text = "Щука(" + aqua.CountPike + ")";
            }
        }
    }
}
