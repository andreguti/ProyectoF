/*
 * Creado por SharpDevelop.
 * Usuario: Bel Kiel
 * Fecha: 17/06/2014
 * Hora: 08:37 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Libreria
{
	partial class Buscar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
			this.txtBus = new System.Windows.Forms.TextBox();
			this.dvgTodos = new System.Windows.Forms.DataGridView();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dvgTodos)).BeginInit();
			this.SuspendLayout();
			// 
			// txtBus
			// 
			this.txtBus.Location = new System.Drawing.Point(74, 223);
			this.txtBus.Name = "txtBus";
			this.txtBus.Size = new System.Drawing.Size(180, 20);
			this.txtBus.TabIndex = 24;
			// 
			// dvgTodos
			// 
			this.dvgTodos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dvgTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgTodos.Location = new System.Drawing.Point(3, 12);
			this.dvgTodos.Name = "dvgTodos";
			this.dvgTodos.Size = new System.Drawing.Size(488, 150);
			this.dvgTodos.TabIndex = 23;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(270, 168);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(60, 75);
			this.btnBuscar.TabIndex = 22;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.Location = new System.Drawing.Point(428, 168);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(60, 75);
			this.btnAceptar.TabIndex = 20;
			this.btnAceptar.Text = "Editar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 220);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "Nombre";
			// 
			// Buscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 265);
			this.Controls.Add(this.txtBus);
			this.Controls.Add(this.dvgTodos);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label1);
			this.Name = "Buscar";
			this.Text = "Buscar";
			((System.ComponentModel.ISupportInitialize)(this.dvgTodos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridView dvgTodos;
		private System.Windows.Forms.TextBox txtBus;
	}
}
