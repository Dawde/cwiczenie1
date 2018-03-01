using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cwiczenia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region MojeMetody
        private bool czyWypelnione(TextBox poleTekstowe)
        {
            if (poleTekstowe.Text == "")
            {
                errorText.SetError(poleTekstowe, "Pole niewypelnione");
                return false;
            }
            errorText.SetError(poleTekstowe, "");
            return true;
        }

        private bool dodajUzytkownikaDoListy(string uzytkownik)
        {

        }

        #endregion

        private void addUser_Click(object sender, EventArgs e)
        {
            if(czyWypelnione(nameText) & czyWypelnione(surname))
            {

            }

        }
    }
}
