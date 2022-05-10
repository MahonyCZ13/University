using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AlgorithmsApp.Models;
using AlgorithmsApp.Data;


namespace AlgorithmsApp
{
    [Activity(Label = "euklid")]
    public class euklid : AppCompatActivity
    {
        private Button btnVypocet;
        private TextView cisloA;
        private TextView cisloB;
        private TextView euVysledek;
        //static HistorieDB database;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.euklides);
            
            Vypocti();
            
        }

        //public static HistorieDB Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new HistorieDB(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "historie.db3"));
        //        }
        //        return database;
        //    }
        //}
        private void Vypocti()
        {
            btnVypocet = FindViewById<Button>(Resource.Id.vypocet);
            btnVypocet.Click += EukliduvAlgo;

        }
        public void EukliduvAlgo(object sender, EventArgs e)
        {
            cisloA = FindViewById<TextView>(Resource.Id.cisloA);
            int a = Convert.ToInt32(cisloA.Text);
            cisloB = FindViewById<TextView>(Resource.Id.cisloB);
            int b = Convert.ToInt32(cisloB.Text);
            int c = 1;

            while(c != 0)
            {
                c = a % b;
                a = b - c;

                if(c == 0)
                {
                    c = b;
                    break;
                }
                else
                {
                    b = c;
                }
            }

            int vysledek = b;

            euVysledek = FindViewById<TextView>(Resource.Id.vysledek);
            euVysledek.Text = "NSD = " + vysledek.ToString();

            //Model hist = new Model();

            //hist.DateTime = DateTime.Now;
            //hist.vysledek = vysledek;
            //database.SaveHistory(hist);

        }
    }
}