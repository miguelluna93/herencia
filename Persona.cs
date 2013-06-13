using System;

namespace Herencias
{
	abstract class Persona
	{
		private string nombre;
		private string apellido;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}
		public abstract int Clave
		{ get; set; }
		public abstract string ConsultarTodosLosDatos();
		public string ObtenerNombreCompleto()
		{
			return
				this.Nombre + " " + this.Apellido;
		}
	}
}

