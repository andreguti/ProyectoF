using MySql.Data.MySqlClient;
using System;

namespace Libreria
{
	/// <summary>
	/// Description of Conectar.
	/// </summary>
	public class Conectar
	{
		public static MySqlConnection ObtenerConexion()
		{
			MySqlConnection conecta= new MySqlConnection ("server = 127.0.0.1; database= biblioteca; Uid = root; Pwd =123;");
			conecta.Open();
			return conecta;
		}
		
		
		
		
		
	}
}
