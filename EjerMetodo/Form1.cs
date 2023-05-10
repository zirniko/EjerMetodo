using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjerMetodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbEmpanada_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEmpanada.Checked)
            {
                pnlEmpanda.Visible = true;
            }
            else
            {
                pnlEmpanda.Visible = false;
            }
        }

        private void chbChilenito_CheckedChanged(object sender, EventArgs e)
        {
            if (chbChilenito.Checked)
            {
                pnlChilenito.Visible = true;
            }
            else
            {
                pnlChilenito.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)//aui soo instanciamos le metodo
        {
            string mensaje = "";
            try
            {
                //instanciar la clase en el EVENTO del botoon op. y llamamos lacmetodo CalcularTotal
                Operaciones op = new Operaciones();
                 mensaje = op.CalcularTotal(chbEmpanada.Checked,//aqui los los valores que s eenvina al metodo bool y stirng de el .cs
                                                 txtCantidadEmpanada.Text,//OJO todo debe estar ordenado 
                                                 chbChilenito.Checked,
                                                 txtCantidadChilenito.Text);
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
