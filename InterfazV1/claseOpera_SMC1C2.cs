using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazV1
{
    class claseOpera_SMC1C2
    {
        string A, B;
        long[] bina1 = new long[33];
        long[] bina2 = new long[33];
        
        public claseOpera_SMC1C2(string auxA, string auxB)
        {
            this.A = auxA;
            this.B = auxB;
        }

        public string sumabinaria(string vA,string vB)
        {
            long nA = long.Parse(vA);
            //string numNormalDecimal1 = Convert.ToString(nA, 10);
            //string numBinario1 = Convert.ToString(nA, 2);
            separarDigitos1(nA);

            long nB = long.Parse(vB);
            //string numNormalDecimal2 = Convert.ToString(nB, 10);
            //string numBinario = Convert.ToString(nB, 2);
            separarDigitos2(nB);

            int bits;
            if (nA >= nB)
            {
                bits=cantidadBits(int.Parse(A));
            }
            else
            {
                bits=cantidadBits(int.Parse(B));
            }
            long[] res = new long[bits];

            int i = 32, j = bits - 1;
            long aux,acarreo=0;
            while (j >= 0)
            {
                aux = bina1[i] + bina2[i]+acarreo;
                acarreo = 0;
                if (aux == 2)
                {
                    aux = 0;
                    acarreo = 1;
                    //bina1[i - 1] += 1;
                }
                else if (aux == 3)
                {
                    aux = 1;
                    acarreo = 1;
                    //bina1[i - 1] += 1;
                }
                res[j] = aux;
                aux = 0;
                j--;
                i--;

            }
            /*if (numerosMolestos(long.Parse(A)) == true||numerosMolestos(long.Parse(B))==true)
            {
                int cont = 1;
                while (res[cont] == 1)
                {
                    res[cont] = 0;
                    cont++;
                }
            }*/
                //pasar vector a string
                string ress ="1"+ String.Join("", res.Select(p => p.ToString()).ToArray());
            return ress;
        }


        public void separarDigitos1(long num)
        {
            int cont = 32;
            while (num > 0)
            {
                bina1[cont] = num % 10;
                cont--;
                num = num / 10;
                //sacar de aqui
                if (num == 0)
                {
                    for (int i = cont; i >= 0; i--)
                    {
                        bina1[cont] = 0;
                    }

                }
            }
        }
        public void separarDigitos2(long num)
        {
            int cont = 32;
            while (num > 0)
            {
                bina2[cont] = num % 10;
                cont--;
                num = num / 10;
                //sacar de aqui
                if (num == 0)
                {
                    for (int i = cont; i >= 0; i--)
                    {
                        bina2[cont] = 0;
                    }

                }
            }
        }

        public int cantidadBits(long numero)
        {
            int limiteBits;
            if (numero > -8 && numero < 8) { limiteBits = 4; }
            else if (numero > -128 && numero < 128) { limiteBits = 8; }
            else if (numero > -32768 && numero < 32768) { limiteBits = 16; }
            else if (numero > -2147483648 && numero < 2147483648) { limiteBits = 32; }
            else { limiteBits = 0; }
            return limiteBits;
        }

        public bool numerosMolestos(long num)
        {
            bool res = false;

            for (int i = 0; i < 32; i++)
            {
                if (num == Math.Pow(2, i)-1)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

    }
}
