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
    [Activity(Label = "ActivityDetalleProducto")]
    public class ActivityDetalleProducto : Activity
    {
        //variables
        TextView txtnombre, txtproveedor, txtcant;
        Button btnshare;
        Producto prod;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DetalleProducto);

            //vinculamos variables con controles
            txtnombre = FindViewById<TextView>(Resource.Id.textView1);
            txtproveedor = FindViewById<TextView>(Resource.Id.textView2);
            txtcant = FindViewById<TextView>(Resource.Id.textView3);

            //recuperamos el id del producto seleccionado

            int id = Intent.GetIntExtra("id", 0);
            prod = Global.Productos.Where(x => x.Id == id).FirstOrDefault();

            //asigamos los valores
            txtnombre.Text = prod.NombreProducto;
            txtproveedor.Text = prod.Proveedor;
            txtcant.Text = prod.UnidadesEnExistencia.ToString() + " items " + prod.PrecioUnidad.ToString();

            //Programamos el boton compartir

            btnshare = FindViewById<Button>(Resource.Id.button1);
            btnshare.Click += Btnshare_Click;
        }

        private void Btnshare_Click(object sender, EventArgs e)
        {
            string mensaje = "Este es un buen producto \n" + prod.NombreProducto + " a buen precio: " +
                prod.PrecioUnidad + "\n Disponible en tiendas la poderosa";
            var i = new Intent(Intent.ActionSend);
            i.SetType("text/plain");
            i.PutExtra(Android.Content.Intent.ExtraText, mensaje);
            StartActivity(Intent.CreateChooser(i, "LAPODEROSA"));

            
        }
    }
}