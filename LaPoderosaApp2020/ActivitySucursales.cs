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
    [Activity(Label = "ActivitySucursales")]
    public class ActivitySucursales : Activity
    {
        ListView vLista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.sucursales);
            vLista = FindViewById<ListView>(Resource.Id.listView1);

            //Vincular los  datos con el control hscirnfo uso del adaptador

            vLista.Adapter = new AdapterSucursal(this, Global.Sucursales);
            vLista.ItemClick += VLista_ItemClick;
        }

        private void VLista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityDetalleSucursal));
            Sucursal sucursal = Global.Sucursales[e.Position];
            i.PutExtra("id", sucursal.Id);

            StartActivity(i);


        }
    }
}