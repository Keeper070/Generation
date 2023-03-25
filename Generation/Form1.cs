using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Generation
{
    public partial class Form1 : Form
    {
        private enum RandomTypeEnum
        {
            Лемер, Встроенный
        }
        private Mathematic _mathematic;
        private bool _choiseGeneration = true;
        private bool _choiseGeneratorLemer = false;
        private RandomTypeEnum _type;

        public Form1()
        {
            InitializeComponent();
            _mathematic = new Mathematic(this);
            this.chart1.Palette = ChartColorPalette.Bright;
            this.chart1.Titles.Add("f(x)");
            this.chart1.Series.RemoveAt(0);
            this.chart2.Palette = ChartColorPalette.Bright;
            this.chart2.Titles.Add("F(x)");
            this.chart2.Series.RemoveAt(0);
        }

      
        private void numericSequence_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _choiseGeneration = true;
            _type = RandomTypeEnum.Встроенный;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _choiseGeneration = false;
            _choiseGeneratorLemer = true;
            _type = RandomTypeEnum.Лемер;
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_choiseGeneration)
            {
                double[] buffArr = _mathematic.ButtonStart((int)numericSequence.Value);
                listView2.Items.Add((listView2.Items.Count + 1 + ") ") + "Mx = " + buffArr[0].ToString("#.###") + "\n" +
                                    " Dx = " + buffArr[1].ToString("#.###"));
                // Series series1=this.chart1.Series.Add(listView1.Items.Count.ToString() + " - " + numericSequence.Value + " - " + type);
                // Series series2 = this.chart2.Series.Add(listView1.Items.Count.ToString() + " - " + numericSequence.Value + " - " + type);
                // series2.ChartType = SeriesChartType.Line;
                // for (int i = 0; i < 100; i++)
                // {
                //     series1.Points.Add(_mathematic.ar);
                //     series2.Points.AddXY(i + 1, mathObject.arrP[i]);
                //     series2.Points.AddXY(i + 2, mathObject.arrP[i]);
                // }
            }
            else if (_choiseGeneratorLemer)
            {
                
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _mathematic = new Mathematic(this);
            listView2.Items.Clear();
        }


        
    }
}