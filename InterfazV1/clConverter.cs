using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazV1
{
    class clConverter
    {
        string numberIn;
        long[] digitosArray = new long[33];
        long[] digitosArrayBin = new long[33];

        public clConverter(string numberIn)
        {
            this.numberIn = numberIn;
        }

        #region:Conversiones binarias
        public string BinaryToOctal()
        {
            return Convert.ToString(long.Parse(BinaryToDecimal()), 8);
        }
        public string BinaryToDecimal()
        {
            return Convert.ToInt64(this.numberIn, 2).ToString();
        }
        public string BinaryToHexadecimal()
        {
            return Convert.ToString(long.Parse(BinaryToDecimal()), 16);
        }
        #endregion

        #region:Conversiones Octales
        public string OctalToBinary()
        {
            return Convert.ToString(long.Parse(OctalToDecimal()), 2);
        }
        public string OctalToDecimal()
        {
            return Convert.ToInt64(this.numberIn, 8).ToString();
        }
        public string OctalToHexadecimal()
        {
            return Convert.ToString(long.Parse(OctalToDecimal()), 16);
        }
        #endregion

        #region:Conversiones Decimales
        public string DecimalToBinary()
        {
            long number = long.Parse(this.numberIn);
            return Convert.ToString(number, 2);
        }
        public string DecimalToOctal()
        {
            long number = long.Parse(this.numberIn);
            return Convert.ToString(number, 8);
        }
        public string DecimalToHexadecimal()
        {
            long number = long.Parse(this.numberIn);
            return Convert.ToString(number, 16);
        }
        #endregion

        #region:Conversiones Hexadecimales
        public string HexadecimalToBinary()
        {
            return Convert.ToString(long.Parse(HexadecimalToDecimal()), 2);
        }
        public string HexadecimalToDecimal()
        {
            return Convert.ToInt64(this.numberIn, 16).ToString();
        }
        public string HexadecimalToOctal()
        {
            return Convert.ToString(long.Parse(HexadecimalToDecimal()), 8);
        }
        #endregion

        #region:Conversiones SM,C1 y C2
        public string SM(string numerIngresado)
        {
            long auxNum = long.Parse(numerIngresado);
            String numNormalDecimal = Convert.ToString(auxNum, 10);
            String numBinario = Convert.ToString(auxNum, 2);
            int bits = cantidadBits(long.Parse(numNormalDecimal));
            separarDigitos(long.Parse(numBinario));

            long[] digitosArrayRes = new long[bits];

            int i = 32, j = bits - 1;
            while (j > 0)
            {

                digitosArrayRes[j] = digitosArray[i];
                if (auxNum<0 && j==1)
                {
                    digitosArrayRes[j] = 1;
                }
                j--;
                i--;

            }

            string resultado = String.Join("", digitosArrayRes.Select(p => p.ToString()).ToArray());

            return resultado;
        }
        public string C1(string numerIngresado)
        {
            long auxNum = long.Parse(numerIngresado);
            String numNormalDecimal = Convert.ToString(auxNum, 10);
            String numBinario = Convert.ToString(auxNum, 2);
            int bits = cantidadBits(long.Parse(numNormalDecimal));
            separarDigitos(long.Parse(numBinario));
            
            int[] digitosArrayRes = new int[bits];
            
            int i = 32, j=bits-1;
            while ( j > 0)
            {
                if (digitosArray[i] == 1)
                {
                    digitosArrayRes[j] = 0;
                }
                if (digitosArray[i] == 0)
                {
                    digitosArrayRes[j] = 1;
                }
                j--;
                i--;

            }
            //pasar vector a string
            string resultado = String.Join("", digitosArrayRes.Select(p => p.ToString()).ToArray());

            return resultado;
        }
        public string C2(string numerIngresado)
        {
            long auxNum = long.Parse(numerIngresado);
            String numNormalDecimal = Convert.ToString(auxNum, 10);
            String numBinario = Convert.ToString(auxNum, 2);
            int bits = cantidadBits(long.Parse(numNormalDecimal));
            separarDigitos(long.Parse(numBinario));

            int[] digitosArrayRes = new int[bits];

            int i = 32, j = bits - 1;
            while (j > 0)
            {
                if (digitosArray[i] == 1)
                {
                    digitosArrayRes[j] = 0;
                }
                if (digitosArray[i] == 0)
                {
                    digitosArrayRes[j] = 1;
                }
                j--;
                i--;

            }
            if (digitosArrayRes[bits-1] == 0)
            {
                digitosArrayRes[bits-1] = 1;
            }
            else
            {
                int cont = bits - 1;
                while (digitosArrayRes[bits - 1] == 1)
                {
                    digitosArrayRes[bits - 1] = 0;
                    cont--;
                    bits--;
                }
                digitosArrayRes[cont] = 1;

                /*if (numerosMolestos(auxNum) == true)
                {
                    int cont = bits - 1;
                    while (digitosArrayRes[bits - 1] == 1)
                    {
                        digitosArrayRes[bits - 1] = 0;
                        cont--;
                        bits--;
                    }
                    digitosArrayRes[cont] = 1;
                }
                else
                {
                    while (digitosArrayRes[bits - 1] == 1)
                    {
                        digitosArrayRes[bits - 1] = 0;
                        if (digitosArrayRes[bits - 2] == 0) { digitosArrayRes[bits - 2] = 1; }
                        bits--;
                    }

                }*/
            }
            
                //pasar vector a string
                string resultado = String.Join("", digitosArrayRes.Select(p => p.ToString()).ToArray());

            return resultado;
        }

        public void separarDigitos(long num)
        {
            int cont = 32;
            while (num > 0)
            {
                digitosArray[cont] = num % 10;
                cont--;
                num = num / 10;
                //sacar de aqui
                if (num == 0)
                {
                    for (int i = cont; i >= 0; i--)
                    {
                        digitosArray[cont] = 0;
                    }

                }
            }
        }
        

        public int cantidadBits( long numero)
        {
            int limiteBits;
            if (numero > -8 && numero < 8) { limiteBits = 4; }
            else if (numero > -128 && numero < 128) { limiteBits = 8; }
            else if (numero > -32768 && numero < 32768) { limiteBits = 16; }
            else if (numero > -2147483648 && numero < 2147483648) { limiteBits = 32; }
            else { limiteBits = 0; }
            return limiteBits;
        }
        
        /*public bool numerosMolestos(long num)
        {
            bool res=false;

            for (int i = 0; i < 32; i++)
            {
                if (num == Math.Pow(2, i))
                {
                    res = true;
                    break;
                }
            }
            

            
            return res;
        }*/

        #endregion
    }
}
