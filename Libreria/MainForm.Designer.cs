/*
 * Creado por SharpDevelop.
 * Usuario: Bel Kiel
 * Fecha: 17/06/2014
 * Hora: 02:29 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Libreria
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtAnio = new System.Windows.Forms.TextBox();
			this.txtEditorial = new System.Windows.Forms.TextBox();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.Location = new System.Drawing.Point(318, 126);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(65, 75);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.Location = new System.Drawing.Point(422, 91);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(60, 75);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "Guardar Cambios";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.Location = new System.Drawing.Point(422, 172);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(60, 75);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(422, 12);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(60, 75);
			this.btnBuscar.TabIndex = 11;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtAnio);
			this.panel1.Controls.Add(this.txtEditorial);
			this.panel1.Controls.Add(this.txtAutor);
			this.panel1.Controls.Add(this.txtTitulo);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(390, 204);
			this.panel1.TabIndex = 12;
			// 
			// txtAnio
			// 
			this.txtAnio.Location = new System.Drawing.Point(67, 173);
			this.txtAnio.Name = "txtAnio";
			this.txtAnio.Size = new System.Drawing.Size(219, 20);
			this.txtAnio.TabIndex = 15;
			// 
			// txtEditorial
			// 
			this.txtEditorial.Location = new System.Drawing.Point(67, 134);
			this.txtEditorial.Name = "txtEditorial";
			this.txtEditorial.Size = new System.Drawing.Size(219, 20);
			this.txtEditorial.TabIndex = 14;
			// 
			// txtAutor
			// 
			this.txtAutor.Location = new System.Drawing.Point(67, 93);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(219, 20);
			this.txtAutor.TabIndex = 13;
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(67, 46);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(219, 20);
			this.txtTitulo.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Año";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Editorial";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Autor";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Libro";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(165, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Registrar Libro";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 265);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Name = "MainForm";
			this.Text = "Libreria";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtAnio;
		private System.Windows.Forms.TextBox txtEditorial;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
