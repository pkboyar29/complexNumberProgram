using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbersProgram
{
    public class ComplNum
    {
        // действительная и мнимая части комплексного числа
        private double actualPart;
        private double imaginaryPart;
        public double ActualPart
        {
            private set { actualPart = value; }
            get { return actualPart; }
        }
        public double ImaginaryPart
        {
            private set { imaginaryPart = value; }
            get { return imaginaryPart; }
        }

        // количество созданных комплексных чисел в программе
        private static int count;

        /// <summary>
        /// Метод, возвращающий модуль комплексного числа
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static public double ReturnModule(ComplNum num)
        {
            return Math.Sqrt(Math.Pow(num.actualPart, 2) + Math.Pow(num.imaginaryPart, 2));
        }

        /// <summary>
        /// возвращаем 2 => 1-е число больше 2-го; возвращаем 1 => числа равны; возвращаем 0 => числа не равны
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static public int CompareNums(ComplNum num1, ComplNum num2)
        {
            if (ReturnModule(num1) > ReturnModule(num2)) return 2;
            else if (ReturnModule(num1) == ReturnModule(num2)) return 1;
            else return 0;
        }

/*        private void CheckNums(double actualP, double imaginaryP)
        {
            if (actualP == double.PositiveInfinity || actualP == double.NegativeInfinity || double.IsNaN(actualP))
            {
                throw new Exception("Действильная часть неверна");
            }
            if (imaginaryP == double.PositiveInfinity || imaginaryP == double.NegativeInfinity || double.IsNaN(imaginaryP))
            {
                throw new Exception("Мнимая часть неверна");
            }
        }
*/
        /// <summary>
        /// запись базовых значений для действительной и мнимой части
        /// </summary>
        public ComplNum()
        {
            ActualPart = 5;
            ImaginaryPart = 5;
            //CheckNums(ActualPart, ImaginaryPart);
            count++;
        }

        /// <summary>
        /// только мнимая часть
        /// </summary>
        /// <param name="imaginaryPart">мнимая часть</param>
        public ComplNum(double imaginaryPart) : this()
        {
            ActualPart = 0;
            ImaginaryPart = imaginaryPart;
            //CheckNums(ActualPart, ImaginaryPart);
        }

        /// <summary>
        /// задание значений мнимой и действительной частей для комплексного числа
        /// </summary>
        /// <param name="actualPart">действительная часть</param>
        /// <param name="imaginaryPart">мнимая часть</param>
        public ComplNum(double actualPart, double imaginaryPart) : this()
        {
            ActualPart = actualPart;
            ImaginaryPart = imaginaryPart;
            //CheckNums(ActualPart, ImaginaryPart);
        }

        /// <summary>
        /// Перегрузка оператора + для корректной работы этого оператора с комплексными числами
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ComplNum operator +(ComplNum num1, ComplNum num2)
        {
            ComplNum result = new ComplNum();
            result.ActualPart = num1.ActualPart + num2.ActualPart;
            result.ImaginaryPart = num1.ImaginaryPart + num2.ImaginaryPart;
            return result;
        }
        public static ComplNum operator +(ComplNum num1, int num2)
        {
            num1.ActualPart = num1.ActualPart + num2;
            return num1;
        }
        public static ComplNum operator +(int num1, ComplNum num2)
        {
            num2.ActualPart = num2.ActualPart + num1;
            return num2;
        }

        /// <summary>
        /// Перегрузка оператора - для корректной работы этого оператора с комплексными числами
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ComplNum operator -(ComplNum num1, ComplNum num2)
        {
            ComplNum result = new ComplNum();
            result.ActualPart = num1.ActualPart - num2.ActualPart;
            result.ImaginaryPart = num1.ImaginaryPart - num2.ImaginaryPart;
            return result;
        }
        public static ComplNum operator -(ComplNum num1, int num2)
        {
            num1.ActualPart = num1.ActualPart - num2;
            return num1;
        }

        /// <summary>
        /// Перегрузка метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string op = "+";
            if (ImaginaryPart < 0) op = "";
            string result = ActualPart + op + ImaginaryPart + "i";
            return result;
        }
    }
}
