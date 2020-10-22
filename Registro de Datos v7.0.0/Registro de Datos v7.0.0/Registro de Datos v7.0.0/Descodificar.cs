using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_Datos_v7._0._0
{
	class Descodificar : Codificacion
	{
		private int iddinamico;
		




		public int Iddinamico
		{
			get
			{
				return iddinamico;
			}
			set
			{
				return iddinamico = value;
			}
		}
		public char Sexo
		{
			get
			{
				return sexo;
			}
			set
			{
			}
		}
		
		 override public string  codificacionNivelAcademico(int id)
		{
			Iddinamico = id & 3;

			if (iddinamico == 0)
			{
				return "Nivel Academco: Primario";
			}
			else if (iddinamico == 1)
			{
				return "Nivel Academico: secuadario";
			}
			else if (iddinamico==)
			{
			}

		}
	}
}
