using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    internal class Task3 : IEvaluate
    {

        public int NumOfVariant { get; set; }

        public int ParamValue { get; set; }

        public void Invoke_Variant(int numOfVariant, int paramValueDefault)
        {
            NumOfVariant = numOfVariant;
            ParamValue = paramValueDefault;
        }
        public string Execute_Variant()
        {
            double sum = 0;
            for (int i = 0; i < ParamValue; i++)
            {
                sum += 1 / (Math.Pow(2, i));
            }
            double error = Math.Abs(sum - ParamValue) / (ParamValue * 100);

            string str = String.Format("Результат расчета текущего значения: {0:0.0000}\nТочное значение составляет { 1:0.0000}\nПогрешность расчетов: { 2:0.00}% ",  sum, 2, error);
            return str;
        }
    }
}
