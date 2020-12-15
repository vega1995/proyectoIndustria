using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercializadora.codigo
{
    internal static class verificacion
    {
        internal static string proveedores { get; set; }
        internal static string impuesto { get; set; }
        internal static string precio { get; set; }
        internal static string tipoCompra { get; set; }
        internal static string total { get; set; }
        internal static string subTotal { get; set; }
        //internal static string Impuesto { get; set; }

        internal static string nCompra { get; set; }
        internal static Boolean estadoCompra { get; set; }
        internal static int totalItem { get; set; }
    }
}
