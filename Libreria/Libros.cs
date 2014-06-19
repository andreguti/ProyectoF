
using System;

namespace Libreria
{
	/// <summary>
	/// Description of Libros.
	/// </summary>
	public class Libros
	{
		public int id {get; set;}
		public string titulo {get; set;}
		public string autor {get; set;}
		public string editorial {get; set;}
		public string anio {get; set;}
		
		
		
		public Libros()
		{
		}
	
	
		public Libros(int pId, string ptitulo, string pautor, string peditorial, string panio)
		{
			this.id = pId;
			this.titulo = ptitulo;
			this.autor = pautor;
			this.editorial = peditorial;
			this.anio= panio;
		}
	
	
	
	}
}
