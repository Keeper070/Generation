using System;
using System.Windows.Forms;

namespace Generation
{
    public class Mathematic
    {
        private readonly Form1 _form1;
        private double[] _arrayM;
        private double[] _arrayP;
        private Random _random;
        
        //Длина последовательности
        private int NumericSequence { get; set; }

        public Mathematic(Form1 form1)
        {
            _form1 = form1;
            _arrayM = new double[100];
            _arrayP = new double[100];
            _random = new Random();
        }
    
        
        public double[] ButtonStart(int numericSequence)
        {
            NumericSequence = numericSequence;
            GenerateArrayM();
            double[] buff = SearchValue();
            return buff;
        }

        //Генерирует массив M
        private void GenerateArrayM()
        {
            int number = 0;
            for (int i = 0; i < NumericSequence ; i++)
            { 
                number = _random.Next(100);
                _arrayM[number]++;
            }
        }
        
        /// <summary>
        /// Метод для нахождения:
        /// 1) Математическое ожидание
        /// 2) Диспресия 
        /// </summary>
        private double[] SearchValue()
        {
            // мат ожидание для дискретной СВ
            double mathExpectationDisk1 = 0;
            double mathExpectedDisk2 = 0;
            //Дисперсия 
            // double disp = 0;
            
            for (int xi = 0; xi < _arrayM.Length; xi++)
            {
                //поиск вероятности
                var pi = _arrayM[xi] / NumericSequence;
                mathExpectationDisk1 += xi * pi;
                mathExpectedDisk2 += xi * xi * pi;
                // disp += Math.Pow(xi - mathExpectationDisk, 2);
            }
            var disp = mathExpectedDisk2 - mathExpectationDisk1 * mathExpectationDisk1;

            return new[] { mathExpectationDisk1, disp };
        }
    }
}