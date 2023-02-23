using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pf_metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clear();
        }
   //     string funcion;
     // char[] Gfuncion = new char[45];
        char[] op = new char[50];
        String Op;

        private void clear()
        {
            Funcion_txt.Clear();
            GFuncion_txt.Clear();
            ce_txt.Clear();
            Funcion_txt.Enabled = true;
            ce_txt.Enabled = true;
            btn_Calc.Enabled = true;
            btn_Clear.Enabled = false;
        }
        private void startCalc()
        {
            Funcion_txt.Enabled = false;
            ce_txt.Enabled = false;
            btn_Calc.Enabled = false;
            btn_Clear.Enabled = true;
            GFuncion_txt.Enabled = false;
        }
        //private void obtainText()
        //{
        //    funcion = Funcion_txt.Text;
        //    Gfuncion = funcion.ToCharArray();
        //}
        private void Separa()
        {
            Op = Funcion_txt.Text;
            op = Op.ToCharArray();
        }

        private void btn_Calc_Click_1(object sender, EventArgs e)
        {
            startCalc();
            Separa();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void Salir()
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.Funcion_txt.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
