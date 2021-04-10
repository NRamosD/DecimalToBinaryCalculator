using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazV1
{
    class clOperacionesEntrada
    {
        string expression, expressionToConvert;
        int contNewExpressionStarts;
        bool caseOp;
        double aumento, number = 0;
        public clOperacionesEntrada(string expression, double valor, int cantAumentoCaracter, bool caseOp)
        {
            this.expression = expression;
            this.contNewExpressionStarts = cantAumentoCaracter;
            this.caseOp = caseOp;
            this.aumento = valor;
        }

        public double SumaOperacion()
        {
            if (this.caseOp == true)
            {
                number = double.Parse(this.expression);
                return (this.aumento + this.number);
            }
            else
            {
                this.expressionToConvert = this.expression.Substring(this.expression.Length - this.contNewExpressionStarts);
                this.number = double.Parse(this.expressionToConvert);
                return (this.aumento + this.number);
            }
        }
        public double RestaOperacion()
        {
            if (this.caseOp == true)
            {
                this.number = double.Parse(this.expression);
                return (this.aumento - this.number);
            }
            else
            {
                this.expressionToConvert = this.expression.Substring(this.expression.Length - this.contNewExpressionStarts + 1);
                // expressionToConvert = expression.Remove(expression.Length-1);
                this.number = double.Parse(this.expressionToConvert);
                return (this.aumento - this.number);
            }
        }
    }
}
