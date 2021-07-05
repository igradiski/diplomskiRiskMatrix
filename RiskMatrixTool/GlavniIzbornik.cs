using RiskMatrixTool.Forms.OzbVjeInputForm;
using RiskMatrixTool.Forms.PregledRizikaForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RiskMatrixTool
{
    public partial class GlavniIzbornik : Form
    {
        private List<VjerojatnostOzbiljnostObjekt> listaVjerojatnosti = new List<VjerojatnostOzbiljnostObjekt>();

        private List<VjerojatnostOzbiljnostObjekt> listaOzbiljnosti = new List<VjerojatnostOzbiljnostObjekt>();

        public GlavniIzbornik()
        {
            InitializeComponent();
            PostaviInicijalniRangRizika();
            IzracunButton.Visible = false;
            PostaviInicijalnePodatkeUMatricu();
        }

        private void PostaviInicijalniRangRizika()
        {
            txtNiskiRizikOd.Text = 0.ToString();
            txtNiskiRizikDo.Text = 2.ToString();

            txtSrednjiRizikOd.Text = 3.ToString();
            txtSrednjiRizikDo.Text = 5.ToString();

            txtVisokRizikOd.Text = 6.ToString();
            txtVisokRizikDo.Text = 8.ToString();
        }

        private void PostaviInicijalnePodatkeUMatricu()
        {
            List<Panel> listaPanelaMatrice = new List<Panel>();
            foreach(Panel panel in panel3.Controls.OfType<Panel>())
            {
                if (panel.Name.Contains("pnl"))
                {
                    panel.Controls.OfType<Label>().ElementAt(0).Text = "--";
                }
            }
            
        }


        private void GlavniIzbornik_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OzbiljnostButton_Click_1(object sender, EventArgs e)
        {
            OzbVjeInputForm ozbVjeInputForm = new OzbVjeInputForm("o");
            ozbVjeInputForm.ShowDialog();
            if (ozbVjeInputForm.ListaOzbiljnosti.Count == 5)
            {
                listaOzbiljnosti = ozbVjeInputForm.ListaOzbiljnosti.OrderBy(x => x.Magnituda).ToList(); ;
            }
            IzracunButton.Visible = ProvjeriVidljivostGumbaIzracun();
        }

        private void VjerojatnostButton_Click_1(object sender, EventArgs e)
        {
            OzbVjeInputForm ozbVjeInputForm = new OzbVjeInputForm("v");
            ozbVjeInputForm.ShowDialog();
            if(ozbVjeInputForm.ListaVjerojatnosti.Count == 5)
            {
                listaVjerojatnosti = ozbVjeInputForm.ListaVjerojatnosti.OrderBy(x => x.Magnituda).ToList();
            }
            IzracunButton.Visible = ProvjeriVidljivostGumbaIzracun();
            
        }

        private bool ProvjeriVidljivostGumbaIzracun()
        {
            return listaOzbiljnosti.Count== 5 && listaVjerojatnosti.Count == 5 ? true : false;
        }

        private void IzracunButton_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in panel3.Controls.OfType<Panel>())
            {
                izracunajVrijednostZaPanel(panel);
            }
        }

        private void izracunajVrijednostZaPanel(Panel panel)
        {
            String lokacija = panel.Name.Substring(panel.Name.Length - 2);
            char[] lokacije = lokacija.ToCharArray();
            int red = int.Parse(lokacije[0].ToString());
            int stupac = int.Parse(lokacije[1].ToString());
            int magnitudaVjerojatnost = listaVjerojatnosti.ElementAt(stupac - 1).Magnituda;
            int magnitudaOzbiljnost = listaOzbiljnosti.ElementAt(red - 1).Magnituda;
            int rezultat = magnitudaOzbiljnost + magnitudaVjerojatnost;
            panel.Controls.OfType<Label>().ElementAt(0).Text = rezultat.ToString();
            panel.BackColor = dohvatiBojuPremaRaziniRizika(rezultat);
        }

        private Color dohvatiBojuPremaRaziniRizika(int rezultat)
        {
            int niskiDo = int.Parse(txtNiskiRizikDo.Text);
            int srednjiDo = int.Parse(txtSrednjiRizikDo.Text);
            Color color = Color.Transparent;
            if(rezultat <= niskiDo)
            {
                color = Color.Green;
            }
            else if (rezultat <= srednjiDo)
            {
                color = Color.Yellow;
            }
            else
            {
                color = Color.Red;
            }

            return color;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        private void pregledParametara(String nazivMetode)
        {
            if (ProvjeriVidljivostGumbaIzracun())
            {
                String lokacija = nazivMetode.Substring(3, 2);
                char[] lokacije = lokacija.ToCharArray();
                int red = int.Parse(lokacije[0].ToString());
                int stupac = int.Parse(lokacije[1].ToString());
                String opisVjerojatnosti = listaVjerojatnosti.ElementAt(stupac-1).Opis;
                String trosakVjerojatnosti = listaVjerojatnosti.ElementAt(red-1).TrosakPojava1;
                String opisOzbiljnosti = listaOzbiljnosti.ElementAt(stupac-1).Opis;
                String trosakOzbiljnosti = listaOzbiljnosti.ElementAt(red-1).TrosakPojava1;
                int magnitudaVjerojatnost = listaVjerojatnosti.ElementAt(stupac - 1).Magnituda;
                int magnitudaOzbiljnost = listaOzbiljnosti.ElementAt(red - 1).Magnituda;
                int rezultat = magnitudaOzbiljnost + magnitudaVjerojatnost;
                PregledRizika pregledRizikaForm = new PregledRizika(
                    opisVjerojatnosti, 
                    trosakVjerojatnosti,
                    opisOzbiljnosti,
                    trosakOzbiljnosti,
                    rezultat.ToString()
                    );
                pregledRizikaForm.ShowDialog();
            }
        }
        private void pnl11_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl12_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl13_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl14_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl15_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl21_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl22_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl23_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl24_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl25_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl31_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl32_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl33_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl34_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl35_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl41_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl42_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl43_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl44_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl45_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl51_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl52_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl53_DoubleClick(object sender, EventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl54_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }


        private void pnl55_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void pnl53_MouseClick(object sender, MouseEventArgs e)
        {
            pregledParametara(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
