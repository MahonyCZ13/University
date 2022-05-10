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
    [Activity(Label = "extended")]
    public class extended : AppCompatActivity
    {
        private Button btnVypocet;
        private TextView cisloA;
        private TextView cisloB;
        private TextView euVysledek;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.extended);
            Vypocti();
            
        }
        private void Vypocti()
        {
            btnVypocet = FindViewById<Button>(Resource.Id.vypocitejEXT);
            btnVypocet.Click += EukliduvExtAlgo;

        }
        public void EukliduvExtAlgo(object sender, EventArgs e)
        {
            cisloA = FindViewById<TextView>(Resource.Id.cisloAEXT);
            int a = Convert.ToInt32(cisloA.Text);
            cisloB = FindViewById<TextView>(Resource.Id.cisloBEXT);
            int b = Convert.ToInt32(cisloB.Text);

            int vysledek = a * b;

            euVysledek = FindViewById<TextView>(Resource.Id.vysledekEXT);
            euVysledek.Text = "NSD je " + vysledek.ToString();

        }
    }
}