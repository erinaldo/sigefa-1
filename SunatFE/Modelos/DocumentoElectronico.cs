using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SunatFE
{
    public class DocumentoElectronico
    {
        public Contribuyente Emisor { get; set; }
        public Contribuyente Receptor { get; set; }
        public List<DatoAdicional> DatoAdicionales { get; set; }
        public List<DocumentoRelacionado> Relacionados { get; set; }
        public List<DetalleDocumento> Items { get; set; }
        public DatosGuia DatosGuiaTransportista { get; set; }
        public List<Discrepancia> Discrepancias { get; set; }
        public BillingPayment PrepaidPayment { get; set; }
        public DocumentoRetencion DocumentoRetencion { get; set; }
        public ItemRetencion ItemRetencion { get; set; }
        public Exportacion Exportacion { get; set; }

       
        public string TipoDocumento { get; set; }
        public string IdDocumento { get; set; }
        public string FechaEmision { get; set; }
        public string Moneda { get; set; }
        public decimal Gravadas { get; set; }
        public decimal Gratuitas { get; set; }
        public decimal Inafectas { get; set; }
        public decimal Exoneradas { get; set; }
        public decimal DescuentoGlobal { get; set; }
        public decimal TotalVenta { get; set; }

        public decimal SubTotalVenta { get; set; }
        public decimal TotalIgv { get; set; }
        public decimal TotalIsc { get; set; }
        public decimal TotalOtrosTributos { get; set; }
        public string MontoEnLetras { get; set; }
        public string MontoEnLetrasDolares { get; set; }
        public string TipoOperacion { get; set; }
        public decimal CalculoIgv { get; set; }
        public decimal CalculoIsc { get; set; }
        public decimal CalculoDetraccion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public string TipoDocAnticipo { get; set; }
        public string DocAnticipo { get; set; }
        public string MonedaAnticipo { get; set; }
        public decimal MontoAnticipo { get; set; }
        
        public string FirmaDigital { get; set; }

        public DocumentoElectronico()
        {


            Exportacion = new Exportacion { };
            DocumentoRetencion = new DocumentoRetencion { };
            ItemRetencion = new ItemRetencion { };
               
            Emisor = new Contribuyente
            {
                TipoDocumento = "6" // RUC.

            };           

            Receptor = new Contribuyente
            {
                TipoDocumento = "6" // RUC.   //REG. UNICO DE CONTRIBUYENTES - VER CATALAGO Nº 6 TABLA 2
            };
            CalculoIgv = 0.18m;
            CalculoIsc = 0.10m;
            CalculoDetraccion = 0.04m;
            Items = new List<DetalleDocumento>();
            DatoAdicionales = new List<DatoAdicional>();
            Relacionados = new List<DocumentoRelacionado>();
            Discrepancias = new List<Discrepancia>();
            //TipoDocumento = "01"; // Factura - 03 Boleta. - 07 NC - 08 ND 
            TipoOperacion = "01"; // Venta Interna.
            Moneda = "PEN"; // Soles.



        
        }
        

    }

}