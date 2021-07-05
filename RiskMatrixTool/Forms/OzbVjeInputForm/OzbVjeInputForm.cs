using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskMatrixTool.Forms.OzbVjeInputForm
{

    public partial class OzbVjeInputForm : Form
    {
        private List<VjerojatnostOzbiljnostObjekt> listaVjerojatnosti = new List<VjerojatnostOzbiljnostObjekt>();
        internal List<VjerojatnostOzbiljnostObjekt> ListaVjerojatnosti { get => listaVjerojatnosti; set => listaVjerojatnosti = value; }
        internal List<VjerojatnostOzbiljnostObjekt> ListaOzbiljnosti { get => listaOzbiljnosti; set => listaOzbiljnosti = value; }

        private List<VjerojatnostOzbiljnostObjekt> listaOzbiljnosti = new List<VjerojatnostOzbiljnostObjekt>();

        private List<String> listaMogucihMagnituda = new List<String>();

        private String tipForme = "";


        public OzbVjeInputForm()
        {
            InitializeComponent();
            
        }
        public OzbVjeInputForm(String tipForme)
        {
            InitializeComponent();
            this.tipForme = tipForme;
            pripremiEkran();
            unesiMagnitude();
            ucitajMagnitude();
        }
        private void unesiMagnitude()
        {
            listaMogucihMagnituda.Add("0");
            listaMogucihMagnituda.Add("1");
            listaMogucihMagnituda.Add("2");
            listaMogucihMagnituda.Add("3");
            listaMogucihMagnituda.Add("4");
        }

        private void ucitajMagnitude()
        {
            var dataSource = new BindingSource();
            dataSource.DataSource = listaMogucihMagnituda;
            MagnitudaCombo.DataSource = dataSource;
        }

        private void OzbVjeInputForm_Load(object sender, EventArgs e)
        {

        }
        private void pripremiEkran()
        {
            this.Text = tipForme == "o" ? "Forma za unos parametara ozbiljnosti" : "Forma za unos parametara vjerojatnosti";
            TrosakPojavaLabel.Text = tipForme == "o" ? "Trošak:" : "Broj pojava:";
            ucitajPodatkeNaGrid();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TrosakPojavaTextBox.Clear();
            OpisTextBox.Clear();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            VjerojatnostOzbiljnostObjekt noviObjekt = new VjerojatnostOzbiljnostObjekt();
            try
            {
                //noviObjekt.Magnituda = int.Parse(MagnitudaText.Text);
                noviObjekt.Magnituda = int.Parse(MagnitudaCombo.SelectedValue.ToString());
                listaMogucihMagnituda.Remove(noviObjekt.Magnituda.ToString());
                ucitajMagnitude();
            }
            catch
            {
                noviObjekt.Magnituda = 0;
                MessageBox.Show("Unesite magnitudu u intervalu od 1 do 5 !");
            }
            noviObjekt.Opis = OpisTextBox.Text;
            noviObjekt.TrosakPojava1 = TrosakPojavaTextBox.Text;
            if (provjeriParametre(noviObjekt))
            {
                if (tipForme == "o")
                    
                    listaOzbiljnosti.Add(noviObjekt);
                else
                    listaVjerojatnosti.Add(noviObjekt);
            }
            else
            {
                MessageBox.Show("Fale potrebni parametri ili je magnituda u krivom formatu!");
            }

            ucitajPodatkeNaGrid();
            provjeriBrojMagnituda();
        }
        
        private void  provjeriBrojMagnituda()
        {
            InputButton.Visible = listaMogucihMagnituda.Count == 0 ? false : true;
        }
        private void ucitajPodatkeNaGrid()
        {
            var dataSource = new BindingSource();
            if (tipForme == "o")
                dataSource.DataSource = listaOzbiljnosti.OrderBy(x => x.Magnituda).ToList();
            else
                dataSource.DataSource = listaVjerojatnosti.OrderBy(x => x.Magnituda).ToList();
            VjerojatnostOzbiljnostData.DataSource = dataSource;
            PrilagodiDataGrid();
        }

        private void PrilagodiDataGrid()
        {
            VjerojatnostOzbiljnostData.Columns[0].Width = 80;
            VjerojatnostOzbiljnostData.Columns[1].Width = 260;
            VjerojatnostOzbiljnostData.Columns[2].Width = 260;
            VjerojatnostOzbiljnostData.Columns[1].HeaderText = tipForme == "o" ? "Trošak" : "Broj godišnjih pojava";
        }

        private Boolean provjeriParametre(VjerojatnostOzbiljnostObjekt noviObjekt)
        {
            Boolean vecPostoji = false;
            if (noviObjekt.Opis != null && noviObjekt.TrosakPojava1 != null)
            {
                if (tipForme == "o")
                    vecPostoji = listaOzbiljnosti.Any(obj => obj.Magnituda == noviObjekt.Magnituda);
                else
                    vecPostoji = listaVjerojatnosti.Any(obj => obj.Magnituda == noviObjekt.Magnituda);
            }
            return !vecPostoji;
        }

        private void BrisiButton_Click(object sender, EventArgs e)
        {
            try
            {
                VjerojatnostOzbiljnostObjekt objektZaBrisanje = VjerojatnostOzbiljnostData.SelectedRows[0].DataBoundItem as VjerojatnostOzbiljnostObjekt;
                if (objektZaBrisanje != null)
                {
                    if (tipForme == "o")
                    {
                        listaOzbiljnosti.RemoveAll(x => x.Magnituda == objektZaBrisanje.Magnituda);
                        listaMogucihMagnituda.Add(objektZaBrisanje.Magnituda.ToString());
                        ucitajMagnitude();
                        provjeriBrojMagnituda();
                    }
                    else
                    {
                        listaVjerojatnosti.RemoveAll(x => x.Magnituda == objektZaBrisanje.Magnituda);
                        listaMogucihMagnituda.Add(objektZaBrisanje.Magnituda.ToString());
                        ucitajMagnitude();
                        provjeriBrojMagnituda();
                    }
                }
                else
                {
                    MessageBox.Show("Niste odabrali zapis za brisanje!");
                }
            }
            catch
            {
                MessageBox.Show("Niste odabrali zapis za brisanje!");
            }
            ucitajPodatkeNaGrid();
        }

        private void OzbVjeInputForm_Leave(object sender, EventArgs e)
        {
            
        }

        private bool ProvjeraIskoristenostiParametara()
        {
            return listaMogucihMagnituda.Count == 0 ? false : true;
        }

        private void OzbVjeInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ProvjeraIskoristenostiParametara())
            {
                if (MessageBox.Show("Niste ispunili sve parametre! Jeste li sigurni da želite zatvoriti formu?"
                , "Nedostaju parametri", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
    }
}
