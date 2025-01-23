namespace Semana_Proyecto_Colas {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnVistazo = new System.Windows.Forms.Button();
            this.btnElementos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.listBoxNombre = new System.Windows.Forms.ListBox();
            this.btnDestruir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLA";
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(57, 162);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(94, 23);
            this.btnEncolar.TabIndex = 1;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(57, 221);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(94, 23);
            this.btnDesencolar.TabIndex = 2;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click_1);
            // 
            // btnVistazo
            // 
            this.btnVistazo.Location = new System.Drawing.Point(57, 279);
            this.btnVistazo.Name = "btnVistazo";
            this.btnVistazo.Size = new System.Drawing.Size(94, 23);
            this.btnVistazo.TabIndex = 3;
            this.btnVistazo.Text = "Vistazo";
            this.btnVistazo.UseVisualStyleBackColor = true;
            this.btnVistazo.Click += new System.EventHandler(this.btnVistazo_Click);
            // 
            // btnElementos
            // 
            this.btnElementos.Location = new System.Drawing.Point(57, 335);
            this.btnElementos.Name = "btnElementos";
            this.btnElementos.Size = new System.Drawing.Size(94, 38);
            this.btnElementos.TabIndex = 4;
            this.btnElementos.Text = "Cantidad De Elementos";
            this.btnElementos.UseVisualStyleBackColor = true;
            this.btnElementos.Click += new System.EventHandler(this.btnElementos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresar Nombres";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(233, 97);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 6;
            // 
            // listBoxNombre
            // 
            this.listBoxNombre.FormattingEnabled = true;
            this.listBoxNombre.Location = new System.Drawing.Point(233, 162);
            this.listBoxNombre.Name = "listBoxNombre";
            this.listBoxNombre.Size = new System.Drawing.Size(144, 251);
            this.listBoxNombre.TabIndex = 7;
            // 
            // btnDestruir
            // 
            this.btnDestruir.Location = new System.Drawing.Point(57, 400);
            this.btnDestruir.Name = "btnDestruir";
            this.btnDestruir.Size = new System.Drawing.Size(94, 23);
            this.btnDestruir.TabIndex = 8;
            this.btnDestruir.Text = "Destruir";
            this.btnDestruir.UseVisualStyleBackColor = true;
            this.btnDestruir.Click += new System.EventHandler(this.btnDestruir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 525);
            this.Controls.Add(this.btnDestruir);
            this.Controls.Add(this.listBoxNombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnElementos);
            this.Controls.Add(this.btnVistazo);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnVistazo;
        private System.Windows.Forms.Button btnElementos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.ListBox listBoxNombre;
        private System.Windows.Forms.Button btnDestruir;
    }
}

