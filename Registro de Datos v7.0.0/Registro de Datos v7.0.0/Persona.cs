using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_Datos_v7._0._0
{
	class Persona
	{
		//campo
		private string nombres;
		private string apellidos;
		private string cedula;
		private string contraseña;
		private sbyte edad;
		private double ahorros;
		private char sexo;
		private char estadoCivil;
		private char nivelAcademico;

		//Constructor
		public Persona(string nombres, string apellidos, string cedula, string contraseña, sbyte edad, double ahorros, char sexo, char estadoCivil, char nivelAcademico)
		{
			nombres = Nombres;
			apellidos = Apellidos;
			cedula = Cedula;
			contraseña = Contraseña;
			ahorros = Ahorros;
			edad = Edad;
			sexo = Sexo;
			estadoCivil = EstadoCivil;
			nivelAcademico = NivelAcademico;


		}

		//Metodos de acceso(MDA)

		//MDA nombre
		public string Nombres
		{
			get
			{
				return nombres;
			}
			set
			{
				if (nombres.Length <= 150)
				{
					nombres = value;
				}
			}
		}
		//MDA apellidos
		public string Apellidos
		{
			get
			{
				return apellidos;
			}
			set
			{
				if (apellidos.Length <= 150)
				{
					apellidos = value;
				}
			}
		}
		//MDA cedula
		public string Cedula
		{
			get
			{
				return cedula;
			}
			set
			{
				try
				{
					if (cedula.Length == 11)
					{
						cedula = value;
						int Vcedula = int.Parse(cedula);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine($"Tipo de dato erroneo\n{e.Message}");
				}
			}

		}
		//MDA contraseña
		public string Contraseña
		{
			get
			{
				return contraseña;
			}
			set
			{
				contraseña = value;
			}
		}
			//ahorros
		public double Ahorros
		{
			get
			{
				return ahorros;
			}
			set
			{
				ahorros = value;
			}
		}
			
			//MDA edad
		public sbyte Edad
		{
			get
			{
				return edad;
			}
			set 
			{
				if (edad<120 && edad>0)
				{
					edad = value;
				}
			}
		}
			//MDA sexo
		public char Sexo
		{
			get
			{
				return sexo;
			}
			set
			{
				if (sexo == 'f' || sexo == 'm')
				{
					sexo = value;
				}
			}
		}
		//MDA Estado Civil
		public char EstadoCivil
		{
			get
			{
				return estadoCivil;
			}
			set 
			{
				if (estadoCivil == 's' || estadoCivil == 'c')
				{
					estadoCivil = value;
				}
			}
		}
		//MDA Nivel Academico
		public char NivelAcademico
		{
			get
			{
				return nivelAcademico;
			}
			set
			{
				if (nivelAcademico == 'p' || nivelAcademico == 's' || nivelAcademico == 'g'||nivelAcademico=='P')
				{
					nivelAcademico = value;
				}
			}
		}
	}	
}
