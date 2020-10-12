using System;

namespace Registro_de_Datos_v7._0._0
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Menu();
		}
		static void Menu()
		{
			int Vopcion = 0;
			Console.WriteLine("      Opciones       \n\n1)Agregar\n2)Eliminar\n3)Modificar\n4)Buscar\n5)ver listado\n6)Salir");
			switch (Vopcion)
			{
				case 1:
					captura();
					break;
			}
		}
		public static object captura()
		{
			string cedula = "00000000000", nombres = "", apellidos = "", password = ""; char sexo='f', estadoCivil='s', nivelAcademico='p';sbyte edad=1;double ahorros = 0.00;

			Console.WriteLine("Inserte su cedula");
			cedula = Console.ReadLine();
			Console.Clear();

			Console.WriteLine("Inserte sus nombres");
			nombres = Console.ReadLine();
			Console.Clear();

			Console.WriteLine("Inserte sus apellidos");
			apellidos = Console.ReadLine();
			Console.Clear();

			Console.WriteLine("Inserte su edad");
			edad = sbyte.Parse(Console.ReadLine());
			Console.Clear();

			Console.WriteLine("Inserte su sexo");
			sexo = char.Parse(Console.ReadLine());
			Console.Clear();

			Console.WriteLine("Inserte su Estado civil");
			estadoCivil = char.Parse(Console.ReadLine());
			Console.Clear();

			Console.WriteLine("Inserte sus nivel academiico");
			nivelAcademico = char.Parse(Console.ReadLine());
			Console.Clear();

			 Persona Personacons = new Persona(cedula: cedula, sexo:sexo,edad:edad,estadoCivil:estadoCivil,nivelAcademico:nivelAcademico,nombres:nombres,apellidos:apellidos,ahorros:ahorros,contraseña:password) ;
		}
	}
}
