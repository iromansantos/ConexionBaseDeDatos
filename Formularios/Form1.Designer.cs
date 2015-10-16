namespace ConexionBaseDeDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btBusqueda = new System.Windows.Forms.Button();
            this.dgResultadosBusqueda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultadosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btBusqueda
            // 
            this.btBusqueda.Location = new System.Drawing.Point(618, 18);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btBusqueda.TabIndex = 0;
            this.btBusqueda.Text = "&Busqueda";
            this.btBusqueda.UseVisualStyleBackColor = true;
            this.btBusqueda.Click += new System.EventHandler(this.btBusqueda_Click);
            // 
            // dgResultadosBusqueda
            // 
            this.dgResultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultadosBusqueda.Location = new System.Drawing.Point(39, 45);
            this.dgResultadosBusqueda.Name = "dgResultadosBusqueda";
            this.dgResultadosBusqueda.Size = new System.Drawing.Size(654, 276);
            this.dgResultadosBusqueda.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 333);
            this.Controls.Add(this.dgResultadosBusqueda);
            this.Controls.Add(this.btBusqueda);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgResultadosBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBusqueda;
        private System.Windows.Forms.DataGridView dgResultadosBusqueda;
    }
}

