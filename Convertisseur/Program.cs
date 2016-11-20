using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApplication3;

namespace WindowsFormsApplication3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            string result = "";
            string address = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml";
            List<CurrencyType> currencies = new List<CurrencyType>();
            CurrentRatesDataContext ctx = new CurrentRatesDataContext();

            try // faire écriture BDD, reste fonctionnel
            {

                // Requête web
                HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;

                // Réponse  
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {

                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Récupération résultat
                    result = reader.ReadToEnd();
                }

                XDocument doc = XDocument.Parse(result);

                XNamespace ns = "http://www.ecb.int/vocabulary/2002-08-01/eurofxref"; //XML mis à jour à 4h pm CET == 17h France
                currencies = doc.Descendants(ns + "Cube")
                                    .Where(c => c.Attribute("currency") != null)
                                    .Select(c => new CurrencyType
                                    {
                                        Name = (string)c.Attribute("currency"),
                                        Value = (float)c.Attribute("rate"),
                                    })
                                    .ToList();

                foreach (CurrencyType c in currencies) // pour chaque taux, on met à jour la BDD s'il y a internet
                {
                    var query = from rate in ctx.Rates
                                where rate.Name == c.Name
                                select rate;
                    int count = 0;

                    foreach (Rates rate in query)
                    {
                        count++;
                    }
                    if (count != 0) //si le taux existe déjà, on le met à jour dans la BDD
                    {

                        // Mettre à jour le taux
                        foreach (Rates rate in query)
                        {
                            rate.Value = c.Value;
                            rate.Last = DateTime.Now;
                        }

                        try
                        {
                            ctx.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);

                        }
                    }

                    
                    else //Sinon, on crée l'entrée dans la BDD
                    {
                        ctx.Rates.InsertOnSubmit(new Rates()           //insertion des taux
                        {
                            Name = c.Name,
                            Value = c.Value,
                            Last = DateTime.Today,
                        });

                        ctx.SubmitChanges();
                    }
                }

               
                

            }
            catch (WebException e)  // faire la récupération dans la BDD si pas internet
            {
                Console.WriteLine("Il y a un problème avec votre connexion internet" +
                       "\n\nException :" + e.Message);
                foreach (var item in ctx.Rates)
                {
                    Console.WriteLine(string.Format("La monnaie {0} a un taux de change de {1} ", item.Name, item.Value));
                    Console.ReadKey();
                }
            }
        }

    }
}
 
