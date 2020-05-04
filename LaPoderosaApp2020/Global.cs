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
    class Global
    {
        //Definimos la lista de sucursales
        public static List<Sucursal> Sucursales = new List<Sucursal>
        {
            new Sucursal(1,"León","Pasarela Universitaria 75 vrs al norte, Contiguo a Pizza Roma, León.","2222-5667","12.4339014,-86.9170984","LOPEZ ORTIZ ISABEL")
            ,new Sucursal(2,"Masaya","Semáforos del Colegio Bautista ½ cuadra al este, Barrio El Calvario, Masaya","2222-5478","11.9750531,-86.1102344","PEREZ BERNAL MANUELA")
            ,new Sucursal(3,"Estelí","De la Óptica Munkel 2 cuadras y media al oeste, casa color dorado, mano izquierda. Estelí.","2222-4156","13.0897669,-86.3782884","SOLA FLORES MONICA")
            ,new Sucursal(4,"Matagalpa","Del SILAIS 1½ cuadra al oeste. Matagalpa.","2222-0045","12.9296542,-85.9390176","DOÑA MORALES MONICA")
            ,new Sucursal(5,"Chontales","De la CST ½ cuadra al norte o del Centro Médico de Juigalpa ½ cuadra al sur. Juigalpa","2222-2200","12.1144787,-85.2737255","LOPEZ CASADO MARIA JOSE")

        };
    }

    //Definir estructuras
    //Clases de datos

    public class Sucursal
    {
        //definimos los campos de la clase
        int id;
        string departamento;
        string direccion;
        string telefono;
        string coordenadas;
        string responsable;

        //constructor
        public Sucursal(int id, string departamento, string direccion, string telefono, string coordenadas, string responsable)
        {
            this.Id = id;
            this.Departamento = departamento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Coordenadas = coordenadas;
            this.Responsable = responsable;
        }
        //propiedades
        public int Id { get => id; set => id = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Coordenadas { get => coordenadas; set => coordenadas = value; }
        public string Responsable { get => responsable; set => responsable = value; }
    }

}