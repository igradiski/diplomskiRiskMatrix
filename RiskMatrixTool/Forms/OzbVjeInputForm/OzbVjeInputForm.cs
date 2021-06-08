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
        private static List<VjerojatnostOzbiljnostObjekt> listaVjerojatnosti = new List<VjerojatnostOzbiljnostObjekt>();

        private static List<VjerojatnostOzbiljnostObjekt> listaOzbiljnosti = new List<VjerojatnostOzbiljnostObjekt>();

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
            
        }

        private void OzbVjeInputForm_Load(object sender, EventArgs e)
        {

        }
        private void pripremiEkran()
        {
            this.Text = tipForme == "o" ? "Forma za unos parametara ozbiljnosti" : "Forma za unos parametara vjerojatnosti";
            TrosakPojavaLabel.Text = tipForme == "o" ? "Trošak:" : "Broj pojava:";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            MagnitudaText.Clear();
            TrosakPojavaTextBox.Clear();
            OpisTextBox.Clear();
            MagnitudaText.BackColor = Color.White;
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            VjerojatnostOzbiljnostObjekt noviObjekt = new VjerojatnostOzbiljnostObjekt();

            try
            {
                noviObjekt.Magnituda = int.Parse(MagnitudaText.Text);
            }
            catch
            {
                noviObjekt.Magnituda = 0;
                MessageBox.Show("Unesite magnitudu u intervalu od 1 do 5 !");
                MagnitudaText.BackColor = Color.DarkRed;
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
        }

        private Boolean provjeriParametre(VjerojatnostOzbiljnostObjekt noviObjekt)
        {
            Boolean vecPostoji = false;
            if(noviObjekt.Opis.Length > 0 && noviObjekt.TrosakPojava1.Length > 0 && noviObjekt.Magnituda != 0)
            {
                if (tipForme == "o")
                    vecPostoji = listaOzbiljnosti.Any(obj => obj.Magnituda == noviObjekt.Magnituda);
                else
                    vecPostoji = listaVjerojatnosti.Any(obj => obj.Magnituda == noviObjekt.Magnituda);
            }
            return !vecPostoji;
        }
    }
}
