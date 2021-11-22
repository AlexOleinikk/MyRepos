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
    public partial class ChooseSpecies : Form
    {
        public string chosenKingdom;

        public string chosenGroup;

        DictionarySpecies dictionaries = new DictionarySpecies();

        public ChooseSpecies(string chosenKingdom)
        {
            InitializeComponent();

            this.chosenKingdom = chosenKingdom;
        }

        private void ChooseSpecies_Load(object sender, EventArgs e)
        {
            if (chosenKingdom == "Animals")
            {
                label4.Text = "Обрати тварину";
            }
            else if (chosenKingdom == "Plants")
            {
                label4.Text = "Обрати рослину";
            }

            dictionaries = new DictionarySpecies();

            comboBox1.DataSource = dictionaries.kingdom[chosenKingdom];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = dictionaries.subkingdom[comboBox1.SelectedItem.ToString()];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenGroup = comboBox2.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Species formSpecies = new Species(chosenGroup, chosenKingdom);
            formSpecies.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseKingdom formKingdom = new ChooseKingdom();
            formKingdom.Show();
            Hide();
        }
    }
}
