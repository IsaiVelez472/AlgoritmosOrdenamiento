

using System.Runtime.CompilerServices;

namespace Documentos
{
    public class Documento
    {
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String Nombre { get; set; }
        public String TipoDocumento { get; set; }

        public String NombreCompleto
        {
            get
            {
                return
                    Apellido1 + " " +
                    Apellido2 + " " +
                    Nombre;
            }
        }

        public static List<Documento> documentos;

        public static void DesdeArchivo(String nombreArchivo)
        {
            documentos = new List<Documento>();
            StreamReader sr = Archivo.AbrirArchivo(nombreArchivo);

            if (sr != null)
            {
                String linea = sr.ReadLine();
                linea = sr.ReadLine();
                while (linea != null)
                {
                    String[] datos = linea.Split(';');
                    if (datos.Length >= 4)
                    {
                        Documento documento = new Documento();
                        documento.Apellido1 = datos[0];
                        documento.Apellido2 = datos[1];
                        documento.Nombre = datos[2];
                        documento.TipoDocumento = datos[3];
                        documentos.Add(documento);
                    }
                    linea = sr.ReadLine();
                }
            }
        }

        public static void Mostrar(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("Apellido 1", "Apellido 1");
            dgv.Columns.Add("Apellido 2", "Apellido 2");
            dgv.Columns.Add("Nombre", "Nombre");
            dgv.Columns.Add("Documento", "Documento");

            dgv.Rows.Add(documentos.Count);
            int fila = 0;
            foreach (Documento documento in documentos)
            {
                //dgv.Rows.Add();
                dgv.Rows[fila].Cells[0].Value = documento.Apellido1;
                dgv.Rows[fila].Cells[1].Value = documento.Apellido2;
                dgv.Rows[fila].Cells[2].Value = documento.Nombre;
                dgv.Rows[fila].Cells[3].Value = documento.TipoDocumento;
                fila++;
            }
        }

        // Método para intercambiar elementos
        private static void Intercambiar(int origen, int destino)
        {
            Documento temporal = documentos[origen];
            documentos[origen] = documentos[destino];
            documentos[destino] = temporal;
        }

        private static bool EsMayor(Documento d1, Documento d2, int criterio)
        {
            if (criterio == 0)
            {
                // Ordenar primero por Nombre Completo y luego por Tipo de Documento
                return (string.Compare(d1.NombreCompleto, d2.NombreCompleto) > 0 ||
                        (d1.NombreCompleto == d2.NombreCompleto &&
                         string.Compare(d1.TipoDocumento, d2.TipoDocumento) > 0));
            }
            else
            {
                // Ordenar primero por Tipo de Documento y luego por Nombre Completo
                return (string.Compare(d1.TipoDocumento, d2.TipoDocumento) > 0 ||
                        (d1.TipoDocumento == d2.TipoDocumento &&
                         string.Compare(d1.NombreCompleto, d2.NombreCompleto) > 0));
            }
        }

        public static void OrdenarBurbuja(int criterio)
        {
            for (int i = 0; i < Documento.documentos.Count - 1; i++)
            {
                for (int j = i + 1; j < Documento.documentos.Count; j++)
                {
                    if (EsMayor(documentos[i], documentos[j], criterio))
                    {
                        Intercambiar(i, j);
                    }
                }
            }
        }

        private static int ObtenerPivote(int inicio, int fin, int criterio)
        {
            int pivote = inicio;

            Documento documentoPivote = documentos[pivote];
            for (int i = inicio + 1; i <= fin; i++)
            {
                if (EsMayor(documentoPivote, documentos[i], criterio))
                {
                    Intercambiar(i, pivote);
                    pivote++;
                }
            }
            return pivote;
        }

        public static void OrdenarRapido(int inicio, int fin, int criterio)
        {
            if (inicio >= fin)
            {
                return;
            }
            int pivote = ObtenerPivote(inicio, fin, criterio);
            OrdenarRapido(inicio, pivote - 1, criterio);
            OrdenarRapido(pivote + 1, fin, criterio);
        }

        public static void OrdenarPorInsecion(int criterio)
        {
            if (criterio == 0)
            {
                documentos.Sort((d1, d2) =>
                {
                    int result = string.Compare(d1.NombreCompleto, d2.NombreCompleto);
                    if (result == 0)
                    {
                        result = string.Compare(d1.TipoDocumento, d2.TipoDocumento);
                    }
                    return result;
                });
            }
            else
            {
                documentos.Sort((d1, d2) =>
                {
                    int result = string.Compare(d1.TipoDocumento, d2.TipoDocumento);
                    if (result == 0)
                    {
                        result = string.Compare(d1.NombreCompleto, d2.NombreCompleto);
                    }
                    return result;
                });
            }
        }

        public static void OrdenarPorMezcla(int criterio)
        {
            documentos = MergeSort(documentos, criterio);
        }

        public static List<Documento> MergeSort(List<Documento> lista, int criterio)
        {
            if (lista.Count <= 1) return lista;

            int mid = lista.Count / 2;
            var left = lista.GetRange(0, mid);
            var right = lista.GetRange(mid, lista.Count - mid);

            left = MergeSort(left, criterio);
            right = MergeSort(right, criterio);

            return Merge(left, right, criterio);
        }

        private static List<Documento> Merge(List<Documento> left, List<Documento> right, int criterio)
        {
            List<Documento> result = new List<Documento>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                Documento d1 = left[i];
                Documento d2 = right[j];
                int comparison;

                if (criterio == 0)
                {
                    comparison = string.Compare(d1.NombreCompleto, d2.NombreCompleto);
                    if (comparison == 0)
                    {
                        comparison = string.Compare(d1.TipoDocumento, d2.TipoDocumento);
                    }
                }
                else
                {
                    comparison = string.Compare(d1.TipoDocumento, d2.TipoDocumento);
                    if (comparison == 0)
                    {
                        comparison = string.Compare(d1.NombreCompleto, d2.NombreCompleto);
                    }
                }

                if (comparison <= 0)
                {
                    result.Add(d1);
                    i++;
                }
                else
                {
                    result.Add(d2);
                    j++;
                }
            }

            result.AddRange(left.GetRange(i, left.Count - i));
            result.AddRange(right.GetRange(j, right.Count - j));

            return result;
        }
    }
}
