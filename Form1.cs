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
            aqua.timer.Enabled = !aqua.timer.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdbKarp.Checked)
            {
                aqua.AddKarp(new Random());
                //rdbKarp.Text = "Карп(" + aqua.karpCount + ")";
            }
            if (rdbPike.Checked)
            {
                aqua.AddPike(new Random());
                //rdbPike.Text = "Щука(" + aqua.CountPike + ")";
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (NUDOrder.Value < 0)
            {
                //MessageBox.Show("Ошибка валидации, очередь не может быть отрицательной");
            }
            if (rdbKarp.Checked)
            {
                aqua.DelKarp((int)NUDOrder.Value);
                //rdbKarp.Text = "Карп(" + aqua.karpCount + ")";
            }
            if (rdbPike.Checked)
            {
                aqua.DelPike((int)NUDOrder.Value);
                //rdbPike.Text = "Щука(" + aqua.CountPike + ")";
            }
        }
        public void updateCount()
        {
            rdbKarp.Text = "Карп(" + aqua.karpCount + ")";
            rdbPike.Text = "Щука(" + aqua.CountPike + ")";
        }

        private void NUDOrder_ValueChanged(object sender, EventArgs e)
        {
            string fish = rdbKarp.Text;
            if (rdbPike.Checked) fish = rdbPike.Text;
            toolTip1.SetToolTip(delBtn, "Убрать " + fish + " " + NUDOrder.Value);
        }

        private void rdbKarp_CheckedChanged(object sender, EventArgs e)
        {
            changeRdb();
        }
        private void changeRdb()
        {
            string fish = rdbKarp.Text;
            if (rdbPike.Checked) fish = rdbPike.Text;
            toolTip1.SetToolTip(button2, "Добавить " + fish);
            NUDOrder_ValueChanged(new object(),new EventArgs());
            toolTip1.SetToolTip(NUDOrder, "Выбрать " + fish);
        }

        private void rdbPike_CheckedChanged(object sender, EventArgs e)
        {
            changeRdb();
        }
    }
}
