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

namespace AlgorithmsApp
{
    [Activity(Label = "Modularni umocnovani")]
    public class rmsa : AppCompatActivity
    {
        private Button btnVypocet;
        private TextView cisloA;
        private TextView cisloB;
        private TextView cisloC;
        private TextView euVysledek;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.rmsa);
            Vypocti();
            
        }
        private void Vypocti()
        {
            btnVypocet = FindViewById<Button>(Resource.Id.vypocetRMSA);
            btnVypocet.Click += RMSAAlgo;

        }
        public void RMSAAlgo(object sender, EventArgs e)
        {
            cisloA = FindViewById<TextView>(Resource.Id.CisloRMSA);
            int a = Convert.ToInt32(cisloA.Text);
            cisloB = FindViewById<TextView>(Resource.Id.exponentRMSA);
            int b = Convert.ToInt32(cisloB.Text);
            cisloC = FindViewById<TextView>(Resource.Id.moduloRMSA);
            int c = Convert.ToInt32(cisloC.Text);
            
            double[] binar = ToBinary(b);
            double vysledek = modularExp(binar, a, c) % c;

            euVysledek = FindViewById<TextView>(Resource.Id.vysledekRMSA);
            euVysledek.Text = "RMSA = " + vysledek.ToString();

        }
        public double[] ToBinary(int expo)
        {
            
            double[] pole = new double[8];
            int y = 0;
            int i = 0;
            while(expo >= 1)
            {
                y = expo;
                expo = expo / 2;
                pole[i] = (double)y % 2;
                i++;
            }
            

            return pole;
        }
        public double modularExp(double[] pole, int cislo, double modular)
        {
            double total = 1;
            double b = 1;
            double c = 1;
            int i = 0;
            foreach (int item in pole)
            {
                if (item == 1)
                {
                    if (i == 0) c = 1;

                    b = (Math.Pow(cislo, c) % modular);

                    total *= b;
                }
                else c = Math.Pow(2,i);
              
                i++;
            }

            return total;
        }
    }
}