using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Lab2
{
    public partial class ChooseKingdom : Form
    {
        public ChooseKingdom()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gainsboro;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gainsboro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseSpecies formChoose = new ChooseSpecies("Animals");
            formChoose.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseSpecies formChoose = new ChooseSpecies("Plants");
            formChoose.Show();
            Hide();
        }
    }
}
