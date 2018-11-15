namespace BulletProofRecords
{
    partial class Form1
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
            this.agregarCancionBtn = new System.Windows.Forms.Button();
            this.eliminarCancionBtn = new System.Windows.Forms.Button();
            this.listadoCancionesBtn = new System.Windows.Forms.Button();
            this.menuLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregarCancionBtn
            // 
            this.agregarCancionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarCancionBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCancionBtn.ForeColor = System.Drawing.Color.Salmon;
            this.agregarCancionBtn.Location = new System.Drawing.Point(335, 44);
            this.agregarCancionBtn.Name = "agregarCancionBtn";
            this.agregarCancionBtn.Size = new System.Drawing.Size(292, 79);
            this.agregarCancionBtn.TabIndex = 0;
            this.agregarCancionBtn.Text = "Agregar Nueva Canción";
            this.agregarCancionBtn.UseVisualStyleBackColor = true;
            this.agregarCancionBtn.Click += new System.EventHandler(this.agregarCancionBtn_Click);
            // 
            // eliminarCancionBtn
            // 
            this.eliminarCancionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarCancionBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCancionBtn.ForeColor = System.Drawing.Color.Salmon;
            this.eliminarCancionBtn.Location = new System.Drawing.Point(335, 167);
            this.eliminarCancionBtn.Name = "eliminarCancionBtn";
            this.eliminarCancionBtn.Size = new System.Drawing.Size(292, 79);
            this.eliminarCancionBtn.TabIndex = 1;
            this.eliminarCancionBtn.Text = "Eliminar Canción";
            this.eliminarCancionBtn.UseVisualStyleBackColor = true;
            this.eliminarCancionBtn.Click += new System.EventHandler(this.eliminarCancionBtn_Click);
            // 
            // listadoCancionesBtn
            // 
            this.listadoCancionesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listadoCancionesBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoCancionesBtn.ForeColor = System.Drawing.Color.Salmon;
            this.listadoCancionesBtn.Location = new System.Drawing.Point(335, 287);
            this.listadoCancionesBtn.Name = "listadoCancionesBtn";
            this.listadoCancionesBtn.Size = new System.Drawing.Size(292, 79);
            this.listadoCancionesBtn.TabIndex = 2;
            this.listadoCancionesBtn.Text = "Ver Listado de Canciones";
            this.listadoCancionesBtn.UseVisualStyleBackColor = true;
            this.listadoCancionesBtn.Click += new System.EventHandler(this.listadoCancionesBtn_Click);
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(104, 167);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(90, 39);
            this.menuLbl.TabIndex = 3;
            this.menuLbl.Text = "Menú";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(652, 396);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.listadoCancionesBtn);
            this.Controls.Add(this.eliminarCancionBtn);
            this.Controls.Add(this.agregarCancionBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarCancionBtn;
        private System.Windows.Forms.Button eliminarCancionBtn;
        private System.Windows.Forms.Button listadoCancionesBtn;
        private System.Windows.Forms.Label menuLbl;
    }
}

