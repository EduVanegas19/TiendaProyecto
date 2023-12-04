using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DataManager;

namespace TIENDA.GUI
{
    public partial class ConfigForm : Form
    {
        private readonly string nombreEmpresaDefault = "Ejemplo: Exydos Company";
        private readonly string direccionDefault = "Ejemplo: 501 W Dallas, TX, 503";
        private readonly string telefonoDefault = "Ejemplo: +1 888-751-9752";
        private readonly Color colorDefault = Color.Gray;

        private readonly DBConexion dbConexion = new DBConexion();

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Formulario de configuración cargado");

            // Cargar la configuración desde la base de datos al cargar el formulario
            CargarConfiguracionDesdeBD();

            // Actualizar los controles en la interfaz de usuario con los valores cargados
            ActualizarControles();

            Debug.WriteLine($"Nombre después de actualizar controles: {Properties.Settings.Default.NombreEmpresa}");
            Debug.WriteLine($"Dirección después de actualizar controles: {Properties.Settings.Default.DireccionEmpresa}");
            Debug.WriteLine($"Teléfono después de actualizar controles: {Properties.Settings.Default.TelefonoEmpresa}");
        }

        private void CargarConfiguracionDesdeBD()
        {
            if (dbConexion.Conectar())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("ObtenerConfiguracionEmpresa", dbConexion.ObtenerConexion()))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombreEmpresa = Convert.ToString(reader["NombreEmpresa"]);
                                string direccionEmpresa = Convert.ToString(reader["DireccionEmpresa"]);
                                string telefonoEmpresa = Convert.ToString(reader["TelefonoEmpresa"]);
                                string rutaImagenEmpresa = Convert.ToString(reader["RutaImagenEmpresa"]);

                                Debug.WriteLine($"Ruta de la imagen cargada desde la base de datos: {rutaImagenEmpresa}");

                                Properties.Settings.Default.RutaImagenEmpresa = rutaImagenEmpresa;

                                Properties.Settings.Default.NombreEmpresa = nombreEmpresa;
                                Properties.Settings.Default.DireccionEmpresa = direccionEmpresa;
                                Properties.Settings.Default.TelefonoEmpresa = telefonoEmpresa;

                                Properties.Settings.Default.Save();

