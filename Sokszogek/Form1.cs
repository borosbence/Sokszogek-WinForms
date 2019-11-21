using Sokszogek.Presenters;
using Sokszogek.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokszogek
{
    public partial class Form1 : Form, ISokszogView, IHaromszog
    {
        private SokszogPresenter presenter;
        public Form1()
        {
            presenter = new SokszogPresenter(this, this);
            InitializeComponent();
            textBoxOldalC.Hide();
            labelOldalC.Hide();
        }

        public string oldalA
        {
            get => textBoxOldalA.Text;
            set => textBoxOldalA.Text = value;
        }
        public string oldalB
        {
            get => textBoxOldalB.Text;
            set => textBoxOldalB.Text = value;
        }
        public string oldalC
        {
            get => textBoxOldalC.Text;
            set => textBoxOldalC.Text = value;
        }

        public string Kerulet
        {
            get => textBoxKerulet.Text;
            set => textBoxKerulet.Text = value; 
}
        public string Terulet
        {
            get => textBoxTerulet.Text;
            set => textBoxTerulet.Text = value;
        }
        public IList<string> SokszogList
        {
            get => (List<string>)comboBoxSokszog.DataSource;
            set => comboBoxSokszog.DataSource = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void comboBoxSokszog_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ShowOldal(comboBoxSokszog.SelectedIndex);
            if (presenter.oldalCLetezik)
            {
                textBoxOldalC.Show();
                labelOldalC.Show();
            }
            else
            {
                textBoxOldalC.Hide();
                labelOldalC.Hide();
            }
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            presenter.Calculate();
        }
    }
}
