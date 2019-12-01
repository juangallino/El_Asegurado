using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
           // this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        //funcion que limita la introduccion por teclado de tipo de entrada no deseada, los booleanos numeero, letra , control y seperador, 
        //deben posear el valor TRUE CUANDO SE DESEA QUE NO SE PUEDAN PRESIONAR
        public void LimitarKeypres(KeyPressEventArgs e, bool numero, bool letra, bool control, bool separador)

        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = numero;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = letra;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = control;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = separador;
            }
            else
            {
                e.Handled = true;
            }


        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarKeypres(e, false, false, false, false);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
