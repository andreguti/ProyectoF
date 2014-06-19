
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Libreria
{
	
	public partial class Buscar : Form
	{
		public Buscar()
		{
			InitializeComponent();
		}
		
		public Libros libroSeleccionado {get; set;}
		
		
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			dvgTodos.DataSource=Metodos.Buscar(txtBus.Text);
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if (dvgTodos.SelectedRows.Count==1)
			
			{
				int id=Convert.ToInt32(dvgTodos.CurrentRow.Cells[0].Value);
				libroSeleccionado=Metodos.ObtenerLibros(id);
				this.Close();
			}
			else MessageBox.Show("Debe escoger una fila");	
		}
		
		
		
		
		
		
	}
}
