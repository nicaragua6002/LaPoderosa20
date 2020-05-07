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
    [Activity(Label = "ActivityDetalleCategoria")]
    public class ActivityDetalleCategoria : Activity
    {
        //Variables que se conectan a los controles
        TextView txtnombre, txtcantidad;
        ListView vLista;
        List<Producto> ProductosFiltrados;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DetalleCategoria);

            //vinculamos variables con los controles respectivos

            txtnombre = FindViewById<TextView>(Resource.Id.textView1);

            txtcantidad = FindViewById<TextView>(Resource.Id.textView2);

            vLista = FindViewById<ListView>(Resource.Id.listView1);

            //Recuperamo la categoria seleccionada mediante 
            //el id que se paso como parametro dento del intent
            int id = Intent.GetIntExtra("id", 0);
            Categoria cat = Global.Categorias.Where(x => x.Id == id).FirstOrDefault();

            //Asignamos los valores a los controles

            txtnombre.Text = cat.Nombre;
            //Primero filtramos los productos
            ProductosFiltrados = Global.Productos.Where(x => x.IdCategoria == cat.Id).ToList();
            txtcantidad.Text = ProductosFiltrados.Count().ToString()
                + " Productos";

            vLista.Adapter = new AdapterProductos(this,
                //filtramos la lista de los productos
                ProductosFiltrados);

            //progrmamos el evento itemclick
            vLista.ItemClick += VLista_ItemClick;
        }

        private void VLista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityDetalleProducto));
            //pasamos como parametro el id del producto seleccionado
            int id = ProductosFiltrados[e.Position].Id;

            i.PutExtra("id", id);
            StartActivity(i);                                     




        }
    }
}