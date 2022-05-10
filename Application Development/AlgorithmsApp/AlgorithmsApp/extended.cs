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

            int d, q,r , x, y, x1 = 0, y1 = 1, x2 = 1, y2 = 0;

            if (b == 0)
            {
                d = a;
                x = 1;
                y = 0;
            }

            while(b > 0)
            {
                q = (int)Math.Floor(a / (double)b);
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
;               y2 = y1;
                y1 = y;
            }

            d = a;
            x = x2;
            y = y2;          

            euVysledek = FindViewById<TextView>(Resource.Id.vysledekEXT);
            euVysledek.Text = "NSD = " + d.ToString() + "; x = " + x.ToString() + "; y = " + y.ToString();

        }
    }
}