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
    [Activity(Label = "rmsa")]
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

            int vysledek = a * b + c;

            euVysledek = FindViewById<TextView>(Resource.Id.vysledekRMSA);
            euVysledek.Text = "NSD je " + vysledek.ToString();

        }
    }
}