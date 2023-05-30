using General.CLS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    public class Ticket
    {
        public List<Producto> Productos { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }

        public int AnchoTicket { get; set; }

        public Ticket(int anchoTicket)
        {
            Productos = new List<Producto>();
            AnchoTicket = anchoTicket;
        }

        //        private void frmVender_Load(object sender, EventArgs e)
        //        {
        //            lblFecha.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        //        }

        //        public void AgregarProducto(string nombre, decimal precio, int cantidad)
        //        {
        //            var producto = new Producto
        //            {
        //                Nombre = nombre,
        //                Precio = precio,
        //                Cantidad = cantidad
        //            };
        //            Productos.Add(producto);
        //        }

        //        public void CalcularTotal()
        //        {
        //            Subtotal = 0;
        //            foreach (var producto in Productos)
        //            {
        //                Subtotal += producto.Precio * producto.Cantidad;
        //            }
        //            Impuesto = Subtotal * 0.16m;
        //            Total = Subtotal + Impuesto;
        //        }

        //        public void ImprimirTicket()
        //        {
        //            PrintDocument pd = new PrintDocument();
        //            pd.PrintPage += new PrintPageEventHandler(ImprimirTicket_PrintPage);

        //            // Mostrar el cuadro de diálogo de impresión para seleccionar la impresora
        //            PrintDialog printDialog = new PrintDialog();
        //            printDialog.Document = pd;

        //            if (printDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                pd.Print();
        //            }
        //        }

        //        private void ImprimirTicket_PrintPage(object sender, PrintPageEventArgs e)
        //        {
        //            Graphics graphics = e.Graphics;

        //            int leftMargin = 10;
        //            int topMargin = 10;
        //            int lineHeight = 20;

        //            Font font = new Font("Courier New", 10);

        //            string titulo = $"Ticket de compra (Ancho: {AnchoTicket} mm)";
        //            graphics.DrawString(titulo, font, Brushes.Black, leftMargin, topMargin);
        //            topMargin += lineHeight;

        //            string separador = new string('-', AnchoTicket);
        //            graphics.DrawString(separador, font, Brushes.Black, leftMargin, topMargin);
        //            topMargin += lineHeight;

        //            foreach (var producto in Productos)
        //            {
        //                string lineaProducto = $"{producto.Nombre} - {producto.Precio:C} x {producto.Cantidad} = {producto.Precio * producto.Cantidad:C}";
        //                graphics.DrawString(lineaProducto, font, Brushes.Black, leftMargin, topMargin);
        //                topMargin += lineHeight;
        //            }

        //            graphics.DrawString(separador, font, Brushes.Black, leftMargin, topMargin);
        //            topMargin += lineHeight;

        //            string lineaSubtotal = $"Subtotal: {Subtotal:C}";
        //            graphics.DrawString(lineaSubtotal, font, Brushes.Black, leftMargin, topMargin);
        //            topMargin += lineHeight;

        //            string lineaImpuesto = $"Impuesto: {Impuesto:C}";
        //            graphics.DrawString(lineaImpuesto, font, Brushes.Black, leftMargin, topMargin);
        //            topMargin += lineHeight;

        //            string lineaTotal = $"Total: {Total:C}";
        //            graphics.DrawString(lineaTotal, font, Brushes.Black, leftMargin, topMargin);
        //            topMargin += lineHeight;

        //            // Si hay más páginas para imprimir, indicarlo
        //            e.HasMorePages = false;
        //        }
        //    }
        //}

        //// Detalle ventas, click al boton de imprimir y debe traer estos datos
        //public class Program
        //{
        //    public static void mani(string[] args)
        //    {
        //        int anchoTicket = 58; // Ancho del ticket en milímetros

        //        var ticket = new Ticket(anchoTicket);

        //        // Obtener datos del DataGridView
        //        DataGridView dataGridView = ObtenerDataGridView();

        //        foreach (DataGridViewRow row in dataGridView.Rows)
        //        {
        //            string nombre = row.Cells["Nombre"].Value.ToString();
        //            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
        //            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

        //            ticket.AgregarProducto(nombre, precio, cantidad);
        //        }

        //        ticket.CalcularTotal();
        //        ticket.ImprimirTicket();
        //    }
        //    private static DataGridView ObtenerDataGridView()
        //    {
        //        // Ejemplo: Crear un DataGridView y llenarlo con datos de prueba
        //        DataGridView dataGridView = new DataGridView();
        //        dataGridView.Columns.Add("Nombre", "Nombre");
        //        dataGridView.Columns.Add("Precio", "Precio");
        //        dataGridView.Columns.Add("Cantidad", "Cantidad");

        //        dataGridView.Rows.Add("Camisa", 29.99m, 2);
        //        dataGridView.Rows.Add("Pantalón", 49.99m, 1);

        //        return dataGridView;
        //    }
    }
}
// DISENO MANUAL DEL TICKET, PUNTO POR PUNTO
//public class CreaTicket
//{
//    public static StringBuilder line = new StringBuilder();
//    string ticket = "";
//    string parte1, parte2;

