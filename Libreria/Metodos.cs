
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Libreria
{
	
	public class Metodos
	{
		
		public static int Agregar(Libros pLibros)
		{
			int retorno =0;
			
			MySqlCommand comando =new MySqlCommand(string.Format("insert into libros(titulo, autor, editorial, anio)values ('{0}','{1}','{2}','{3}')",
			                                                     pLibros.titulo, pLibros.autor, pLibros.editorial, pLibros.anio),Conectar.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			return retorno;
		}
		
		public static List<Libros> Buscar(string plibro)
		{
			List<Libros> _lista = new List<Libros>();
			MySqlCommand _comando = new MySqlCommand(string.Format("select id, titulo, autor, editorial, anio from libros where titulo LIKE '%{0}%'",plibro),Conectar.ObtenerConexion());
			MySqlDataReader _reader=_comando.ExecuteReader();
			while (_reader.Read())
			{
				Libros pLibros = new Libros();
				
				pLibros.id=_reader.GetInt32(0);
				pLibros.titulo=_reader.GetString(1);
				pLibros.autor=_reader.GetString(2);
				pLibros.editorial=_reader.GetString(3);
				pLibros.anio=_reader.GetString(4);
				
				_lista.Add(pLibros);
								
			}
			return _lista;
			
		}
		
		public static Libros ObtenerLibros(int pId)
		{
			Libros pLibros = new Libros();
			MySqlConnection conexion = Conectar.ObtenerConexion();
			MySqlCommand _comando = new MySqlCommand(string.Format("select id, titulo, autor, editorial, anio from libros where id = '{0}'",pId),Conectar.ObtenerConexion());
			MySqlDataReader _reader =_comando.ExecuteReader();
			while(_reader.Read())
			{
				pLibros.id=_reader.GetInt32(0);
				pLibros.titulo=_reader.GetString(1);
				pLibros.autor=_reader.GetString(2);
				pLibros.editorial=_reader.GetString(3);
				pLibros.anio=_reader.GetString(4);
			}
			conexion.Close();
			return pLibros;
		}
		
		
		public static int Editar(Libros pLibros)
		{
			int retorno=0;
			
			MySqlConnection conexion=Conectar.ObtenerConexion();
			MySqlCommand comando = new MySqlCommand(string.Format("update libros set titulo = '{0}', autor ='{1}', editorial= '{2}', anio ='{3}' where id = '{4}'",pLibros.titulo, pLibros.autor, pLibros.editorial, pLibros.anio, pLibros.id), conexion);
			retorno = comando.ExecuteNonQuery();
			conexion.Close();
			return retorno;
					
		}
		
		public static int Eliminar(int pId)
		{
			int retorno =0;
			MySqlConnection conexion = Conectar.ObtenerConexion();
			MySqlCommand comando = new MySqlCommand(string.Format("delete from libros where id={0}", pId),conexion);
			retorno = comando.ExecuteNonQuery();
			return retorno;
		}
		
		
	}
}
