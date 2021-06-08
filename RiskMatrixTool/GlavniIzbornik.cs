using RiskMatrixTool.Forms.OzbVjeInputForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskMatrixTool
{
    public partial class GlavniIzbornik : Form
    {

        
        public GlavniIzbornik()
        {
            InitializeComponent();
        }

        private void GlavniIzbornik_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OzbiljnostButton_Click(object sender, EventArgs e)
        {
            Form unosOzbiljnostiForm = new OzbVjeInputForm("o");
            unosOzbiljnostiForm.ShowDialog();
        }

        private void VjerojatnostButton_Click(object sender, EventArgs e)
        {
            Form unosOzbiljnostiForm = new OzbVjeInputForm("v");
            unosOzbiljnostiForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
