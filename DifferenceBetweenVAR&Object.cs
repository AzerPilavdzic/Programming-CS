using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P8
{
    public partial class frmPredavanje8 : Form
    {
        public frmPredavanje8()
        {
            InitializeComponent();
        }

        private void frmPredavanje8_Load(object sender, EventArgs e)
        {
            ObjectVarDynamic();
        }

        private void ObjectVarDynamic()
        {
            //razlika izmedju VAR i OBJECT
            //"object" je bazna klasa svih tipova u .NET
            object broj = 10;
            object ime = "denis";
            object ocjene = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var ocjene1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var keyValuePairs = new Dictionary<ExceptionHandlingClauseOptions, AccessViolationException>();

            //var je static
            //dynamic je dynamic
            dynamic broj2;
            broj2 = 10;
            broj2 = "deset";
            broj2.JebiGa();
            string lepeza = "ovo je nekada bila lepeza.";
            //propust samo kada u egzekuciji dodje do trigera.//"okidanja"
            broj2.ThisMethodDoesNotExist();
            //moze se koristiti kao parametar metoda za razliku od VAR
        }

        //ako stavimo object, bit ce error
        //1. nacin; parametar. neka zeljena metoda :: ToString(), Equals()..itd...
        //2. nacin; casting u neki tip pa onda na osnovu tipa u kojeg je moguce uraditi casting 
        //poziv metode koja je dostupna, u ovom slucaju metoda ThisMethodDoesNotExist();
        private void SlanjeParametara(object parametar) {
            parametar.ThisMethodDoesNotExist();
            parametar.ToString();
        }
    }
}
