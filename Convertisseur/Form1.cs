﻿using System;
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
        private CurrentRatesDataContext ctx;

        public Form1()
        {
            InitializeComponent();
            this.ctx = new CurrentRatesDataContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            // bonton 1 ecrit dans la textbox 1 
            textBoxUnity1.Text = (textBoxUnity1.Text + "1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        // fonction qui permet de convertir des que la textbox change sauf si elle est vide des que l'unité d'entrée change 
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUnity1.Text))
            {
                // appel des fonction de conversion suivant le type d'unité choisi
                switch (Type_unity.SelectedIndex)
                {
                    case 0:
                        convertVol(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 1:
                        convertSpeed(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 2:
                        convertTemp(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 3:
                        convertLong(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 4:
                        convertPoids(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 5:
                        convertDevise(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // des que l'on change d'element dans la combobox des types d'unités on met la collection correspondante dans les combobox de selection d'untité
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
                        "km",
                        "pouce",
                        "pied",
                        "mile"
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
                        "once",
                        "livre",
                    };
                    unity1.DataSource = new List<String>(unityList4);
                    unity2.DataSource = new List<String>(unityList4);
                    break;
                case 5:
                    List<String> unityList5 = new List<string>()
                    {
                        "Euro",
                        "Dollar",
                        "Livre sterling",
                        "Yen",
                        "Dollar Canadien",
                        "Yuan",
                        "Couronne"
                    };
                    unity1.DataSource = new List<String>(unityList5);
                    unity2.DataSource = new List<String>(unityList5);
                    break;


            }

            //Console.WriteLine("Item changed");
        }
        // pour convertir la textbox en cliquant sur l'image de conversion, en cas de changement d'untié sans changé la valeur dans la textbox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUnity1.Text))
            {
                // appel des fonction de conversion suivant le type d'unité choisi
                switch (Type_unity.SelectedIndex)
                {
                    case 0:
                        convertVol(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 1:
                        convertSpeed(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 2:
                        convertTemp(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 3:
                        convertLong(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 4:
                        convertPoids(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 5:
                        convertDevise(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                }
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        // fonction qui permet de convertir des que la textbox change sauf si elle est vide des que le text change 
        private void textBoxUnity1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUnity1.Text))
            {
                // appel des fonction de conversion suivant le type d'unité choisi

                switch (Type_unity.SelectedIndex)
                {
                    case 0:
                        convertVol(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 1:
                        convertSpeed(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 2:
                        convertTemp(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 3:
                        convertLong(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 4:
                        convertPoids(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 5:
                        convertDevise(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                }
            }
        }

        // les differentes fonction pour convertir. Pour eviter le nombre de possiblité on passe à chaque fois par une unité de reférence puis on reconvertit.
        public void convertVol(double n, string input, string output)
        {
            double convVersL = 0.0; // convert vers litre sde l'unité selectionné
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
                case "l":
                    convVersL = n * 1;
                    break;
                case "dm3":
                    convVersL = n*1;
                    break;
                case "m3":
                    convVersL = n * 1000;
                    break;

                   
            }
            switch (output) // Puis pour la sortie de litre vers la deuxieme unité
            {
                case "ml":
                    textBoxUnity2.Text = ((convVersL * 1000).ToString());
                    break;
                case "cl":
                    textBoxUnity2.Text = ((convVersL * 100).ToString());
                    break;
                case "dl":
                    textBoxUnity2.Text = ((convVersL * 10).ToString());
                    break;
                case "dm3":
                    textBoxUnity2.Text = ((convVersL * 1).ToString());
                    break;
                case "l":
                    textBoxUnity2.Text = ((convVersL * 1).ToString());
                    break;
                case "m3":
                    textBoxUnity2.Text = ((convVersL / 1000).ToString());
                    break;


            }
        }

        public void convertSpeed(double n, string input, string output)
        {
            double convVersMs = 0.0; // même pricipe avec m/s.
            switch (input)
            {
                case "m/s":
                    convVersMs = n / 1;
                    break;
                case "km/h":
                    convVersMs = n / 3.6 ;
                    break;
                case "mph":
                    convVersMs = n / 2.237136;
                    break;

            }
            switch (output) // m/s vers unité de sortie
            {
                case "m/s":
                    textBoxUnity2.Text = ((convVersMs * 1).ToString());
                    break;
                case "km/h":
                    textBoxUnity2.Text = ((convVersMs * 3.6).ToString());
                    break;
                case "mph":
                    textBoxUnity2.Text = ((convVersMs * 2.237136).ToString());
                    break;
            }
        }

        public void convertTemp(double n, string input, string output)
        {
            double convVersC = 0.0; // convert vers Celcius 
            switch (input)
            {
                case "Celcius":
                    convVersC = n ;
                    break;
                case "Kelvin":
                    convVersC = n - 273.15;
                    break;
                case "Fahrenheit":
                    convVersC = (n - 32)/ 1.8;
                    break;

            }
            switch (output) // Celcius vers unité de sortie
            {
                case "Celcius":
                    textBoxUnity2.Text = ((convVersC ).ToString());
                    break;
                case "Kelvin":
                    textBoxUnity2.Text = ((convVersC + 273.15).ToString());
                    break;
                case "Fahrenheit":
                    textBoxUnity2.Text = (((convVersC * 1.8) + 32).ToString());
                    break;
            }
        }

        public void convertLong(double n, string input, string output)
        {
            double convVersM = 0.0;// convert vers metre 
            switch (input)
            {
                case "mm":
                    convVersM = n / 1000;
                    break;
                case "cm":
                    convVersM = n / 100;
                    break;
                case "dm":
                    convVersM = n / 10;
                    break;
                case "m":
                    convVersM = n * 1;
                    break;
                case "km":
                    convVersM = n * 1000;
                    break;
                case "pouce":
                    convVersM = n * 0.0254;
                    break;
                case "pied":
                    convVersM = n * 0.3048;
                    break;
                case "mile":
                    convVersM = n * 1609.344;
                    break;


            }
            switch (output) // metre vers la sortie
            {
                case "mm":
                    textBoxUnity2.Text = ((convVersM * 1000).ToString());
                    break;
                case "cm":
                    textBoxUnity2.Text = ((convVersM * 100).ToString());
                    break;
                case "dm":
                    textBoxUnity2.Text = ((convVersM * 10).ToString());
                    break;
                case "m":
                    textBoxUnity2.Text = ((convVersM * 1).ToString());
                    break;
                case "km":
                    textBoxUnity2.Text = ((convVersM * 1000).ToString());
                    break;
                case "pouce":
                    textBoxUnity2.Text = ((convVersM / 0.0254).ToString());
                    break;
                case "pied":
                    textBoxUnity2.Text = ((convVersM / 0.3048).ToString());
                    break;
                case "mile":
                    textBoxUnity2.Text = ((convVersM / 1609.344).ToString());
                    break;



            }
        }
        public void convertPoids(double n, string input, string output)
        {
            double convVersG = 0.0; // convert vers gramme
            switch (input)
            {
                case "mg":
                    convVersG = n / 1000;
                    break;
                case "g":
                    convVersG = n ;
                    break;
                case "kg":
                    convVersG = n *1000;
                    break;
                case "once":
                    convVersG = n * 28.34952;
                    break;
                case "livre":
                    convVersG = n * 453.5924;
                    break;


            }
            switch (output) // puis de gramme vers la sortie
            {
                case "mg":
                    textBoxUnity2.Text = ((convVersG * 1000).ToString());
                    break;
                case "g":
                    textBoxUnity2.Text = ((convVersG ).ToString());
                    break;
                case "kg":
                    textBoxUnity2.Text = ((convVersG / 1000).ToString());
                    break;
                case "once":
                    textBoxUnity2.Text = ((convVersG / 28.34952).ToString());
                    break;
                case "livre":
                    textBoxUnity2.Text = ((convVersG / 453.5924).ToString());
                    break;

            }
        }

        public void convertDevise(double n, string input, string output)
        {
                        
            double convertVersEuro = 0.0; // convert vers euro
            switch (input)
            {
                case "Euro":
                    convertVersEuro = n ;
                    break;
                case "Dollar":
                    Rates rate = ctx.Rates.FirstOrDefault(r => r.Name == "USD"); //Cherche en BDD la ligne ayant le nom égal à "Dollar" 
                    
                        double taux = rate.Value; //On récupère le taux
                        convertVersEuro = n / taux; //On convertit
                   

                    break;
                case "Livre sterling":
                    Rates rate1 = ctx.Rates.FirstOrDefault(r => r.Name == "GBP"); //Cherche en BDD la ligne ayant le nom égal à "Livre sterling" 
                    
                        double taux1 = rate1.Value; //On récupère le taux
                        convertVersEuro = n / taux1; //On convertit
                    
                    break;

                case "Yen":
                    Rates rate2 = ctx.Rates.FirstOrDefault(r => r.Name == "JPY"); //Cherche en BDD la ligne ayant le nom égal à "Yen" 
                    
                        double taux2 = rate2.Value; //On récupère le taux
                        convertVersEuro = n / taux2; //On convertit
                    
                    break;

                case "Dollar Canadien":
                    Rates rate3= ctx.Rates.FirstOrDefault(r => r.Name == "CAD"); //Cherche en BDD la ligne ayant le nom égal à "Dollar Canadien" 
                   
                        double taux3 = rate3.Value; //On récupère le taux
                        convertVersEuro = n / taux3; //On convertit
                    
                    break;

                case "Yuan":
                    Rates rate4 = ctx.Rates.FirstOrDefault(r => r.Name == "CNY"); //Cherche en BDD la ligne ayant le nom égal à "Yuan" 
                   
                        double taux4 = rate4.Value; //On récupère le taux
                        convertVersEuro = n / taux4; //On convertit
                    
                    break;

                case "Couronne":
                    Rates rate5 = ctx.Rates.FirstOrDefault(r => r.Name == "SEK"); //Cherche en BDD la ligne ayant le nom égal à "Couronne" 
                   
                        double taux5 = rate5.Value; //On récupère le taux
                        convertVersEuro = n / taux5; //On convertit
                    
                    break;


            }
            switch (output) // EURO vers unité de sortie
            {
                case "Euro":
                    textBoxUnity2.Text = ((convertVersEuro).ToString());
                    break;

                case "Dollar":
                    Rates rate = ctx.Rates.FirstOrDefault(r => r.Name == "USD"); //Cherche en BDD la ligne ayant le nom égal à "DOllar" 
                    
                        double taux = rate.Value; //On récupère le taux
                        
                    
                    textBoxUnity2.Text = ((convertVersEuro* taux).ToString());
                    break;

                case "Livre sterling":
                    Rates rate1 = ctx.Rates.FirstOrDefault(r => r.Name == "GBP"); //Cherche en BDD la ligne ayant le nom égal à "euro" : [ "euro" | taux | date ]
                   
                        double taux1 = rate1.Value; //On récupère le taux
                        
                    
                    textBoxUnity2.Text = ((convertVersEuro* taux1).ToString());
                    break;

                case "Yen":
                    Rates rate2 = ctx.Rates.FirstOrDefault(r => r.Name == "JPY"); //Cherche en BDD la ligne ayant le nom égal à "Yen" 
                    
                        double taux2 = rate2.Value; //On récupère le taux
                        
                    
                    textBoxUnity2.Text = ((convertVersEuro* taux2).ToString());
                    break;

                case "Dollar Canadien":
                    Rates rate3 = ctx.Rates.FirstOrDefault(r => r.Name == "CAD"); //Cherche en BDD la ligne ayant le nom égal à "Dollar Canadien" 
                    
                        double taux3 = rate3.Value; //On récupère le taux
                        
                    
                    textBoxUnity2.Text = ((convertVersEuro* taux3).ToString());
                    break;

                case "Yuan":
                    Rates rate4 = ctx.Rates.FirstOrDefault(r => r.Name == "CNY"); //Cherche en BDD la ligne ayant le nom égal à "Yuan" 
                    
                        double taux4 = rate4.Value; //On récupère le taux
                        
                    
                    textBoxUnity2.Text = ((convertVersEuro* taux4).ToString());
                    break;

                case "Couronne":
                    Rates rate5 = ctx.Rates.FirstOrDefault(r => r.Name == "SEK"); //Cherche en BDD la ligne ayant le nom égal à "Couronne" 
                   
                        double taux5 = rate5.Value; //On récupère le taux
                     
                   
                    textBoxUnity2.Text = ((convertVersEuro* taux5).ToString());
                    break;
            }

        }

        // ici il y a toutes les touches du clavier avec la touche CE qui efface les deux textboxs
        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = "";
            textBoxUnity2.Text = "";
        }

        private void btnChiffre2_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "2");
        }

        private void btnChiffre3_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "3");
        }

        private void btnChiffre4_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "4");
        }

        private void btnChiffre5_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "5");
        }

        private void btnChiffre6_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "6");
        }

        private void btnChiffre7_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "7");
        }

        private void btnChiffre8_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "8");
        }

        private void btnChiffre9_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "9");
        }

        private void btnChiffre0_Click(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + "0");
        }

        private void btnPoint(object sender, EventArgs e)
        {
            textBoxUnity1.Text = (textBoxUnity1.Text + ",");
        }

        // fonction qui permet de convertir des que la textbox change sauf si elle est vide des que l'unité sortie change 

        private void unity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUnity1.Text))
            {
                // appel des fonction de conversion suivant le type d'unité choisi
                switch (Type_unity.SelectedIndex)
                {
                    case 0:
                        convertVol(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 1:
                        convertSpeed(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 2:
                        convertTemp(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 3:
                        convertLong(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 4:
                        convertPoids(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                    case 5:
                        convertDevise(Convert.ToDouble(textBoxUnity1.Text), unity1.Text, unity2.Text);
                        break;
                }
            }
        }
    }
}
