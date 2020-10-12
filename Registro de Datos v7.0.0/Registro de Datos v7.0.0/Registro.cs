using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_Datos_v7._0._0
{
	class Registro
	{
		private Persona personacons = new Persona();


		public object Personacons
		{
			get
			{
				return personacons;
				codificacionNivelAcademico(personacons.NivelAcademico);
				
			}
			set
			{
				personacons= (Persona)Program.captura();
			}
			
		}
		
		static int codificacionNivelAcademico(char nivelAcatemico)
		{
			
			int codeNA = 0;
			char var = 'k';


			
				return codeNA;
		}

	}
}
