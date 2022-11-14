using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] files;
            string ruta2;
            try
            {
                files = Directory.GetFiles(@txtPath.Text, "*.pdf");
                if (files.Length > 0)
                {
                    foreach (var file in files)
                    {
                        ruta2 = @txtPath.Text + "\\" + Path.GetFileName(file).Substring(Convert.ToInt32(txtIni.Text), Convert.ToInt32(txtFin.Text)) + ".pdf"; //Archivo renombrado
                        try
                        {
                            if (!File.Exists(ruta2))
                            {
                                File.Move(file, ruta2);
                                LblMensaje.Text = "SE HA RENOMBRADO EL ARCHIVO ORIGINAL";
                            }
                            else
                            {
                                //Si el archivo existe entonces se agrega un distintivo  "_1"
                                ruta2 = @txtPath.Text + "\\" + Path.GetFileName(file).Substring(Convert.ToInt32(txtIni.Text), Convert.ToInt32(txtFin.Text)) + "_1.pdf"; //Archivo renombrado
                                File.Move(file, ruta2);
                                LblMensaje.Text = "SE HA RENOMBRADO EL ARCHIVO ORIGINAL";
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            LblMensaje.Text = "Error al renombrar archivo: {0}" + ex.ToString();
                        }


                    }
                }
                else
                {
                    LblMensaje.Text = "NO EXISTEN ARCHIVOS EN EL DIRECTORIO";
                }
            }
            catch(Exception ex)
            {
                LblMensaje.Text =  ex.Message;
            }
            
        }



        private void btnClonar_Click(object sender, EventArgs e)
        {
            string[] files;
            LblMensaje.Text = "";
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              
                    try
                    {
                    string sourceDir = @txtPath.Text;
                    string backupDir = txtPathSalida.Text;
                    files = Directory.GetFiles(@txtPath.Text, "*.pdf");
                    string rutaArchivo = openFileDialog1.FileName;
                    if (files.Length > 0)
                    {
                       
                        List<string[]> testParse = parseCSV(rutaArchivo);
                        
                        foreach (string[] i in testParse)
                        {
                            string fName = i[0] + ".pdf";
                            try
                            {
                                if(File.Exists(sourceDir + "/" + fName))
                                {
                                    // Will not overwrite if the destination file already exists.
                                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                                }
                               
                            }

                            // Catch exception if the file was already copied.
                            catch (IOException copyError)
                            {
                                MessageBox.Show(copyError.Message);
                            }
                        }
                        LblMensaje.Text = "*** FINALIZADO CON EXITO Y SIN ERRORES ***";
                    }
                    else
                    {
                        LblMensaje.Text = "NO EXISTEN ARCHIVOS EN EL DIRECTORIO";
                    }


                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


               
            }
        }

        public List<string[]> parseCSV(string path)
        {
            List<string[]> parsedData = new List<string[]>();

            using (StreamReader readFile = new StreamReader(path))
            {
                string line;
                string[] row;

                while ((line = readFile.ReadLine()) != null)
                {
                    row = line.Split(',');
                    parsedData.Add(row);
                }
            }
            return parsedData;
        }
    }
}
