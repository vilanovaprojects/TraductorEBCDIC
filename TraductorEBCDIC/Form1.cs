using System.Security.Cryptography;

namespace TraductorEBCDIC
{
    public partial class Form1 : Form
    {
        private bool archivocargado = false;
        private byte[]? data;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            archivocargado = false;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Seleccione un archivo";
            dialog.InitialDirectory = "C:";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = dialog.FileName;
                long tamanoArchivoBytes = new FileInfo(archivoSeleccionado).Length;       // Validar el tamaño del archivo en bytes
                long tamanoArchivoKB = tamanoArchivoBytes / 1024;                                   // Convertir bytes a kilobytes (KB)
                long limiteTamanoKB = 40;                                                           // Establecer el límite de tamaño permitido en KB (50 KB en este ejemplo)

                if (tamanoArchivoKB > limiteTamanoKB)
                {
                    MessageBox.Show("El archivo seleccionado excede el límite de tamaño permitido de " + limiteTamanoKB + " KB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    archivocargado = true;

                    data = File.ReadAllBytes(archivoSeleccionado);

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (archivocargado)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    switch (data[i])
                    {
                        case 0x31:
                            data[i] = 0x32;
                            break;
                        case 0x32:
                            data[i] = 0x33;
                            break;
                        case 0x33:
                            data[i] = 0x34;
                            break;
                        case 0x34:
                            data[i] = 0x35;
                            break;
                        case 0x35:
                            data[i] = 0x36;
                            break;
                        case 0x36:
                            data[i] = 0x37;
                            break;
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (archivocargado)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Guardar Archivo";
                saveDialog.Filter = "Archivos binarios (*.bin)|*.bin|Todos los archivos (*.*)|*.*"; // Filtro para mostrar solo archivos binarios
                saveDialog.FileName = "archivo_modificado.bin"; // Nombre predeterminado del archivo

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveDialog.FileName;

                    // Guardar el arreglo de bytes en el archivo seleccionado
                    File.WriteAllBytes(rutaArchivo, data);

                    MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
