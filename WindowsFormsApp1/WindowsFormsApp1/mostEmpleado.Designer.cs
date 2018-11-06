namespace WindowsFormsApp1
{
    partial class mostEmpleado
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
            this.infoEmpleado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // infoEmpleado
            // 
            this.infoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoEmpleado.Location = new System.Drawing.Point(51, 68);
            this.infoEmpleado.Name = "infoEmpleado";
            this.infoEmpleado.Size = new System.Drawing.Size(637, 180);
            this.infoEmpleado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de Empleado:";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(162, 30);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 20);
            this.Codigo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(268, 28);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Mostrar.TabIndex = 4;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Modificar...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Eliminar...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // mostEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 351);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoEmpleado);
            this.MaximizeBox = false;
            this.Name = "mostEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mostEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.infoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}