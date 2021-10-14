
namespace TrabajoPractico3beta
{
    partial class ProductosGuardados
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonActTabla = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // vistaDatos
            // 
            this.vistaDatos.AllowUserToAddRows = false;
            this.vistaDatos.AllowUserToDeleteRows = false;
            this.vistaDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.vistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Categoria,
            this.IVA,
            this.Precio_Bruto,
            this.Precio_Final});
            this.vistaDatos.Location = new System.Drawing.Point(28, 92);
            this.vistaDatos.Name = "vistaDatos";
            this.vistaDatos.ReadOnly = true;
            this.vistaDatos.RowHeadersWidth = 51;
            this.vistaDatos.RowTemplate.Height = 24;
            this.vistaDatos.Size = new System.Drawing.Size(803, 323);
            this.vistaDatos.TabIndex = 9;
            this.vistaDatos.DoubleClick += new System.EventHandler(this.vistaDatos_DoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.MinimumWidth = 6;
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Width = 70;
            // 
            // Precio_Bruto
            // 
            this.Precio_Bruto.HeaderText = "Precio Bruto";
            this.Precio_Bruto.MinimumWidth = 6;
            this.Precio_Bruto.Name = "Precio_Bruto";
            this.Precio_Bruto.ReadOnly = true;
            this.Precio_Bruto.Width = 90;
            // 
            // Precio_Final
            // 
            this.Precio_Final.HeaderText = "Precio Final";
            this.Precio_Final.MinimumWidth = 6;
            this.Precio_Final.Name = "Precio_Final";
            this.Precio_Final.ReadOnly = true;
            this.Precio_Final.Width = 90;
            // 
            // BotonActTabla
            // 
            this.BotonActTabla.Location = new System.Drawing.Point(664, 50);
            this.BotonActTabla.Name = "BotonActTabla";
            this.BotonActTabla.Size = new System.Drawing.Size(90, 23);
            this.BotonActTabla.TabIndex = 10;
            this.BotonActTabla.Text = "Actualizar";
            this.BotonActTabla.UseVisualStyleBackColor = true;
            this.BotonActTabla.Click += new System.EventHandler(this.BotonActTabla_Click);
            // 
            // ProductosGuardados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 485);
            this.Controls.Add(this.BotonActTabla);
            this.Controls.Add(this.vistaDatos);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "ProductosGuardados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Almacenados";
            this.Load += new System.EventHandler(this.ProdctosGuardados_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.DataGridView vistaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Final;
        private System.Windows.Forms.Button BotonActTabla;
    }
}