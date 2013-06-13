using System;

namespace Herencias
{
	class Empleado : Persona
	{
		private int claveEmpleado;
		public override int Clave
		{
			get { return claveEmpleado; }
			set { claveEmpleado = value; }
		}
		public override string ConsultarTodosLosDatos()
		{
			return "------Datos del Empleado: \n" + this.Clave + " " +
				this.Nombre + " " + this.Apellido;
		}
	}
	class Cliente : Persona
	{
		private int claveCliente;
		public override int Clave
		{
			get { return claveCliente; }
			set { claveCliente = value; }
		}
		public override string ConsultarTodosLosDatos()
		{
			return "******Datos del Cliente: \n" + this.Clave + " " +
				this.Nombre + " " + this.Apellido;
	}

	}
}

