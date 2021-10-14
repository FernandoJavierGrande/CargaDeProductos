
namespace TrabajoPractico3beta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_categoriaProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPrecioFinal = new System.Windows.Forms.Button();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPrecioFinal = new System.Windows.Forms.Label();
            this.txt_PrecioBruto = new System.Windows.Forms.TextBox();
            this.label_prueba = new System.Windows.Forms.Label();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            this.cmb_iva = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese los datos solicitados\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio bruto";
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Location = new System.Drawing.Point(43, 224);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(138, 22);
            this.txt_NombreProducto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre del producto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.gestionarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.calcularToolStripMenuItem.Text = " Calcular y guardar";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // txt_categoriaProducto
            // 
            this.txt_categoriaProducto.Location = new System.Drawing.Point(46, 296);
            this.txt_categoriaProducto.Name = "txt_categoriaProducto";
            this.txt_categoriaProducto.Size = new System.Drawing.Size(138, 22);
            this.txt_categoriaProducto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // buttonPrecioFinal
            // 
            this.buttonPrecioFinal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPrecioFinal.Location = new System.Drawing.Point(348, 141);
            this.buttonPrecioFinal.Name = "buttonPrecioFinal";
            this.buttonPrecioFinal.Size = new System.Drawing.Size(103, 42);
            this.buttonPrecioFinal.TabIndex = 10;
            this.buttonPrecioFinal.Text = "Precio final";
            this.buttonPrecioFinal.UseVisualStyleBackColor = true;
            this.buttonPrecioFinal.Click += new System.EventHandler(this.precioFinal_Click);
            // 
            // boton_guardar
            // 
            this.boton_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_guardar.Location = new System.Drawing.Point(79, 402);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(241, 74);
            this.boton_guardar.TabIndex = 11;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio final: $";
            // 
            // labelPrecioFinal
            // 
            this.labelPrecioFinal.AutoSize = true;
            this.labelPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioFinal.Location = new System.Drawing.Point(636, 153);
            this.labelPrecioFinal.Name = "labelPrecioFinal";
            this.labelPrecioFinal.Size = new System.Drawing.Size(0, 20);
            this.labelPrecioFinal.TabIndex = 13;
            // 
            // txt_PrecioBruto
            // 
            this.txt_PrecioBruto.Location = new System.Drawing.Point(46, 153);
            this.txt_PrecioBruto.Name = "txt_PrecioBruto";
            this.txt_PrecioBruto.Size = new System.Drawing.Size(138, 22);
            this.txt_PrecioBruto.TabIndex = 14;
            // 
            // label_prueba
            // 
            this.label_prueba.AutoSize = true;
            this.label_prueba.Location = new System.Drawing.Point(529, 243);
            this.label_prueba.Name = "label_prueba";
            this.label_prueba.Size = new System.Drawing.Size(91, 17);
            this.label_prueba.TabIndex = 15;
            this.label_prueba.Text = "label_prueba";
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Location = new System.Drawing.Point(416, 423);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(79, 32);
            this.BotonLimpiar.TabIndex = 16;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // cmb_iva
            // 
            this.cmb_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_iva.FormattingEnabled = true;
            this.cmb_iva.Items.AddRange(new object[] {
            "21%",
            "10.5%",
            "27%",
            "4%"});
            this.cmb_iva.Location = new System.Drawing.Point(215, 151);
            this.cmb_iva.Name = "cmb_iva";
            this.cmb_iva.Size = new System.Drawing.Size(105, 24);
            this.cmb_iva.TabIndex = 17;
            this.cmb_iva.SelectionChangeCommitted += new System.EventHandler(this.cmb_iva_SelectionChangeCommited);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Seleccione el Iva";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "Alimentos",
            "Bebidas",
            "Higiene personal",
            "Limpieza",
            "Ferreteria"});
            this.cmb_categoria.Location = new System.Drawing.Point(224, 294);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(142, 24);
            this.cmb_categoria.TabIndex = 19;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Seleccione Categoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 543);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_iva);
            this.Controls.Add(this.BotonLimpiar);
            this.Controls.Add(this.label_prueba);
            this.Controls.Add(this.txt_PrecioBruto);
            this.Controls.Add(this.labelPrecioFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.buttonPrecioFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_categoriaProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 590);
            this.MinimumSize = new System.Drawing.Size(920, 590);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Y Guardar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_categoriaProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrecioFinal;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPrecioFinal;
        private System.Windows.Forms.TextBox txt_PrecioBruto;
        private System.Windows.Forms.Label label_prueba;
        private System.Windows.Forms.Button BotonLimpiar;
        private System.Windows.Forms.ComboBox cmb_iva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label8;
    }
}