//    public static int max = 40;
//    int cort;
//    public static string LineasGuion()
//    {
//        string LineaGuion = "----------------------------------------";   // agrega lineas separadoras -

//        return line.AppendLine(LineaGuion).ToString();
//    }


//    public static void EncabezadoVenta()
//    {
//        string LineEncavesado = "Articulo       Cant   P.Unit    Valor";   // agrega lineas de  encabezados
//        line.AppendLine(LineEncavesado);
//    }
//    public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
//    {
//        max = par1.Length;
//        if (max > 40)                                 // **********
//        {
//            cort = max - 40;
//            parte1 = par1.Remove(40, cort);        // si es mayor que 40 caracteres, lo corta
//        }
//        else { parte1 = par1; }                      // **********
//        line.AppendLine(ticket = parte1);

//    }
//    public void TextoDerecha(string par1)
//    {
//        ticket = "";
//        max = par1.Length;
//        if (max > 40)                                 // **********
//        {
//            cort = max - 40;
//            parte1 = par1.Remove(40, cort);           // si es mayor que 40 caracteres, lo corta
//        }
//        else { parte1 = par1; }                      // **********
//        max = 40 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
//        for (int i = 0; i < max; i++)
//        {
//            ticket += " ";                          // agrega espacios para alinear a la derecha
//        }
//        line.AppendLine(ticket += parte1 + "\n");                //Agrega el texto

//    }
//    public void TextoCentro(string par1)
//    {
//        ticket = "";
//        max = par1.Length;
//        if (max > 40)                                 // **********
//        {
//            cort = max - 40;
//            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
//        }
//        else { parte1 = par1; }                      // **********
//        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
//        for (int i = 0; i < max; i++)                // **********
//        {
//            ticket += " ";                           // Agrega espacios antes del texto a centrar
//        }                                            // **********
//        line.AppendLine(ticket += parte1 + "\n");

//    }
//    public void TextoExtremos(string par1, string par2)
//    {
//        max = par1.Length;
//        if (max > 18)                                 // **********
//        {
//            cort = max - 18;
//            parte1 = par1.Remove(18, cort);          // si par1 es mayor que 18 lo corta
//        }
//        else { parte1 = par1; }                      // **********
//        ticket = parte1;                             // agrega el primer parametro
//        max = par2.Length;
//        if (max > 18)                                 // **********
//        {
//            cort = max - 18;
//            parte2 = par2.Remove(18, cort);          // si par2 es mayor que 18 lo corta
//        }
//        else { parte2 = par2; }
//        max = 40 - (parte1.Length + parte2.Length);
//        for (int i = 0; i < max; i++)                 // **********
//        {
//            ticket += " ";                            // Agrega espacios para poner par2 al final
//        }                                             // **********
//        line.AppendLine(ticket += parte2 + "\n");                   // agrega el segundo parametro al final

//    }
//    public void AgregaTotales(string par1, double total)
//    {
//        max = par1.Length;
//        if (max > 25)                                 // **********
//        {
//            cort = max - 25;
//            parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
//        }
//        else { parte1 = par1; }                      // **********
//        ticket = parte1;
//        parte2 = total.ToString("c");
//        max = 40 - (parte1.Length + parte2.Length);
//        for (int i = 0; i < max; i++)                // **********
//        {
//            ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
//        }                                            // **********
//        line.AppendLine(ticket += parte2 + "\n");

//    }

//    // se le pasan los Aticulos  con sus detalles
//    public void AgregaArticulo(string Articulo, double precio, int cant, double subtotal)
//    {
//        if (cant.ToString().Length <= 3 && precio.ToString("c").Length <= 10 && subtotal.ToString("c").Length <= 11) // valida que cant precio y total esten dentro de rango
//        {
//            string elementos = "", espacios = "";
//            bool bandera = false;
//            int nroEspacios = 0;

