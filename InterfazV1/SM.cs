using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazV1
{
    public partial class formSM : Form
    {
        public bool numerosPermitidos(TextBox texto, int min, int max)
        {
            if (Convert.ToDouble(texto.Text.Substring(texto.Text.Length - 1)) < min || Convert.ToDouble(texto.Text.Substring(texto.Text.Length - 1)) > max)
            {
                return false;
            }
            return true;
        }
        public formSM()
        {
            InitializeComponent();
        }

        private void formSM_Load(object sender, EventArgs e)
        {
            tbASM.Focus();
            tbASM.SelectAll();
        }

        private void btnCalcuSM_Click(object sender, EventArgs e)
        {
            string A = tbASM.Text;
            string B = tbBSM.Text;
            string[] guardados = new string[6];
            string auxA, auxB;
            clConverter objConverter = new clConverter(A);

            guardados[0]= objConverter.C1(A);
            guardados[1] = objConverter.C1(B);
            rAC1.Text = Regex.Replace(guardados[0], "(.{4})(?!$)", "$0 "); 
            rBC1.Text = Regex.Replace(guardados[1], "(.{4})(?!$)", "$0 ");
            claseOpera_SMC1C2 Operador = new claseOpera_SMC1C2(A,B);
            rABC1.Text= Regex.Replace(Operador.sumabinaria(guardados[0], guardados[1]), "(.{4})(?!$)", "$0 ");

            guardados[2] = objConverter.C2(A);
            guardados[3] = objConverter.C2(B);
            rAC2.Text = guardados[2];
            rBC2.Text = guardados[3];
            rABC2.Text = Regex.Replace(Operador.sumabinaria(guardados[2], guardados[3]), "(.{4})(?!$)", "$0 ");

            guardados[4] = objConverter.SM(A);
            guardados[5] = objConverter.SM(B);
            rASM.Text = guardados[4];
            rBSM.Text = guardados[5];
            rABSM.Text = Regex.Replace(Operador.sumabinaria(guardados[4], guardados[5]), "(.{4})(?!$)", "$0 ");

            /*Posiciones:
             0=AC1 , 1=BC1 , 2=AC2 , 3=BC2 , 4=ASM , 5=BSM
             */

            rAB_SMC1.Text = Regex.Replace(Operador.sumabinaria(guardados[4], guardados[1]), "(.{4})(?!$)", "$0 ");
            rBA_SMC1.Text = Regex.Replace(Operador.sumabinaria(guardados[5], guardados[0]), "(.{4})(?!$)", "$0 ");

            rAB_SMC2.Text = Regex.Replace(Operador.sumabinaria(guardados[4], guardados[3]), "(.{4})(?!$)", "$0 ");
            rBA_SMC2.Text = Regex.Replace(Operador.sumabinaria(guardados[5], guardados[2]), "(.{4})(?!$)", "$0 ");

            rAB_C1C2.Text = Regex.Replace(Operador.sumabinaria(guardados[0], guardados[3]), "(.{4})(?!$)", "$0 ");
            rBA_C1C2.Text = Regex.Replace(Operador.sumabinaria(guardados[1], guardados[2]), "(.{4})(?!$)", "$0 ");


            #region:Hacerlos visibles
            rAC1.Visible = true;
            rBC1.Visible = true;
            rABC1.Visible = true;

            rAC2.Visible = true;
            rBC2.Visible = true;
            rABC2.Visible = true;

            rASM.Visible = true;
            rBSM.Visible = true;
            rABSM.Visible = true;

            rAB_SMC1.Visible = true;
            rBA_SMC1.Visible = true;

            rAB_SMC2.Visible = true;
            rBA_SMC2.Visible = true;

            rAB_C1C2.Visible = true;
            rBA_C1C2.Visible = true;
            #endregion
            tbASM.Focus();
            tbASM.SelectAll();
        }

        private void rBSMDeci_CheckedChanged(object sender, EventArgs e)
        {
            tbASM.Focus();
            tbASM.SelectAll();
        }

        private void tbASM_KeyPress(object sender, KeyPressEventArgs   e)
        {
           // objValidar.formatoEntrada(rBSMBina, rBSMDeci, e);

        }

        private void tbBSM_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void rBSMBina_CheckedChanged(object sender, EventArgs e)
        {
            tbASM.Focus();
            tbASM.SelectAll();
        }
    }
}
