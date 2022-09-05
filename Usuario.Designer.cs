
namespace InventarioApp
{
    partial class txtnombre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtCingreso = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Ingreso :";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(232, 43);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(296, 20);
            this.txtnom.TabIndex = 2;
            // 
            // txtCingreso
            // 
            this.txtCingreso.Location = new System.Drawing.Point(232, 73);
            this.txtCingreso.Name = "txtCingreso";
            this.txtCingreso.Size = new System.Drawing.Size(100, 20);
            this.txtCingreso.TabIndex = 3;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(406, 167);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(121, 71);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(565, 167);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(136, 70);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtnombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtCingreso);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txtnombre";
            this.Text = "Nombre :";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtCingreso;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