//            if (Articulo.Length > 40)                                 // **********
//            {
//                //cort = max - 16;
//                //parte1 = Articulo.Remove(16, cort);          // corta a 16 la descripcion del articulo
//                nroEspacios = (3 - cant.ToString().Length);
//                espacios = "";
//                for (int i = 0; i < nroEspacios; i++)
//                {
//                    espacios += " ";
//                }
//                elementos += espacios + cant.ToString();

//                // colocamos el precio a la derecha
//                nroEspacios = (10 - precio.ToString().Length);
//                espacios = "";

//                for (int i = 0; i < nroEspacios; i++)
//                {
//                    espacios += " ";
//                }
//                elementos += espacios + precio.ToString();

//                //colocar el subtotal a la dercha
//                nroEspacios = (11 - subtotal.ToString().Length);
//                espacios = "";

//                for (int i = 0; i < nroEspacios; i++)
//                {
//                    espacios += " ";
//                }
//                elementos += espacios + subtotal.ToString();

//                int CaracterActual = 0;// indica en que caracter se quedo
//                for (int Longtext = Articulo.Length; Longtext > 16; Longtext++)
//                {
//                    if (bandera == false)
//                    {
//                        line.AppendLine(Articulo.Substring(CaracterActual, 16) + elementos);
//                        bandera = true;
//                    }
//                    else
//                    {
//                        line.AppendLine(Articulo.Substring(CaracterActual, 16));

//                    }
//                    CaracterActual += 16;
//                }
//                line.AppendLine(Articulo.Substring(CaracterActual, Articulo.Length - CaracterActual));


//            }
//            else
//            {
//                for (int i = 0; i < (16 - Articulo.Length); i++)
//                {
//                    espacios += " ";

//                }
//                elementos = Articulo + espacios;
//                nroEspacios = (3 - cant.ToString().Length);
//                espacios = "";
//                for (int i = 0; i < nroEspacios; i++)
//                {
//                    espacios += " ";
//                }
//                elementos += espacios + cant.ToString();

//                // colocamos el precio a la derecha
//                nroEspacios = (10 - precio.ToString().Length);
//                espacios = "";

//                for (int i = 0; i < nroEspacios; i++)
//                {
//                    espacios += " ";
//                }
//                elementos += espacios + precio.ToString();

//                //colocar el subtotal a la dercha
//                nroEspacios = (11 - subtotal.ToString().Length);
//                espacios = "";

//                for (int i = 0; i < nroEspacios; i++)
//                {
//                    espacios += " ";
//                }
//                elementos += espacios + subtotal.ToString();
//                line.AppendLine(elementos);

//            }
//        }
//        else
//        {
//            //  MessageBox.Show("Valores fuera de rango");

//        }
//    }

//    public void ImprimirTiket(string stringimpresora)
//    {
//        RawPrinterHelper.SendStringToPrinter(stringimpresora, line.ToString());
//        line = new StringBuilder();

//    }
//}

//#region Clase para enviar a imprsora texto plano
//public class RawPrinterHelper
//{
//    // Structure and API declarions:
//    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
//    public class DOCINFOA
//    {
//        [MarshalAs(UnmanagedType.LPStr)]
//        public string pDocName;
//        [MarshalAs(UnmanagedType.LPStr)]
//        public string pOutputFile;
//        [MarshalAs(UnmanagedType.LPStr)]
//        public string pDataType;
//    }
//    [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
//    public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

//    [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
//    public static extern bool ClosePrinter(IntPtr hPrinter);

//    [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
//    public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

//    [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
//    public static extern bool EndDocPrinter(IntPtr hPrinter);

//    [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
//    public static extern bool StartPagePrinter(IntPtr hPrinter);

//    [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
//    public static extern bool EndPagePrinter(IntPtr hPrinter);

//    [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
//    public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

//    // SendBytesToPrinter()
//    // When the function is given a printer name and an unmanaged array
//    // of bytes, the function sends those bytes to the print queue.
//    // Returns true on success, false on failure.
//    public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
//    {
//        Int32 dwError = 0, dwWritten = 0;
//        IntPtr hPrinter = new IntPtr(0);
//        DOCINFOA di = new DOCINFOA();
//        bool bSuccess = false; // Assume failure unless you specifically succeed.

//        di.pDocName = "My C#.NET RAW Document";
//        di.pDataType = "RAW";
//        // di.pOutputFile = @"C:\Users\Roland\Documents\Visual Studio 2015\Projects\pjtVentas\Ventas";

