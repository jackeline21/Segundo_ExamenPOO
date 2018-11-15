namespace BulletProofRecords
{
    partial class Listar_Eliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // listarBtn
            // 
            this.listarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listarBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarBtn.ForeColor = System.Drawing.Color.LightCoral;
            this.listarBtn.Location = new System.Drawing.Point(101, 35);
            this.listarBtn.Name = "listarBtn";
            this.listarBtn.Size = new System.Drawing.Size(171, 48);
            this.listarBtn.TabIndex = 1;
            this.listarBtn.Text = "Listar";
            this.listarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.ForeColor = System.Drawing.Color.LightCoral;
            this.EliminarBtn.Location = new System.Drawing.Point(382, 35);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(171, 48);
            this.EliminarBtn.TabIndex = 2;
            this.EliminarBtn.Text = "ELiminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // Listar_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.listarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listar_Eliminar";
            this.Text = "Listar_Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listarBtn;
        private System.Windows.Forms.Button EliminarBtn;
    }
}