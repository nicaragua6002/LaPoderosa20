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
    [Activity(Label = "ActivityListaCategorias")]
    public class ActivityListaCategorias : Activity
    {
        //Declaramos una variable para vincularla con el ListView
        ListView vLista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListaCategorias);

            vLista = FindViewById<ListView>(Resource.Id.listView1);
            //Vinculamos la lista con el control Listview usando el adaptador creado
            vLista.Adapter = new AdapterCategorias(this, Global.Categorias);

            //Agregamos el evento itemclik, permite determinar que opcion selecciono el usuario
            vLista.ItemClick += VLista_ItemClick;
        }

        private void VLista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityDetalleCategoria));
            //Obtenemos el id de la categoria seleccionada y lo pasamos 
            //como parametro al siguiente activity

            Categoria Cat = Global.Categorias[e.Position];
            i.PutExtra("id", Cat.Id);
            StartActivity(i);
        }
    }
}