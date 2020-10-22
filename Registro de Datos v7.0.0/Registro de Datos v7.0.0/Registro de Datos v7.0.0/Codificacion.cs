using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_Datos_v7._0._0
{
	class Codificacion
	{
		static private int codeNA;
		private Persona personacons = new Persona();


		public object Personacons
		{
			get
			{
				
				codificacionNivelAcademico(personacons.NivelAcademico);
				codificacionSexo(personacons.Sexo);
				codificacionEstadoCivil(personacons.EstadoCivil);
				codificacionEdad(personacons.Edad);
				return personacons;


			}
			set
			{
				personacons= (Persona)Program.captura();
			}
			
		}
		
		static int codificacionNivelAcademico(char nivelAcatemico)
		{
			
			
			char var = nivelAcatemico;
			if (nivelAcatemico == 'p')
			{
				codeNA = codeNA | 0;

			}
			else if (nivelAcatemico == 's')
			{
				codeNA = codeNA | 1;
			}
			else if (nivelAcatemico == 'g')
			{
				codeNA = codeNA | 2;
			}
			else if (nivelAcatemico=='P')
			{
				codeNA = codeNA | 3;
			}
			return codeNA;
		}
		static int codificacionSexo(char sexo)
		{
			if (sexo == 'f')
			{
			}
			else if (sexo=='m')
			{
				codeNA = codeNA | 4;
			}
			return codeNA;
		}
		static int codificacionEstadoCivil(char estadoCivil)
		{
			if (estadoCivil=='s')
			{
			}
			else if (estadoCivil=='c')
			{
				codeNA = codeNA | 8;
			}
			return codeNA;
		}
		static int codificacionEdad(sbyte edad)
		{
			codeNA = codeNA | (edad << 4);
			return codeNA;

		}




	}

}

