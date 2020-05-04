using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LaPoderosaApp2020
{
    [Activity(Label = "ActivityDetalleSucursal")]
    public class ActivityDetalleSucursal : Activity
    {

        int id;
        Sucursal sucursal;
        TextView txtnombre, txtdireccion;
        Button btnllamar, btnubicar;
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.detallesucursal);

            //recuperamos el id
            id = Intent.GetIntExtra("id", 0);
             sucursal = Global.Sucursales.Where(x => x.Id == id).FirstOrDefault();
            //vinculamos las variables con los controles
            txtnombre = FindViewById<TextView>(Resource.Id.textView1);
            txtdireccion = FindViewById<TextView>(Resource.Id.textView2);


            btnllamar= FindViewById<Button>(Resource.Id.button1);
            btnubicar = FindViewById<Button>(Resource.Id.button2);

            //Programamos el evento click

            btnllamar.Click += Btnllamar_Click;
            btnubicar.Click += Btnubicar_Click;

            txtnombre.Text = sucursal.Responsable;
            txtdireccion.Text = sucursal.Departamento + " " + sucursal.Direccion;

            btnllamar.Text = " LLamar " + sucursal.Telefono;
            btnubicar.Text = "Ubicar en el mapa: " + sucursal.Coordenadas;





        }

        private void Btnubicar_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("geo:" + sucursal.Coordenadas);
            Intent i = new Intent(Intent.ActionView, uri);
            StartActivity(i);

        }

        private void Btnllamar_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("tel:" + sucursal.Telefono);
            Intent i = new Intent(Intent.ActionDial, uri);
            StartActivity(i);
        }
    }
}