//        // Open the printer.
//        if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
//        {
//            // Start a document.
//            if (StartDocPrinter(hPrinter, 1, di))
//            {
//                // Start a page.
//                if (StartPagePrinter(hPrinter))
//                {
//                    // Write your bytes.
//                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
//                    EndPagePrinter(hPrinter);
//                }
//                EndDocPrinter(hPrinter);
//            }
//            ClosePrinter(hPrinter);
//        }
//        // If you did not succeed, GetLastError may give more information
//        // about why not.
//        if (bSuccess == false)
//        {
//            dwError = Marshal.GetLastWin32Error();
//        }
//        return bSuccess;
//    }

//    public static bool SendStringToPrinter(string szPrinterName, string szString)
//    {
//        IntPtr pBytes;
//        Int32 dwCount;
//        // How many characters are in the string?
//        dwCount = szString.Length;
//        // Assume that the printer is expecting ANSI text, and then convert
//        // the string to ANSI text.
//        pBytes = Marshal.StringToCoTaskMemAnsi(szString);
//        // Send the converted ANSI string to the printer.
//        SendBytesToPrinter(szPrinterName, pBytes, dwCount);
//        Marshal.FreeCoTaskMem(pBytes);
//        return true;
//    }
//}
//        #endregion

// CLASE PARA CREAR TICKET
//private void button3_Click(object sender, EventArgs e)
//{

//    Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
//    if (Conteo != 0)
//    {

//        //RegistrarCompra

//        try
//        {
//            ClassBT.clsVenta.Fecha = lblFecha.Text;

//            ClassBT.clsVenta.Costo = float.Parse(lblCostoApagar.Text);

//            ClassFunciones.clsFunciones.EjecutaQuery("RV");

//            DataTable d = new DataTable();
//            d = ClassFunciones.clsFunciones.EjecutaQueryConsulta("", "IDV");

//            ClassBT.clsDetallesVenta.IdVentafk = ClassBT.clsVenta.IdVenta = int.Parse(d.Rows[0][0].ToString());


//            for (int i = 0; i < Conteo; i++)
//            {
//                ClassBT.clsDetallesVenta.idProdcutofk = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()); ;
//                ClassBT.clsDetallesVenta.Cantidad = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
//                ClassBT.clsDetallesVenta.CostoDetalle = float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

//                ClassFunciones.clsFunciones.EjecutaQuery("RDV");//registra el detalle de la venta 

//            }
//        }
//        catch (Exception a)
//        {

//            MessageBox.Show(a.Message);
//        }


//        ClassFunciones.clsFunciones.CreaTicket Ticket1 = new ClassFunciones.clsFunciones.CreaTicket();

//        Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
//        Ticket1.TextoCentro("**********************************");

//        Ticket1.TextoIzquierda("Dirc: xxxx");
//        Ticket1.TextoIzquierda("Tel:xxxx ");
//        Ticket1.TextoIzquierda("Rnc: xxxx");
//        Ticket1.TextoIzquierda("");
//        Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
//        Ticket1.TextoIzquierda("No Fac:" + ClassBT.clsDetallesVenta.IdVentafk.ToString());
//        Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
//        Ticket1.TextoIzquierda("Le Atendio: xxxx");
//        Ticket1.TextoIzquierda("");
//        ClassFunciones.clsFunciones.CreaTicket.LineasGuion();

//        ClassFunciones.clsFunciones.CreaTicket.EncabezadoVenta();
//        ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
//        foreach (DataGridViewRow r in dataGridView1.Rows)
//        {
//            // Articulo                     //Precio                                    cantidad                            Subtotal
//            Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
//        }


//        ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
//        Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
//        Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
//        Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
//        Ticket1.TextoIzquierda(" ");
//        Ticket1.AgregaTotales("Total", double.Parse(lblCostoApagar.Text)); // imprime linea con total
//        Ticket1.TextoIzquierda(" ");
//        Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(textBox3.Text));
//        Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbldevolucion.Text));


//        // Ticket1.LineasTotales(); // imprime linea 

//        Ticket1.TextoIzquierda(" ");
//        Ticket1.TextoCentro("**********************************");
//        Ticket1.TextoCentro("*     Gracias por preferirnos    *");

//        Ticket1.TextoCentro("**********************************");
//        Ticket1.TextoIzquierda(" ");
//        string impresora = "Microsoft XPS Document Writer";
//        Ticket1.ImprimirTiket(impresora);




//        Fila = 0;
//        while (dataGridView1.RowCount > 0)//limpia el dgv
//        { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
//        //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

//        txtIdProducto.Text = lblNombre.Text = txtCantidad.Text = textBox3.Text = "";
//        lblCostoApagar.Text = lbldevolucion.Text = lblPrecio.Text = "0";
//        txtIdProducto.Focus();
//        MessageBox.Show("Gracias por preferirnos");

//    }


//}