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
        
        private int NumericSequence { get; set; }

        public Mathematic(Form1 form1)
        {
            _form1 = form1;
            _arrayM = new double[100];
            _arrayP = new double[100];
        }

        public double[] buttonStart(int numericSequence)
        {
            NumericSequence = numericSequence;
        }

        private void GenerateArrayM()
        {
            for (int i = 0; i < NumericSequence ; i++)
            {
                var number = _random.Next(100);
                _arrayM[number]++;
            }
        }
    }
}