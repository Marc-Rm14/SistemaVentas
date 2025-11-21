using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Windows.Forms;
using MigraDoc.Rendering;
using System.Globalization;

namespace app.Ventas.Utilidades
{
    // Clase que se encarga de construir la estructura del documento usando MigraDoc
    public class FacturaPDFCreator
    {
        public string ClienteNombre { get; }
        // Se mantiene DataGridViewRowCollection como la fuente de datos
        public DataGridViewRowCollection Detalles { get; }
        public string Total { get; }

        private Document DocumentoMigraDoc { get; set; }

        public FacturaPDFCreator(string cliente, DataGridViewRowCollection detalles, string total)
        {
            ClienteNombre = cliente;
            Detalles = detalles;
            Total = total;
            // Inicializa el documento de MigraDoc
            DocumentoMigraDoc = new Document();
            DocumentoMigraDoc.Info.Title = "Factura de Venta";
        }

        // Método principal para construir el contenido del PDF
        public void CreateDocument()
        {
            DefineStyles();
            Section section = DocumentoMigraDoc.AddSection();
            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.TopMargin = "2.5cm";
            section.PageSetup.BottomMargin = "2.5cm";
            section.PageSetup.LeftMargin = "1cm";
            section.PageSetup.RightMargin = "1cm";

            // Llama a los métodos para construir el encabezado, contenido y pie de página
            CreateHeader(section);
            CreateContent(section);
            CreateFooter(section);
        }

        // Definición de estilos para el documento
        private void DefineStyles()
        {
            // Estilo normal (por defecto)
            Style style = DocumentoMigraDoc.Styles["Normal"];
            style.Font.Name = "Verdana";

            // Estilo para encabezados de tabla
            style = DocumentoMigraDoc.Styles.AddStyle("TableHeader", "Normal");
            style.Font.Bold = true;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            style.Font.Color = new Color(255, 255, 255); // Blanco
        }

        private void CreateHeader(Section section)
        {
            // Título
            Paragraph title = section.AddParagraph("Factura - Sistema de Control de Ventas");
            title.Format.Font.Size = 16;
            title.Format.Font.Bold = true;
            title.Format.SpaceAfter = "0.5cm";

            // Información de la factura
            section.AddParagraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
            section.AddParagraph($"Cliente: {ClienteNombre}");

            // Línea separadora
            Paragraph separator = section.AddParagraph();
            separator.Format.Borders.Bottom = new Border();
            separator.Format.Borders.Bottom.Width = 1;
            separator.Format.Borders.Bottom.Color = Colors.DarkGray;
            separator.Format.SpaceAfter = "1cm";
        }

        private void CreateContent(Section section)
        {
            // Crear la tabla para los detalles de la venta
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Borders.Color = Colors.Black;
            // FIX: Calificar completamente BorderStyle para evitar la ambigüedad con System.Windows.Forms.BorderStyle
            table.Borders.Style = MigraDoc.DocumentObjectModel.BorderStyle.Single;
            table.Format.SpaceAfter = "1cm";

            // Definición de columnas
            table.AddColumn(Unit.FromCentimeter(7));  // Producto (ancho relativo 3)
            table.AddColumn(Unit.FromCentimeter(2));  // Cant. (ancho relativo 1)
            table.AddColumn(Unit.FromCentimeter(3));  // Precio Unitario (ancho relativo 1)
            table.AddColumn(Unit.FromCentimeter(3));  // Subtotal (ancho relativo 1)

            // Fila de encabezados
            Row headerRow = table.AddRow();
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = new Color(50, 100, 200); // Azul oscuro
            headerRow.Cells[0].AddParagraph("Producto").Format.Alignment = ParagraphAlignment.Left;
            headerRow.Cells[1].AddParagraph("Cant.").Format.Alignment = ParagraphAlignment.Right;
            headerRow.Cells[2].AddParagraph("Precio").Format.Alignment = ParagraphAlignment.Right;
            headerRow.Cells[3].AddParagraph("Subtotal").Format.Alignment = ParagraphAlignment.Right;


            // Rellenar la tabla con los detalles
            foreach (DataGridViewRow fila in Detalles)
            {
                if (fila.IsNewRow) continue;

                Row row = table.AddRow();
                row.VerticalAlignment = VerticalAlignment.Center;

                // Datos de los productos (usando la misma lógica de conversión)
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string cantidad = fila.Cells["Cantidad"].Value.ToString();
                // Usamos Convert.ToDecimal y format N2 para consistencia
                string precio = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value).ToString("N2", CultureInfo.InvariantCulture);
                string subtotal = Convert.ToDecimal(fila.Cells["Subtotal"].Value).ToString("N2", CultureInfo.InvariantCulture);

                // Columna 1: Producto
                row.Cells[0].AddParagraph(nombre).Format.Font.Size = 9;

                // Columna 2: Cantidad
                row.Cells[1].AddParagraph(cantidad).Format.Alignment = ParagraphAlignment.Right;

                // Columna 3: Precio Unitario
                row.Cells[2].AddParagraph(precio).Format.Alignment = ParagraphAlignment.Right;

                // Columna 4: Subtotal
                row.Cells[3].AddParagraph(subtotal).Format.Alignment = ParagraphAlignment.Right;
            }

            // Espacio antes del total
            section.AddParagraph().Format.SpaceBefore = "1cm";

            // Total general (alineado a la derecha)
            Paragraph totalParagraph = section.AddParagraph(Total);
            totalParagraph.Format.Alignment = ParagraphAlignment.Right;
            totalParagraph.Format.Font.Bold = true;
            totalParagraph.Format.Font.Size = 12;
        }

        private void CreateFooter(Section section)
        {
            // Pie de página (se usa el objeto HeaderFooter que se alinea al final)
            Paragraph footer = section.Footers.Primary.AddParagraph();
            footer.Format.Alignment = ParagraphAlignment.Center;
            footer.Format.SpaceBefore = "1cm"; // Espacio antes del texto
            footer.AddText("¡Gracias por su compra!");
        }


        // Método para renderizar el documento de MigraDoc a PDFsharp y guardarlo
        public void GenerateAndSavePdf(string filename)
        {
            // 1. Asegurarse de que el documento ha sido creado
            CreateDocument();

            // 2. Crear el objeto renderer (se usa el constructor sin argumentos en v6.x)
            // La incrustación de fuentes (PdfFontEmbedding) se maneja implícitamente o a través de opciones.
            PdfDocumentRenderer renderer = new PdfDocumentRenderer();
            renderer.Document = DocumentoMigraDoc;

            // 3. Renderizar el documento
            renderer.RenderDocument();

            // 4. Guardar el archivo PDF
            renderer.PdfDocument.Save(filename);
        }
    }
}