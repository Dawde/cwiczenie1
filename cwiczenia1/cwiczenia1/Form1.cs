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
        string uzytkownik;
        string zaznaczony;
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
            if (listBox1.Items.Contains(uzytkownik))
            {
                DialogResult czynapewno = MessageBox.Show("Czy chcesz wyczyscic formularz?", "Taki użytkownik już istnieje", MessageBoxButtons.YesNo);
                if (czynapewno == DialogResult.Yes) czyscForm();
                return false;
            }
            else
            {
                listBox1.Items.Add(uzytkownik);
                czyscForm();
                nameText.Focus();
                return true;
            }
        }

        private void czyscForm()
        {
            nameText.Clear();
            surname.Clear();
        }

        private void usunUsera()
        {

            if (listBox1.Items.Count>0)
            {
                zaznaczony = listBox1.SelectedItem.ToString();

                DialogResult czynapewno = MessageBox.Show("Czy na pewno?", "Czy na pewno?", MessageBoxButtons.YesNo);
                if (czynapewno == DialogResult.Yes) listBox1.Items.Remove(zaznaczony);
            }
        }

        private void edytujUsera()
        {
            string zaznaczony = listBox1.SelectedItem.ToString();
            if (zaznaczony != "")
            {

            }
        }
        #endregion

        private void addUser_Click(object sender, EventArgs e)
        {
            
            if (czyWypelnione(nameText) & czyWypelnione(surname))
            {
                uzytkownik = nameText.Text + " " + surname.Text + " " + age.Value;
                dodajUzytkownikaDoListy(uzytkownik);
                uzytkownik = "";
            }

        }

        private void nameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 127)
            {
                e.Handled = true;
            }

            if (e.KeyChar==13)
            {
                surname.Focus();
            }
        }

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar!='-' && e.KeyChar!=08 && e.KeyChar!=127)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                wiek.Focus();
            }
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            addUser_Click(sender, e);
        }

        private void dilit(object sender, EventArgs e)
        {
               usunUsera();
        }

        private void edytuj(object sender, EventArgs e)
        {

        }

        private void age_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
