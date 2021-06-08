using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskMatrixTool.Forms.OzbVjeInputForm
{
    class VjerojatnostOzbiljnostObjekt
    {

        private int magnituda;

        private String TrosakPojava;

        private String opis;

        public int Magnituda { get => magnituda; set => magnituda = value; }
        public string TrosakPojava1 { get => TrosakPojava; set => TrosakPojava = value; }
        public string Opis { get => opis; set => opis = value; }
    }
}
