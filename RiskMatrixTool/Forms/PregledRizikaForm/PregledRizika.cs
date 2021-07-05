using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskMatrixTool.Forms.PregledRizikaForm
{
    public partial class PregledRizika : Form
    {
        public PregledRizika()
        {
            InitializeComponent();
        }

        private String opisVjerojatnosti="";
        private String trosakVjerojatnosti = "";
        private String opisOzbiljnosti = "";
        private String trosakOzbiljnosti = "";
        private String rezultat = "";

        public PregledRizika(
                    String opisVjerojatnosti,
                    String trosakVjerojatnosti,
                    String opisOzbiljnosti,
                    String trosakOzbiljnosti,
                    String rezultat)
        {
            InitializeComponent();
            this.opisVjerojatnosti = opisVjerojatnosti;
            this.trosakVjerojatnosti = trosakVjerojatnosti;
            this.opisOzbiljnosti = opisOzbiljnosti;
            this.trosakOzbiljnosti = trosakOzbiljnosti;
            this.rezultat = rezultat;
    }

        private void PregledRizika_Load(object sender, EventArgs e)
        {
            lblOzbiljnostOpis.Text = opisOzbiljnosti;
            lblVjerojatnostOpis.Text = opisVjerojatnosti;
            lblTrosak.Text = trosakOzbiljnosti;
            lblBrojPojava.Text = trosakVjerojatnosti;
            lblRezultat.Text = rezultat;
        }

        private void pnlOzbiljnost_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlOzbiljnost.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        private void pnlVjerojatnost_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlVjerojatnost.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }
    }
}
