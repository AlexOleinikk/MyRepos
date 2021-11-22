using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collections;

namespace HCI_Lab2
{
    public partial class Species : Form
    {
        DictionarySpecies dictionaries = new DictionarySpecies();

        public string chosenKingdom;

        public Species(string input, string chosenKingdom)
        {
            InitializeComponent();

            richTextBox1.Text = dictionaries.species[input];

            this.chosenKingdom = chosenKingdom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseSpecies formChoose = new ChooseSpecies(chosenKingdom);
            formChoose.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseKingdom formKingdom = new ChooseKingdom();
            formKingdom.Show();
            Hide();
        }
    }
}
