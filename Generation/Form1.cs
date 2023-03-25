using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generation
{
    public partial class Form1 : Form
    {
        private Mathematic _mathematic;
        private bool _choiseGeneration = true;

        public Form1()
        {
            _mathematic = new Mathematic(this);
            InitializeComponent();
        }

      
        private void numericSequence_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _choiseGeneration = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _choiseGeneration = false;
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_choiseGeneration)
            {
                double[] buffArr = _mathematic.ButtonStart((int)numericSequence.Value);
                listView2.Items.Add((listView2.Items.Count + 1 + ") ") + "Mx = " + buffArr[0].ToString("#.###") + "\n" +
                                    " Dx = " + buffArr[1].ToString("#.###"));
             
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _mathematic = new Mathematic(this);
            listView2.Items.Clear();
        }


        
    }
}