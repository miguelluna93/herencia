using System;

namespace Herencias
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Empleado unEmpleado = new Empleado();
			unEmpleado.Nombre = "Daniel";
			unEmpleado.Apellido = "Gonzalez";
			unEmpleado.Clave = 1;
			Console.WriteLine( unEmpleado.ConsultarTodosLosDatos() );
			Console.WriteLine( unEmpleado.ObtenerNombreCompleto() );
			Cliente unCliente = new Cliente();
			unCliente.Nombre = "Jonathan";
			unCliente.Apellido = "Ramirez";
			unCliente.Clave = 34;
			Console.WriteLine( unCliente.ConsultarTodosLosDatos() );
			Console.WriteLine( unCliente.ObtenerNombreCompleto());
			Console.ReadLine();
		}
	}
}
