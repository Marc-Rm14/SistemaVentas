using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace app.Ventas.Utilidades
{
    public class FacturaDocumento: IDocument
    {
        public string ClienteNombre { get; }
        public DataGridViewRowCollection Detalles { get; }
        
        public string Total { get; }

        //TODO: Agregamos dos labels para subtotal y impuesto?

        public FacturaDocumento(string cliente, DataGridViewRowCollection detalles, string total)
        {
            ClienteNombre = cliente;
            Detalles = detalles;
            Total = total;
        }


        public DocumentMetadata GetMetadata() 
        {
            return DocumentMetadata.Default;
        }


        public DocumentSettings GetSettings() 
        {
            return DocumentSettings.Default; 
        }

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    // Configura el tamaño (A4) y los márgenes
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);

                    // Encabezado de la Página, 
                    page.Header().Column(col =>
                    {
                        col.Item().Text("Factura - Mi Tienda").Bold().FontSize(20);
                        col.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
                        col.Item().Text($"Cliente: {ClienteNombre}");
                        col.Item().PaddingTop(10).BorderBottom(1).BorderColor(Colors.Grey.Medium);
                    });

                    // Contenido (El Carrito) 
                    page.Content().Column(col =>
                    {
                        // Encabezados de la tabla
                        col.Item().Row(row =>
                        {
                            row.Spacing(1, Unit.Centimetre);
                            row.RelativeItem(3).Text("Producto").Bold();
                            row.RelativeItem(1).Text("Cant.").Bold();
                            row.RelativeItem(1).Text("Precio").Bold();
                            row.RelativeItem(1).Text("Subtotal").Bold();
                        });

                        // Bucle para los productos
                        foreach (DataGridViewRow fila in Detalles)
                        {
                            if (fila.IsNewRow) continue;

                            col.Item().Row(row =>
                            {
                                row.Spacing(1, Unit.Centimetre);
                                row.RelativeItem(3).Text(fila.Cells["Nombre"].Value.ToString());
                                row.RelativeItem(1).Text(fila.Cells["Cantidad"].Value.ToString());
                                row.RelativeItem(1).Text(Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value).ToString("N2"));
                                row.RelativeItem(1).Text(Convert.ToDecimal(fila.Cells["Subtotal"].Value).ToString("N2"));
                            });
                        }

                        //Totales (al final)
                        col.Item().PaddingTop(20).AlignRight().Column(totalCol =>
                        {
                            
                            totalCol.Item().Text(Total).Bold().FontSize(14);
                        });
                    });

                    //Pie de Página
                    page.Footer()
                        .AlignCenter()
                        .Text(text =>
                        {
                            text.Span("¡Gracias por su compra!");
                            
                        });
                });
        }


    }
}
