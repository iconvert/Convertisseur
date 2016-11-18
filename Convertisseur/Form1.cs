using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "1");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox unity = (ComboBox)sender;
            switch (unity.SelectedIndex)
            {
                case 0:
                    List<String> unityList = new List<string>()
                    {
                        "ml",
                        "cl",
                        "dl",
                        "l",
                        "dm3",
                        "m3"
                    };
                    unity1.DataSource = new List<String>(unityList);
                    unity2.DataSource = new List<String>(unityList);

                    break;
                case 1:
                    List<String> unityList1 = new List<string>()
                    {
                        "m/s",
                        "km/h",
                        "mph"
                    };
                    unity1.DataSource = new List<String>(unityList1);
                    unity2.DataSource = new List<String>(unityList1);

                    break;
                case 2:
                    List<String> unityList2 = new List<string>()
                    {
                        "Kelvin",
                        "Celcius",
                        "Fahrenheit"
                    };
                    unity1.DataSource = new List<String>(unityList2);
                    unity2.DataSource = new List<String>(unityList2);

                    break;
                case 3:
                    List<String> unityList3 = new List<string>()
                    {
                        "mm",
                        "cm",
                        "dm",
                        "m",
                        "km"
                    };
                    unity1.DataSource = new List<String>(unityList3);
                    unity2.DataSource = new List<String>(unityList3);

                    break;
                case 4:
                    List<String> unityList4 = new List<string>()
                    {
                        "mg",
                        "g",
                        "kg",
                        "livre",
                    };
                    unity1.DataSource = new List<String>(unityList4);
                    unity2.DataSource = new List<String>(unityList4);
                    break;
            }
            Console.WriteLine("Item changed");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBoxUnity1_TextChanged(object sender, EventArgs e)
        {
            switch (Type_unity.SelectedIndex)
            {
                case 0:
                    convertVol(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                    break;
            }
        }
        public void convertVol(double n, string input, string output)
        {
            double convVersL = 0.0;
            switch (input)
            {
                case "ml":
                    convVersL = n / 1000;
                    break;
                case "cl":
                    convVersL = n / 100;
                    break;
                case "dl":
                    convVersL = n / 10;
                    break;
                case "dm3":
                    convVersL = n*1;
                    break;
                case "m3":
                    convVersL = n * 1000;
                    break;

                   
            }
            switch (output)
            {
                case "ml":
                    textBoxUnity2.Text = ((convVersL * 1000).ToString());
                    break;
                case "cl":
                    textBoxUnity2.Text = ((convVersL * 100).ToString());
                    break;
                case "dl":
                    convVersL = n / 10;
                    break;
                case "dm3":
                    convVersL = n * 1;
                    break;
                case "m3":
                    convVersL = n * 1000;
                    break;


            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = "";
        }
    }
}
