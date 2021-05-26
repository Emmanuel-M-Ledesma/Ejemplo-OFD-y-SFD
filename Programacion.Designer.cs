
namespace WindowsFormsApp2
{
    partial class Programacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAbrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btGuardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAbrir
            // 
            this.btAbrir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btAbrir.Location = new System.Drawing.Point(250, 44);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 0;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btGuardar.Location = new System.Drawing.Point(250, 15);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(12, 61);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(222, 154);
            this.txtText.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(70, 17);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(164, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Direccion";
            // 
            // btborrar
            // 
            this.btborrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btborrar.Location = new System.Drawing.Point(250, 74);
            this.btborrar.Name = "btborrar";
            this.btborrar.Size = new System.Drawing.Size(75, 23);
            this.btborrar.TabIndex = 6;
            this.btborrar.Text = "Borrar";
            this.btborrar.UseVisualStyleBackColor = true;
            this.btborrar.Click += new System.EventHandler(this.btborrar_Click);
            // 
            // Programacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 239);
            this.Controls.Add(this.btborrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btAbrir);
            this.MinimumSize = new System.Drawing.Size(353, 278);
            this.Name = "Programacion";
            this.Text = "Programacion  2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btborrar;
    }
}

