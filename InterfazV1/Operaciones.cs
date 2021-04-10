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
    public partial class Operaciones : Form
    {
        int i = -1, j = 0, k = 0;
        double valor1 = 0, valor2 = 0, total = 0, aux = 1, aux2 = 1;
        string operacion, operacion2, operacion3;
        bool control = false, controlproducto = false, controldivision = true;
        #region Memoria
        //lo que hace es ir concatenando la cadena xD
        private void toMemory(string operation)
        {
            try
            {
                if (memoria.Text.Substring(memoria.Text.Length - 1) != "=")
                {
                    memoria.Text += numerosIngresados.Text + operation;
                }
            }
            catch
            {
                memoria.Text = memoria.Text + numerosIngresados.Text + operation;
                if (memoria.Text.Substring(memoria.Text.Length - 1) == "=")
                {
                    memoria.Text = memoria.Text.Substring(numerosIngresados.Text.Length + 1);
                }
            }
            control = true;
        }
        //reiniciamos la calcu
        private void memoryOperationControl()
        {
            try
            {
                if (memoria.Text.Substring(memoria.Text.Length - 1) == "=")
                {
                    numerosIngresados.Text = "";
                }
            }
            catch
            {
            }
        }
        #endregion

        #region Acciones de radio buttons
        private void enabled(Button objButton)
        {
            objButton.Enabled = true;
        }
        private void disabled(Button objButton)
        {
            objButton.Enabled = false;
        }
        private void enabled_buttonsHEX()
        {
            enabled(diez);
            enabled(once);
            enabled(doce);
            enabled(trece);
            enabled(catorce);
            enabled(quince);
        }
        private void disabled_buttonsHEX()
        {
            disabled(diez);
            disabled(once);
            disabled(doce);
            disabled(trece);
            disabled(catorce);
            disabled(quince);
        }
        private void enabled_buttonsOCT()
        {
            enabled(ocho);
            enabled(nueve);
        }
        private void disabled_buttonsOCT()
        {
            disabled(ocho);
            disabled(nueve);

        }
        private void enabled_buttonsBIN()
        {
            enabled(dos);
            enabled(tres);
            enabled(cuatro);
            enabled(cinco);
            enabled(seis);
            enabled(siete);
            enabled(ocho);
            enabled(nueve);
        }
        private void disabled_buttonsBIN()
        {
            disabled(dos);
            disabled(tres);
            disabled(cuatro);
            disabled(cinco);
            disabled(seis);
            disabled(siete);
            disabled(ocho);
            disabled(nueve);
        }
        #endregion

        #region Entradas de botones
        private void write(string numberletter)
        {
            if (control == true)
            {
                numerosIngresados.Text = "";
                control = false;
                i = numerosIngresados.Text.Length;
            }
            if (numerosIngresados.Text == "")
            {
                numerosIngresados.Text = numberletter;
            }
            else
            {
                numerosIngresados.Text = numerosIngresados.Text + numberletter;
            }
        }
        private void default0()
        {
            memoryOperationControl();
            if (numerosIngresados.Text == "0")
            {
                numerosIngresados.Text = "";
            }
        }
        #endregion

        public Operaciones()
        {
            InitializeComponent();
        }

        #region botones de escritura del panel
        private void cero_Click(object sender, EventArgs e)
        {
            default0();
            write("0");
        }

        private void uno_Click(object sender, EventArgs e)
        {
            default0();
            write("1");
        }

        private void dos_Click(object sender, EventArgs e)
        {
            default0();
            write("2");
        }

        private void tres_Click(object sender, EventArgs e)
        {
            default0();
            write("3");
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            default0();
            write("4");
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            default0();
            write("5");
        }

        private void seis_Click(object sender, EventArgs e)
        {
            default0();
            write("6");
        }

        private void siete_Click(object sender, EventArgs e)
        {
            default0();
            write("7");
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            default0();
            write("8");
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            default0();
            write("9");
        }

        private void diez_Click(object sender, EventArgs e)
        {
            default0();
            write("A");
        }

        private void once_Click(object sender, EventArgs e)
        {
            default0();
            write("B");
        }

        private void doce_Click(object sender, EventArgs e)
        {
            default0();
            write("C");
        }

        private void trece_Click(object sender, EventArgs e)
        {
            default0();
            write("D");
        }

        private void catorce_Click(object sender, EventArgs e)
        {
            default0();
            write("E");
        }

        private void quince_Click(object sender, EventArgs e)
        {
            default0();
            write("F");
        }


        private void borrar_Click(object sender, EventArgs e)
        {
            if (numerosIngresados.Text.Length > 1)
            {
                numerosIngresados.Text = numerosIngresados.Text.Remove(numerosIngresados.Text.Length - 1);
            }
            else
            {
                numerosIngresados.Text = "0";
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 1;
            total = 0;
            i = numerosIngresados.Text.Length;
            aux = 1;
            j = 0;
            aux2 = 1;
            k = 0;
            controldivision = true;
            operacion = "";
            operacion2 = "";
            memoria.Text = "";
            numerosIngresados.Text = "0";
            resulBinario.Text = "0";
            resulOctal.Text = "0";
            resulDecimal.Text = "0";
            resulHexa.Text = "0";
            rBinarioC1.Visible = false;
            rBinarioSM.Visible = false;
            rBinarioC2.Visible = false;
        }

        #endregion


        #region RB sistema num de entrada: Habilitar/Desabilitar botones
        private void rbBin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBin.Checked == false)
            {
                enabled_buttonsBIN();
            }
            else
            {
                disabled_buttonsBIN();
            }
        }

        private void rbOctal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOctal.Checked == false)
            {
                enabled_buttonsOCT();
            }
            else
            {
                disabled_buttonsOCT();
            }
        }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHex.Checked == true)
            {
                enabled_buttonsHEX();
            }
            else
            {
                disabled_buttonsHEX();
            }
        }

        private void Operaciones_Shown(object sender, EventArgs e)
        {
            numerosIngresados.Focus();
            rbDeci.Checked = true;
            disabled_buttonsHEX();
        }
        #endregion


        #region Salida de resultados
        private void numerosIngresados_TextChanged(object sender, EventArgs e)
        {
            clConverter objConverter = new clConverter(numerosIngresados.Text);
            try
            {
                if (rbBin.Checked == true)
                {
                    resulBinario.Text = numerosIngresados.Text;
                    resulOctal.Text = objConverter.BinaryToOctal();
                    resulDecimal.Text = objConverter.BinaryToDecimal();
                    resulHexa.Text = objConverter.BinaryToHexadecimal().ToUpper();
                }
                if (rbOctal.Checked == true)
                {
                    resulBinario.Text = objConverter.OctalToBinary();
                    resulOctal.Text = numerosIngresados.Text;
                    resulDecimal.Text = objConverter.OctalToDecimal();
                    resulHexa.Text = objConverter.OctalToHexadecimal().ToUpper();
                }
                if (rbDeci.Checked == true)
                {
                    resulBinario.Text = objConverter.DecimalToBinary();
                    resulOctal.Text = objConverter.DecimalToOctal();
                    resulDecimal.Text = numerosIngresados.Text;
                    resulHexa.Text = objConverter.DecimalToHexadecimal().ToUpper();
                }
                if (rbHex.Checked == true)
                {
                    resulBinario.Text = objConverter.HexadecimalToBinary();
                    resulOctal.Text = objConverter.HexadecimalToOctal();
                    resulDecimal.Text = objConverter.HexadecimalToDecimal();
                    resulHexa.Text = numerosIngresados.Text;
                }
                if (numerosIngresados.Text == "")
                {
                    numerosIngresados.Text = "0";
                }
            }
            catch
            {

            }
        }
        #endregion

        private void valorEntero1()
        {
            if (rbHex.Checked == true)
            {
                valor1 = double.Parse(resulDecimal.Text);
            }
            else
            {
                clConverter objConverter = new clConverter(Math.Round(double.Parse(numerosIngresados.Text)).ToString());
                if (rbBin.Checked == true)
                {
                    valor1 = double.Parse(objConverter.BinaryToDecimal());
                }
                if (rbOctal.Checked == true)
                {
                    valor1 = double.Parse(objConverter.OctalToDecimal());
                }
                if (rbDeci.Checked == true)
                {
                    valor1 = double.Parse(numerosIngresados.Text);
                }
            }
        }
        private void valorOperacion3()
        {
            if (rbHex.Checked == true)
            {
                valor2 = double.Parse(resulDecimal.Text);
            }
            else
            {
                clConverter objConverter = new clConverter(Math.Round(double.Parse(operacion3)).ToString());
                if (rbBin.Checked == true)
                {
                    valor2 = double.Parse(objConverter.BinaryToDecimal());
                }
                if (rbOctal.Checked == true)
                {
                    valor2 = double.Parse(objConverter.OctalToDecimal());
                }
                if (rbDeci.Checked == true)
                {
                    valor2 = double.Parse(operacion3);
                }
            }
        }

        #region Eventos signos de operación
        private void mas_Click(object sender, EventArgs e)
        {
            i = numerosIngresados.Text.Length;
            sumaORestaOperacin("+");
            aux = 1;
            j = 0;
            aux2 = 1;
            k = 0;
            controldivision = true;
        }

        private void menos_Click(object sender, EventArgs e)
        {
            i = numerosIngresados.Text.Length;
            sumaORestaOperacin("-");
            aux = 1;
            j = 0;
            aux2 = 1;
            k = 0;
            controldivision = true;
        }

        private void por_Click(object sender, EventArgs e)
        {
            i = numerosIngresados.Text.Length;
            valorEntero1();
            toMemory("*");
            controldivision = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            i = numerosIngresados.Text.Length;
            valorEntero1();
            toMemory("/");
        }

        private void memoria_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (memoria.Text.Substring(memoria.Text.Length - 1))
                {
                    case "*":
                        aux *= valor1;
                        controlproducto = true;
                        break;
                    case "/":
                        if (controldivision == true)
                        {
                            aux = valor1;
                            controldivision = false;
                        }
                        else
                        {
                            aux *= Math.Pow(valor1, -1);
                        }
                        controlproducto = true;
                        break;
                }
                operacion3 = memoria.Text.Substring(memoria.Text.Length - (i + 2));
                if (controlproducto == true)
                {
                    j += numerosIngresados.Text.Length + 1;
                }
                label7.Text = j.ToString();
                label8.Text = valor1.ToString();
                label6.Text = aux.ToString();
                if (operacion3.Remove(operacion3.Length - (i + 1)) == "*" && memoria.Text.Substring(memoria.Text.Length - 1) != "*")
                {
                    operacion3 = memoria.Text.Substring(memoria.Text.Length - (i + 1));
                    operacion3 = operacion3.Remove(operacion3.Length - 1);
                    MessageBox.Show("operacion 3 new   " + valor2.ToString());
                    valorOperacion3();
                    aux *= valor2;
                    controlproducto = false;
                }
                if (operacion3.Remove(operacion3.Length - (i + 1)) == "/" && memoria.Text.Substring(memoria.Text.Length - 1) != "/")
                {

                    operacion3 = memoria.Text.Substring(memoria.Text.Length - (i + 1));
                    operacion3 = operacion3.Remove(operacion3.Length - 1);
                    valorOperacion3();
                    aux *= Math.Pow(valor2, -1);
                }
            }
            catch
            {
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            i = numerosIngresados.Text.Length;
            valorEntero1();
            toMemory("=");
            operaciones("=");
        }
        #endregion

        private void rbDeci_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPasarSm_Click(object sender, EventArgs e)
        {
            clConverter objConverter = new clConverter(numerosIngresados.Text);
            rBinarioSM.Text = Regex.Replace(objConverter.SM(numerosIngresados.Text), "(.{4})(?!$)", "$0 ");
            rBinarioC1.Text = Regex.Replace(objConverter.C1(numerosIngresados.Text), "(.{4})(?!$)", "$0 ");
            rBinarioC2.Text = Regex.Replace(objConverter.C2(numerosIngresados.Text), "(.{4})(?!$)", "$0 ");
            rBinarioC1.Visible = true;
            rBinarioSM.Visible = true;
            rBinarioC2.Visible = true;
            unSM.Visible = true;
            unC1.Visible = true;
            unC2.Visible = true;
        }

        private void Operaciones_Load(object sender, EventArgs e)
        {
        }

        private void coma_Click(object sender, EventArgs e)
        {
            write(",");
        }

        #region Operaciones y autoguardado de los datos
        private void operaciones(string simbolo)
        {
            if (simbolo == "+" || simbolo == "-" || simbolo == "=")
            {
                operacion = memoria.Text.Remove(memoria.Text.Length - (i + 1));
                try
                {
                    switch (operacion.Substring(operacion.Length - 1))
                    {
                        case "+":
                            total += valor1;
                            total = Math.Round(total);
                            break;
                        case "-":
                            total -= valor1;
                            total = Math.Round(total);
                            break;
                        case "*":
                            operacion = memoria.Text.Remove(memoria.Text.Length - j);
                            if (operacion.Substring(operacion.Length - 1) == "+")
                            {
                                total += aux;
                                total = Math.Round(total);
                            }
                            else if (operacion.Substring(operacion.Length - 1) == "-")
                            {
                                total -= aux;
                                total = Math.Round(total);
                            }
                            break;
                        case "/":
                            operacion = memoria.Text.Remove(memoria.Text.Length - j);
                            if (operacion.Substring(operacion.Length - 1) == "+")
                            {
                                total += aux;
                                total = Math.Round(total);

                            }
                            else if (operacion.Substring(operacion.Length - 1) == "-")
                            {
                                total -= aux;
                                total = Math.Round(total);
                            }
                            break;
                    }
                }
                catch
                {
                    total += valor1;
                    total = Math.Round(total);
                }
            }
            else
            {

            }
            clConverter objConverter = new clConverter(Math.Round(total).ToString());
            if (rbBin.Checked == true)
            {
                numerosIngresados.Text = objConverter.DecimalToBinary();
            }
            if (rbOctal.Checked == true)
            {
                numerosIngresados.Text = objConverter.DecimalToOctal();
            }
            if (rbDeci.Checked == true)
            {
                numerosIngresados.Text = total.ToString();
            }
            if (rbHex.Checked == true)
            {
                numerosIngresados.Text = objConverter.DecimalToHexadecimal();
                numerosIngresados.Text = numerosIngresados.Text.ToUpper();
            }
        }
        private void sumaORestaOperacin(string signo)
        {
            valorEntero1();
            try
            {
                if (memoria.Text.Substring(memoria.Text.Length - 1) == "=")
                {
                    memoria.Text = memoria.Text.Remove(memoria.Text.Length - 1) + signo;
                }
                else
                {
                    toMemory(signo);
                    operaciones(signo);
                }
            }
            catch
            {
                toMemory(signo);
                operaciones(signo);
            }
        }
        #endregion
    }
}
