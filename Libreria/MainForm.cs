
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Libreria
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			}

		public Libros LibroActual {get; set;}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			
			Libros pLibros = new Libros();
			
			pLibros.titulo=txtTitulo.Text.Trim();
			pLibros.autor=txtAutor.Text.Trim();
			pLibros.editorial=txtEditorial.Text.Trim();
			pLibros.anio=txtAnio.Text.Trim();
			
			int resultado=Metodos.Agregar(pLibros);
			if (resultado > 0)
			{
				MessageBox.Show ("Libro guardado con exito","Guardado",MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show ("No se pudo guardar el Libro", "Falló",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
			
		void BtnEditarClick(object sender, EventArgs e)
		{
			Libros pLibros = new Libros();
			
			pLibros.titulo=txtTitulo.Text.Trim();
			pLibros.autor=txtAutor.Text.Trim();
			pLibros.editorial=txtEditorial.Text.Trim();
			pLibros.anio=txtAnio.Text.Trim();
			
			pLibros.id=LibroActual.id;
			
			if (Metodos.Editar(pLibros) >0)
			{
				MessageBox.Show("Libro editado","Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
			else
			{
				MessageBox.Show("No se pudo actualizar","Error al actualizar",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
					}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show ("Desea continuar?","Está seguro?",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
			{
				if (Metodos.Eliminar(LibroActual.id)>0)
				{
					MessageBox.Show("Eliminado ","Eliminado",MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Error al eliminar","no se eliminó", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}			
		}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			Buscar _buscar = new Buscar();
			_buscar.ShowDialog();
			
			LibroActual = _buscar.libroSeleccionado;
			
			txtTitulo.Text=_buscar.libroSeleccionado.titulo;
			txtEditorial.Text=_buscar.libroSeleccionado.editorial;
			txtAutor.Text=_buscar.libroSeleccionado.autor;
			txtAnio.Text=_buscar.libroSeleccionado.anio;
			
		}
		}
	}

