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
using Java.Lang;

namespace LaPoderosaApp2020
{
    class AdapterProductos : BaseAdapter
    {
        Activity context;
        List<Producto> productos;

        public AdapterProductos(Activity context, List<Producto> productos)
        {
            this.context = context;
            this.productos = productos;
        }

        public override int Count => productos.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = productos[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.ItemProducto, null);
            view.FindViewById<TextView>(Resource.Id.textView1).Text = item.UnidadesEnExistencia.ToString();
            view.FindViewById<TextView>(Resource.Id.textView2).Text = item.NombreProducto;
            view.FindViewById<TextView>(Resource.Id.textView3).Text = item.Proveedor;
            view.FindViewById<TextView>(Resource.Id.textView4).Text = item.CantidadPorUnidad;

            return view;

        }
    }
}