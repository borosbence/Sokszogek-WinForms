using Sokszogek.Presenters;
using Sokszogek.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokszogek.Views
{
    public partial class SokszogForm : Form, ISokszogekView
    {
        public string oldalA 
        {
            get => OldalATextBox.Text;
        }
        public string oldalB 
        {
            get => OldalBTextBox.Text;
        }
        public string oldalC 
        {
            get => OldalCTextBox.Text;
        }
        public string errorOldalA
        {
            get => OldalAerrorP.GetError(OldalATextBox);
            set => OldalAerrorP.SetError(OldalATextBox,value); 
        }
        public string errorOldalB
        {
            get => OldalBerrorP.GetError(OldalBTextBox);
            set => OldalBerrorP.SetError(OldalBTextBox, value);
        }
        
        public string errorOldalC 
        {
            get => OldalCerrorP.GetError(OldalCTextBox);
            set => OldalCerrorP.GetError(OldalCTextBox);
        }

        public string Kerulet
        {
            set => KeruletTextBox.Text = value;
        }
        public string Terulet
        {
            set => TeruletTextBox.Text = value;
        }
        public List<string> SokszogList
        {
            set => SokszogListComboBox.DataSource = value;
        }

        private SokszogPresenter presenter;

        public SokszogForm()
        {
            InitializeComponent();
            presenter = new SokszogPresenter(this);
            OldalBLabel.Hide();
            OldalBTextBox.Hide();
            OldalCLabel.Hide();
            OldalCTextBox.Hide();
        }

        private void SokszogForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void SokszogListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            presenter.GetSokszogType(
                SokszogListComboBox.SelectedIndex);
            if (presenter.oldalBLetezik)
            {
                OldalBTextBox.Show();
                OldalBLabel.Show();
            }
            else
            {
                OldalBLabel.Hide();
                OldalBTextBox.Hide();
            }
            if (presenter.oldalCLetezik)
            {
                OldalCTextBox.Show();
                OldalCLabel.Show();
            }
            else
            {
                OldalCLabel.Hide();
                OldalCTextBox.Hide();
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            presenter.Calculate();
        }
    }
}
