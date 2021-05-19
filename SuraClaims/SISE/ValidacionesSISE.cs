﻿/*
 * Created by Ranorex
 * User: Irina Storozuk
 * Date: 18/05/2021
 * Time: 12:26 p. m.
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SuraClaims.SISE
{
	/// <summary>
	/// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
	/// </summary>
	[UserCodeCollection]
	public class ValidacionesSISE
	{
		private static SuraClaims.SuraClaimsRepository repo = SuraClaims.SuraClaimsRepository.Instance;

		// You can use the "Insert New User Code Method" functionality from the context menu,
		// to add a new method with the attribute [UserCodeMethod].
		
		
		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		[UserCodeMethod]
		public static void ValidarTexto(string TextoValidacion, string TituloAccion)
		{
			
			Report.Log(ReportLevel.Info, "Info: ", "Acción: "+ TituloAccion);
			string line;
			bool Chk = false;
		
			repo.SisePreProd.Sistema.Click("18;6");
			
			repo.Putty.CopyAllToClipboard.Click("122;9");
			Delay.Milliseconds(3000);
			
			//Tomamos la info del ClipBoard y lo guardamos en una variable
			string AuxTXT = System.Windows.Forms.Clipboard.GetText();
			StringReader sr = new StringReader(AuxTXT);
			
			//Mientras la linea no esta vacia...
			while ((line = sr.ReadLine()) != null)
			{
				//Verificamos si la linea contiene el texto buscado
				if (line.Contains(TextoValidacion))
				{
					//Si lo encuentro hago una extraccion de los datos que busco
					Chk = true;
					break;
				}

			}
						
			if(Chk == false){
				Validate.IsTrue(Chk,"Validación de Texto Fallida - " + TituloAccion);
			}else{
				Validate.IsTrue(Chk,"Validación de Texto Exitosa - " + TituloAccion);
			}
		}

	}
}
