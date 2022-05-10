using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;


namespace AlgorithmsApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Spinner spinner;
        private Button btnsubmit;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            FillSpinner();
            addAction();
            
        }

        
        public void FillSpinner()
        {
            spinner = FindViewById<Spinner>(Resource.Id.spinner1);
            //spinner.ItemSelected += new System.EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemsSelected);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.algos, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
        }
        private void spinner_ItemsSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = sender as Spinner;
            //string toast = string.Format("Selected Item is {0}", spinner.GetItemAtPosition(e.Position));
            //Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
        private void addAction()
        {
            btnsubmit = FindViewById<Button>(Resource.Id.button1);
            btnsubmit.Click += btnsubmit_CLick;
        }
        public void btnsubmit_CLick(object sender, EventArgs e)
        {
            //Toast.MakeText(this, "OnClickListener " + "\n DropDown: " + spinner.SelectedItem, ToastLength.Short).Show();

            switch(spinner.SelectedItem.ToString())
            {
                case "Euklides":
                    SetContentView(Resource.Layout.euklides);
                    Intent intent = new Intent(this, typeof(euklid));
                    StartActivity(intent);
                    break;
                case "Euklides Rozsireny":
                    SetContentView(Resource.Layout.extended);
                    Intent intent2 = new Intent(this, typeof(extended));
                    StartActivity(intent2);
                    break;
                case "RMSA":
                    SetContentView(Resource.Layout.rmsa);
                    Intent intent3 = new Intent(this, typeof(rmsa));
                    StartActivity(intent3);
                    break;
                default:
                    Toast.MakeText(this, "Neni nic vybrano!", ToastLength.Long).Show();
                    break;
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}