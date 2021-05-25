using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Users/Emale/Desktop/Itsc- 2 año";
            openFileDialog1.Filter = "Archivos de texto(*.txt)|*.txt";
            //openFileDialog1.Filter = "Archivos JPEG(*.jpeg)|*.jpeg";
            openFileDialog1.AddExtension = true;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblRuta.Text = openFileDialog1.FileName;
                txtText.Text = openFileDialog1.FileName;    
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos de texto(*.txt)|*.txt";
            saveFileDialog1.FileName = "";            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)    
            {

            }
        }
    }
}
