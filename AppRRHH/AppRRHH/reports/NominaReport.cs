using AppRRHH.models;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace AppRRHH.reports
{
    public class NominaReport
    {
        public static void Generar(Nomina nomina, Empleado empleado, Empresa empresa)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var documento = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Content().Column(col =>
                    {
                        // Cabecera empresa
                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text(empresa.Nombre).Bold().FontSize(14);
                                c.Item().Text($"CIF: {empresa.CIF}");
                                c.Item().Text($"Dirección: {empresa.Direccion}");
                                c.Item().Text($"Municipio: {empresa.Municipio} {empresa.CodigoPostal}");
                                c.Item().Text($"Nº Cuenta Cotización: {empresa.NumCuentaCotizacion}");
                            });

                            row.RelativeItem().AlignRight().Column(c =>
                            {
                                c.Item().Text("RECIBO DE SALARIO").Bold().FontSize(14);
                                c.Item().Text($"Periodo: {nomina.Mes} {nomina.Anio}");
                                c.Item().Text($"Fecha pago: {nomina.FechaPago:dd/MM/yyyy}");
                            });
                        });

                        col.Item().PaddingVertical(10).LineHorizontal(1);

                        // Datos empleado
                        col.Item().Background("#f0f0f0").Padding(8).Column(c =>
                        {
                            c.Item().Text("DATOS DEL TRABAJADOR").Bold();
                            c.Item().Row(r =>
                            {
                                r.RelativeItem().Text($"Nombre: {empleado.NombreCompleto()}");
                                r.RelativeItem().Text($"DNI: {empleado.DNI}");
                            });
                            c.Item().Row(r =>
                            {
                                r.RelativeItem().Text($"Nº SS: {empleado.NumSegSocial}");
                                r.RelativeItem().Text($"Categoría: {empleado.CategoriaProfesional}");
                            });
                            c.Item().Row(r =>
                            {
                                r.RelativeItem().Text($"Tipo contrato: {empleado.TipoContrato}");
                                r.RelativeItem().Text($"Antigüedad: {empleado.Antiguedad} años");
                            });
                        });

                        col.Item().PaddingVertical(10);

                        // Devengos
                        col.Item().Text("DEVENGOS").Bold();
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(c =>
                            {
                                c.RelativeColumn(3);
                                c.RelativeColumn(1);
                            });

                            table.Header(h =>
                            {
                                h.Cell().Background("#333333").Padding(5).Text("Concepto").FontColor("#ffffff").Bold();
                                h.Cell().Background("#333333").Padding(5).AlignRight().Text("Importe").FontColor("#ffffff").Bold();
                            });

                            table.Cell().Padding(5).Text("Salario Base");
                            table.Cell().Padding(5).AlignRight().Text($"{nomina.SalarioBase:C}");

                            table.Cell().Padding(5).Text($"Horas Extra ({nomina.HorasExtra}h)");
                            table.Cell().Padding(5).AlignRight().Text($"{nomina.HorasExtraImporte:C}");

                            table.Cell().Padding(5).Text("Plus Nocturnidad");
                            table.Cell().Padding(5).AlignRight().Text($"{nomina.PlusNocturnidad:C}");

                            table.Cell().Padding(5).Text("Plus Festivo");
                            table.Cell().Padding(5).AlignRight().Text($"{nomina.PlusFestivo:C}");

                            table.Cell().Padding(5).Text("Plus Transporte");
                            table.Cell().Padding(5).AlignRight().Text($"{nomina.PlusTransporte:C}");

                            table.Cell().Background("#e0e0e0").Padding(5).Text("TOTAL DEVENGADO").Bold();
                            table.Cell().Background("#e0e0e0").Padding(5).AlignRight().Text($"{nomina.TotalDevengado:C}").Bold();
                        });

                        col.Item().PaddingVertical(10);

                        // Deducciones
                        col.Item().Text("DEDUCCIONES").Bold();
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(c =>
                            {
                                c.RelativeColumn(3);
                                c.RelativeColumn(1);
                            });

                            table.Header(h =>
                            {
                                h.Cell().Background("#333333").Padding(5).Text("Concepto").FontColor("#ffffff").Bold();
                                h.Cell().Background("#333333").Padding(5).AlignRight().Text("Importe").FontColor("#ffffff").Bold();
                            });

                            table.Cell().Padding(5).Text($"IRPF ({nomina.PorcentajeIRPF}%)");
                            table.Cell().Padding(5).AlignRight().Text($"-{nomina.ImporteIRPF:C}");

                            table.Cell().Padding(5).Text("Contingencias Comunes (4.7%)");
                            table.Cell().Padding(5).AlignRight().Text($"-{nomina.ContingenciasComunes:C}");

                            table.Cell().Padding(5).Text("Desempleo (1.55%)");
                            table.Cell().Padding(5).AlignRight().Text($"-{nomina.Desempleo:C}");

                            table.Cell().Padding(5).Text("Formación Profesional (0.1%)");
                            table.Cell().Padding(5).AlignRight().Text($"-{nomina.FormacionProfesional:C}");

                            table.Cell().Background("#e0e0e0").Padding(5).Text("TOTAL DEDUCCIONES").Bold();
                            table.Cell().Background("#e0e0e0").Padding(5).AlignRight().Text($"-{nomina.TotalDeducciones:C}").Bold();
                        });

                        col.Item().PaddingVertical(10).LineHorizontal(2);

                        // Líquido
                        col.Item().Background("#1a1a2e").Padding(10).Row(r =>
                        {
                            r.RelativeItem().Text("LÍQUIDO A PERCIBIR").Bold().FontSize(14).FontColor("#ffffff");
                            r.RelativeItem().AlignRight().Text($"{nomina.LiquidoAPercibir:C}").Bold().FontSize(14).FontColor("#ffffff");
                        });

                        col.Item().PaddingVertical(20);

                        // Firma
                        col.Item().Row(r =>
                        {
                            r.RelativeItem().Column(c =>
                            {
                                c.Item().Text("Firma empresa:");
                                c.Item().PaddingTop(40).LineHorizontal(1);
                            });
                            r.RelativeItem().Column(c =>
                            {
                                c.Item().Text("Firma trabajador:");
                                c.Item().PaddingTop(40).LineHorizontal(1);
                            });
                        });
                    });
                });
            });

            // Guardar el PDF
            var saveDialog = new SaveFileDialog
            {
                FileName = $"Nomina_{empleado.DNI}_{nomina.Mes}_{nomina.Anio}.pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Guardar nómina"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                documento.GeneratePdf(saveDialog.FileName);
                MessageBox.Show("Nómina generada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el PDF automáticamente
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = saveDialog.FileName,
                    UseShellExecute = true
                });
            }
        }
    }
}
