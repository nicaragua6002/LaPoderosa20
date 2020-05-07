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
            new Sucursal(1,"León","Pasarela Universitaria  vrs al norte, Contiguo a Pizza Roma, León.","2222-5667","12.4339014,-86.9170984","LOPEZ ORTIZ ISABEL")
            ,new Sucursal(2,"Masaya","Semáforos del Colegio Bautista ½ cuadra al este, Barrio El Calvario, Masaya","2222-5478","11. 0531,-86.1102344","PEREZ BERNAL MANUELA")
            ,new Sucursal(3,"Estelí","De la Óptica Munkel 2 cuadras y media al oeste, casa color dorado, mano izquierda. Estelí.","2222-4156","13.0897669,-86.3782884","SOLA FLORES MONICA")
            ,new Sucursal(4,"Matagalpa","Del SILAIS 1½ cuadra al oeste. Matagalpa.","2222-0045","12.9296542,-85.9390176","DOÑA MORALES MONICA")
            ,new Sucursal(5,"Chontales","De la CST ½ cuadra al norte o del Centro Médico de Juigalpa ½ cuadra al sur. Juigalpa","2222-2200","12.1144787,-85.2735","LOPEZ CASADO MARIA JOSE")

        };

        //Lista Categorias
       public static List<Categoria> Categorias = new List<Categoria>()
        {
               new Categoria(1,"Bebidas")
            ,new Categoria(2,"Condimentos")
            ,new Categoria(3,"Frutas/Verduras")
            ,new Categoria(4,"Carnes")
            ,new Categoria(5,"Pescado/Marisco")
            ,new Categoria(6,"Lácteos")
             ,new Categoria(7,"Repostería")
            ,new Categoria(8,"Granos/Cereales")
        };

        //Lista Productos
        public static List<Producto> Productos = new List<Producto>()
        {
            new Producto(1,"Té Dharamsala","Exotic Liquids",1,"10 cajas x 20 bolsas",18,39)
            ,new Producto(2,"Cerveza tibetana Barley","Exotic Liquids",1,"24 - bot. 12 l",19,17)
            ,new Producto(3,"Sirope de regaliz","Exotic Liquids",2,"12 - bot. 550 ml",10,13)
            ,new Producto(4,"Especias Cajun del chef Anton","New Orleans Cajun Delights",2,"48 - frascos 6 l",22,53)
            ,new Producto(5,"Mezcla Gumbo del chef Anton","New Orleans Cajun Delights",2,"36 cajas",21,0)
            ,new Producto(6,"Mermelada de grosellas de la abuela","Grandma Kelly's Homestead",2,"12 - frascos 8 l",12,10)
            ,new Producto(7,"Peras secas orgánicas del tío Bob","Grandma Kelly's Homestead",3,"12 - paq. 1 kg",30,15)
            ,new Producto(8,"Salsa de arándanos Northwoods","Grandma Kelly's Homestead",2,"12 - frascos 12 l",40,6)
            ,new Producto(9,"Buey Mishi Kobe","Tokyo Traders",4,"18 - paq. 500 g",97,29)
            ,new Producto(10,"Pez espada","Tokyo Traders",5,"12 - frascos 200 ml",31,31)
            ,new Producto(11,"Queso Cabrales","Cooperativa de Quesos 'Las Cabras'",6,"paq. 1 kg",21,22)
            ,new Producto(12,"Queso Manchego La Pastora","Cooperativa de Quesos 'Las Cabras'",6,"10 - paq. 500 g",38,86)
            ,new Producto(13,"Algas Konbu","Mayumi's",5,"caja 2 kg",6,24)
            ,new Producto(14,"Cuajada de judías","Mayumi's",3,"40 - paq. 100 g",23,35)
            ,new Producto(15,"Salsa de soja baja en sodio","Mayumi's",2,"24 - bot.0 ml",15,39)
            ,new Producto(16,"Postre de merengue Pavlova","Pavlova, Ltd.",7,"32 - cajas 500 g",17,29)
            ,new Producto(17,"Cordero Alice Springs","Pavlova, Ltd.",4,"20 - latas 1 kg",39,0)
            ,new Producto(18,"Langostinos tigre Carnarvon","Pavlova, Ltd.",5,"paq. 16 kg",62,42)
            ,new Producto(19,"Pastas de té de chocolate","Specialty Biscuits, Ltd.",7,"10 cajas x 12 piezas",9,12)
            ,new Producto(20,"Mermelada de Sir Rodney's","Specialty Biscuits, Ltd.",7,"30 cajas regalo",81,40)
            ,new Producto(21,"Bollos de Sir Rodney's","Specialty Biscuits, Ltd.",7,"24 paq. x 4 piezas",10,3)
            ,new Producto(22,"Pan de centeno crujiente estilo Gustaf's","PB Knäckebröd AB",8,"24 - paq. 500 g",21,104)
            ,new Producto(23,"Pan fino","PB Knäckebröd AB",8,"12 - paq.0 g",9,61)
            ,new Producto(24,"Refresco Guaraná Fantástica","Refrescos Americanas LTDA",1,"12 - latas 355 ml",4,20)
            ,new Producto(25,"Crema de chocolate y nueces NuNuCa","Heli Süßwaren GmbH & Co. KG",7,"20 - vasos  450 g",14,76)
            ,new Producto(26,"Ositos de goma Gumbär","Heli Süßwaren GmbH & Co. KG",7,"100 - bolsas0 g",31,15)
            ,new Producto(27,"Chocolate Schoggi","Heli Süßwaren GmbH & Co. KG",7,"100 - piezas 100 g",43,49)
            ,new Producto(28,"Col fermentada Rössle","Plutzer Lebensmittelgroßmärkte AG",3," - latas  g",45,26)
            ,new Producto(29,"Salchicha Thüringer","Plutzer Lebensmittelgroßmärkte AG",4,"50 bolsas x 30 salch",123,0)
            ,new Producto(30,"Arenque blanco del noroeste","Nord-Ost-Fisch Handelsgesellschaft mbH",5,"10 - vasos 200 g",89,10)
            ,new Producto(31,"Queso gorgonzola Telino","Formaggi Fortini s.r.l.",6,"12 - paq. 100 g",12,0)
            ,new Producto(32,"Queso Mascarpone Fabioli","Formaggi Fortini s.r.l.",6,"24 - paq. 200 g",32,9)
            ,new Producto(33,"Queso de cabra","Norske Meierier",6,"500 g",2,112)
            ,new Producto(34,"Cerveza Sasquatch","Bigfoot Breweries",1,"24 - bot. 12 l",14,111)
            ,new Producto(35,"Cerveza negra Steeleye","Bigfoot Breweries",1,"24 - bot. 12 l",18,20)
            ,new Producto(36,"Escabeche de arenque","Svensk Sjöföda AB",5,"24 - frascos0 g",19,112)
            ,new Producto(37,"Salmón ahumado Gravad","Svensk Sjöföda AB",5,"12 - paq. 500 g",26,11)
            ,new Producto(38,"Vino Côte de Blaye","Aux joyeux ecclésiastiques",1,"12 - bot.  cl",263,17)
            ,new Producto(39,"Licor verde Chartreuse","Aux joyeux ecclésiastiques",1, "10 cc por bot.",18,69)
            ,new Producto(40,"Carne de cangrejo de Boston","New England Seafood Cannery",5,"24 - latas 4 l",18,123)
            ,new Producto(41,"Crema de almejas estilo Nueva Inglaterra","New England Seafood Cannery",5,"12 - latas 12 l",9,85)
            ,new Producto(42,"Tallarines de Singapur","Leka Trading",8,"32 - 1 kg paq.",14,26)
            ,new Producto(43,"Café de Malasia","Leka Trading",1,"16 - latas 500 g",46,17)
            ,new Producto(44,"Azúcar negra Malacca","Leka Trading",2,"20 - bolsas 2 kg",19,27)
            ,new Producto(45,"Arenque ahumado","Lyngbysild",5,"paq. 1k",9,5)
            ,new Producto(46,"Arenque salado","Lyngbysild",5,"4 - vasos 450 g",12,95)
            ,new Producto(47,"Galletas Zaanse","Zaanse Snoepfabriek",7,"10 - cajas 4 l",9,36)
            ,new Producto(48,"Chocolate holandés","Zaanse Snoepfabriek",7,"10 paq.",12 ,15)
            ,new Producto(49,"Regaliz","Karkki Oy",7,"24 - paq. 50 g",20,10)
            ,new Producto(50,"Chocolate blanco","Karkki Oy",7,"12 - barras 100 g",16,65)
            ,new Producto(51,"Manzanas secas Manjimup","G'day, Mate",3,"50 - paq. 300 g",53,20)
            ,new Producto(52,"Cereales para Filo","G'day, Mate",8,"16 - cajas 2 kg",7,38)
            ,new Producto(53,"Empanada de carne","G'day, Mate",4,"48 porc.",32,0)
            ,new Producto(54,"Empanada de cerdo","Ma Maison",4,"16 tartas",7,21)
            ,new Producto(55,"Paté chino","Ma Maison",4,"24 cajas x 2 tartas",24,115)
            ,new Producto(56,"Gnocchi de la abuela Alicia","Pasta Buttini s.r.l.",8,"24 - paq.0 g",38,21)
            ,new Producto(57,"Raviolis Angelo","Pasta Buttini s.r.l.",8,"24 - paq.0 g",19,36)
            ,new Producto(58,"Caracoles de Borgoña","Escargots Nouveaux",5,"24 porc.",13,62)
            ,new Producto(59,"Raclet de queso Courdavault","Gai pâturage",6,"paq. 5 kg",55,79)
            ,new Producto(60,"Camembert Pierrot","Gai pâturage",6,"15 - paq. 300 g",34,19)
            ,new Producto(61,"Sirope de arce","Forêts d'érables",2,"24 - bot. 500 ml",28,113)
            ,new Producto(62,"Tarta de azúcar","Forêts d'érables",7,"48 tartas",49,17)
            ,new Producto(63,"Sandwich de vegetales","Pavlova, Ltd.",2,"15 - frascos  g",43,24)
            ,new Producto(64,"Bollos de pan de Wimmer","Plutzer Lebensmittelgroßmärkte AG",8,"20 bolsas x 4 porc.",33,22)
            ,new Producto(65,"Salsa de pimiento picante de Luisiana","New Orleans Cajun Delights",2,"32 - bot. 8 l",21,76)
            ,new Producto(66,"Especias picantes de Luisiana","New Orleans Cajun Delights",2,"24 - frascos 8 l",17,4)
            ,new Producto(67,"Cerveza Laughing Lumberjack","Bigfoot Breweries",1,"24 - bot. 12 l",14,52)
            ,new Producto(68,"Barras de pan de Escocia","Specialty Biscuits, Ltd.",7,"10 cajas x 8 porc.",12,6)
            ,new Producto(69,"Queso Gudbrandsdals","Norske Meierier",6,"paq. 10 kg",36,26)
            ,new Producto(70,"Cerveza Outback","Pavlova, Ltd.",1,"24 - bot. 355 ml",15,15)
            ,new Producto(71,"Crema de queso Fløtemys","Norske Meierier",6,"10 - paq. 500 g",21,26)
            ,new Producto(72,"Queso Mozzarella Giovanni","Formaggi Fortini s.r.l.",6,"24 - paq. 200 g",34,14)
            ,new Producto(73,"Caviar rojo","Svensk Sjöföda AB",5,"24 - frascos150 g",15,101)
            ,new Producto(74,"Queso de soja Longlife","Tokyo Traders",3,"paq. 5 kg",10,4)
            ,new Producto (75,"Cerveza Klosterbier Rhönbräu","Plutzer Lebensmittelgroßmärkte AG",1,"24 - bot. 0,5 l",7 ,2)
            ,new Producto(76,"Licor Cloudberry","Karkki Oy",1,"500 ml",18,57)
            ,new Producto(77,"Salsa verde original Frankfurter","Plutzer Lebensmittelgroßmärkte AG",2,"12 cajas",13,32)

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


    //Agregar nuevas clases

    public class Categoria
    {
        //campos
        int id;
        string nombre;

        //constructor
        public Categoria(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        //propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }


    public class Producto
    {
        //campos
        int id;
        string nombreProducto;
        string proveedor;
        int idCategoria;
        string cantidadPorUnidad;
        decimal precioUnidad;
        decimal unidadesEnExistencia;

        //constructor
        public Producto(int id, string nombreProducto, string proveedor, int idCategoria, string cantidadPorUnidad, decimal precioUnidad, decimal unidadesEnExistencia)
        {
            this.Id = id;
            this.NombreProducto = nombreProducto;
            this.Proveedor = proveedor;
            this.IdCategoria = idCategoria;
            this.CantidadPorUnidad = cantidadPorUnidad;
            this.PrecioUnidad = precioUnidad;
            this.UnidadesEnExistencia = unidadesEnExistencia;
        }

        //propiedades
        public int Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string CantidadPorUnidad { get => cantidadPorUnidad; set => cantidadPorUnidad = value; }
        public decimal PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public decimal UnidadesEnExistencia { get => unidadesEnExistencia; set => unidadesEnExistencia = value; }
    }


}