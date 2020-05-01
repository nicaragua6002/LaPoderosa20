using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace LaPoderosaApp2020
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //Declaramos las variables que van a manipular a los controles
        Button btninicio, btnhistoria, btnmision;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.menumetro);
            //Vincular las variables con sus respectivos controles
            btninicio = FindViewById<Button>(Resource.Id.button1);
            btnhistoria = FindViewById<Button>(Resource.Id.button2);
            btnmision = FindViewById<Button>(Resource.Id.button3);

            //Establecer el evento
            btninicio.Click += Btninicio_Click;
            btnhistoria.Click += Btnhistoria_Click;
            btnmision.Click += Btnmision_Click;    




        }

        private void Btnmision_Click(object sender, System.EventArgs e)
        {
            //Programar el llamado de la siguiente actividad
            Intent i = new Intent(this, typeof(ActivityMision));
            StartActivity(i);
        }

        private void Btnhistoria_Click(object sender, System.EventArgs e)
        {
            //Programar el llamado de la siguiente actividad
            Intent i = new Intent(this, typeof(ActivityHistoria));
            StartActivity(i);
        }

        private void Btninicio_Click(object sender, System.EventArgs e)
        {
            //Programar el llamado de la siguiente actividad
            Intent i = new Intent(this, typeof(ActivityInicio));
            StartActivity(i);
        }
    }
}