                                Debug.WriteLine($"Nombre cargado desde la base de datos: {Properties.Settings.Default.NombreEmpresa}");
                                Debug.WriteLine($"Dirección cargada desde la base de datos: {Properties.Settings.Default.DireccionEmpresa}");
                                Debug.WriteLine($"Teléfono cargado desde la base de datos: {Properties.Settings.Default.TelefonoEmpresa}");
                                Debug.WriteLine($"Ruta de imagen cargada desde la base de datos: {Properties.Settings.Default.RutaImagenEmpresa}");
                            }
                            else
                            {
                                Debug.WriteLine("No se encontraron datos en la base de datos.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error al cargar configuración desde la base de datos: {ex.Message}");
                }
                finally
                {
                    dbConexion.Desconectar();
                }
            }
            else
            {
                Debug.WriteLine("No se pudo conectar a la base de datos.");
            }
        }

        private void MostrarImagenDesdeConfiguracion()
        {
            // Mostrar la imagen si la ruta de la imagen no está vacía
            if (!string.IsNullOrEmpty(Properties.Settings.Default.RutaImagenEmpresa))
            {
                MostrarImagen(Properties.Settings.Default.RutaImagenEmpresa);
            }
            else
            {
                // Si la ruta de la imagen está vacía, puedes restablecer el PictureBox
                pictureBoxEmpresa.Image = null;
            }
        }

        private bool ConfiguracionEnBaseDeDatosExiste()
        {
            if (dbConexion.Conectar())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM empresa", dbConexion.ObtenerConexion()))
                    {
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores aquí
                    Debug.WriteLine($"Error al verificar la existencia de configuración en la base de datos: {ex.Message}");
                    return false;
                }
                finally
                {
                    dbConexion.Desconectar();
                }
            }
            else
            {
                Debug.WriteLine("No se pudo conectar a la base de datos.");
                return false;
            }
        }

        private bool ConfiguracionModificada()
        {
            // Verificar si la configuración ha sido modificada
            return !string.IsNullOrEmpty(Properties.Settings.Default.NombreEmpresa);
        }

        private void ActualizarControles()
        {
            // Actualizar los controles en la interfaz de usuario con los valores cargados
            txtNombre.Text = Properties.Settings.Default.NombreEmpresa;
            txtDireccion.Text = Properties.Settings.Default.DireccionEmpresa;
            txtTelefono.Text = Properties.Settings.Default.TelefonoEmpresa;

            // Mostrar la imagen desde la configuración
            MostrarImagenDesdeConfiguracion();

            Debug.WriteLine("Controles actualizados.");
            Debug.WriteLine($"Nombre después de actualizar controles: {txtNombre.Text}");
            Debug.WriteLine($"Dirección después de actualizar controles: {txtDireccion.Text}");
            Debug.WriteLine($"Teléfono después de actualizar controles: {txtTelefono.Text}");
        }

        private void MostrarImagen(string rutaImagen)
        {
            try
            {
                // Verificar si la ruta almacenada no es nula o vacía
                if (!string.IsNullOrEmpty(rutaImagen))
                {
                    // Combinar la ruta almacenada con el directorio de trabajo
                    string rutaCompleta = Path.Combine(Environment.CurrentDirectory, rutaImagen);

                    Debug.WriteLine($"Ruta completa de la imagen: {rutaCompleta}");

                    if (File.Exists(rutaCompleta))
                    {
                        pictureBoxEmpresa.Image = Image.FromFile(rutaCompleta);
                    }
                    else
                    {
                        Debug.WriteLine("La ruta de la imagen no es válida o el archivo no existe.");
                    }
                }
                else
                {
                    Debug.WriteLine("La ruta de la imagen almacenada en la base de datos es nula o vacía.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al cargar la imagen: {ex.Message}");
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccionar Imagen de la Empresa";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta de la imagen seleccionada
                    string rutaImagen = openFileDialog.FileName;

                    // Mostrar la imagen en el PictureBox
                    pictureBoxEmpresa.Image = Image.FromFile(rutaImagen);

                    // Guardar la ruta de la imagen seleccionada en la configuración
                    Properties.Settings.Default.RutaImagenEmpresa = rutaImagen;
                    Properties.Settings.Default.Save();

                    // También, guarda los valores en la base de datos después de seleccionar la imagen
                    GuardarConfiguracionEnBD(
                        Properties.Settings.Default.NombreEmpresa,
                        Properties.Settings.Default.DireccionEmpresa,
                        Properties.Settings.Default.TelefonoEmpresa,
                        Properties.Settings.Default.RutaImagenEmpresa);
                }
            }
        }

        private void GuardarConfiguracionEnBD(string nombreEmpresa, string direccionEmpresa, string telefonoEmpresa, string rutaImagenEmpresa)
        {
            Console.WriteLine("Guardando configuración en la base de datos...");

            // Verificar si la ruta de la imagen es nula antes de guardarla
            if (rutaImagenEmpresa == null)
            {
                rutaImagenEmpresa = string.Empty; // o el valor predeterminado que desees
            }

            if (dbConexion.Conectar())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("GuardarConfiguracionEmpresa", dbConexion.ObtenerConexion()))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreEmpresa", nombreEmpresa);
                        command.Parameters.AddWithValue("@DireccionEmpresa", direccionEmpresa);
                        command.Parameters.AddWithValue("@TelefonoEmpresa", telefonoEmpresa);
                        command.Parameters.AddWithValue("@RutaImagenEmpresa", (object)rutaImagenEmpresa ?? DBNull.Value);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        Console.WriteLine($"Index #{i}\n" +
                                          $"Error Number: {ex.Errors[i].Number}\n" +
                                          $"State: {ex.Errors[i].State}\n" +
                                          $"Class: {ex.Errors[i].Class}\n" +
                                          $"Message: {ex.Errors[i].Message}\n" +
                                          $"LineNumber: {ex.Errors[i].LineNumber}\n" +
                                          $"Source: {ex.Errors[i].Source}\n" +
                                          $"Procedure: {ex.Errors[i].Procedure}\n\n");
                    }
                }
                catch (Exception ex)
                {
                    // Manejar otros tipos de errores
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dbConexion.Desconectar();
                }
            }

            Console.WriteLine("Configuración guardada en la base de datos.");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guardar los valores ingresados por el usuario en la configuración
            Properties.Settings.Default.NombreEmpresa = txtNombre.Text;
            Properties.Settings.Default.DireccionEmpresa = txtDireccion.Text;
            Properties.Settings.Default.TelefonoEmpresa = txtTelefono.Text;

            // Guardar los cambios en la configuración
            Properties.Settings.Default.Save();

            // Guardar la configuración en la base de datos
            GuardarConfiguracionEnBD(
                Properties.Settings.Default.NombreEmpresa,
                Properties.Settings.Default.DireccionEmpresa,
                Properties.Settings.Default.TelefonoEmpresa,
                Properties.Settings.Default.RutaImagenEmpresa);

            // Cerrar la ventana de configuración
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(txtNombre, nombreEmpresaDefault);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(txtNombre, nombreEmpresaDefault);
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(txtDireccion, direccionDefault);
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(txtDireccion, direccionDefault);
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(txtTelefono, telefonoDefault);
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(txtTelefono, telefonoDefault);
        }

        private void TextBox_Enter(TextBox textBox, string valorDefault)
        {
            if (textBox.Text == valorDefault)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void TextBox_Leave(TextBox textBox, string valorDefault)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = valorDefault;
                textBox.ForeColor = colorDefault;
            }
        }
    }
}
