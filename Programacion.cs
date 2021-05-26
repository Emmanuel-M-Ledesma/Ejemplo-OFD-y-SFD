using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime;


namespace WindowsFormsApp2
{
    public partial class Programacion : Form
    {
        public Programacion()
        {
            InitializeComponent();
            

            
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Seleccionar Archivo";
                openFileDialog1.InitialDirectory = "C://Users/Emale/Desktop/Itsc- 2 año";
                openFileDialog1.Filter = "Archivos de texto(*.txt)|*.txt";
                openFileDialog1.AddExtension = true;
                openFileDialog1.FileName = "";
                openFileDialog1.ShowDialog();
                
                string ejemplo2 = openFileDialog1.FileName;
                if (File.Exists(openFileDialog1.FileName))
                {

                    TextReader read = new StreamReader(ejemplo2);
                    txtText.Text = read.ReadToEnd();
                    read.Close();



                }
                txtDireccion.Text = ejemplo2;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Abrir");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos de texto(*.txt)|*.txt";
            saveFileDialog1.FileName = DateTime.Now.ToString("dd-MM-yy HH-mm");
            saveFileDialog1.CreatePrompt = false;
            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog1.FileName))
                {

                    string ejemplo = saveFileDialog1.FileName;
                    StreamWriter Archivo = File.CreateText(ejemplo);
                    Archivo.Write(txtText.Text);
                    Archivo.Flush();
                    Archivo.Close();

                    txtDireccion.Text = ejemplo;
                    
                }
                else
                {
                    string ejemplo = saveFileDialog1.FileName;
                    StreamWriter Archivo = File.CreateText(ejemplo);
                    Archivo.Write(txtText.Text);
                    Archivo.Flush();
                    Archivo.Close();

                    txtDireccion.Text = ejemplo;

                }

            }
            
            
        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
            txtText.Text = "";
        }

       
    }
}
