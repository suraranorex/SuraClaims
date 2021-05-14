﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SuraClaims.JuiciosyMediaciones
{
	public partial class ValidarLitigio_SISE_QA
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void ValidarLogin(string TextoValidacion, string TituloAccion)
		{
			// TODO: Replace the following line with your code implementation.
			//throw new NotImplementedException();
			
			Report.Log(ReportLevel.Info, "Info: ", "Acción: "+ TituloAccion);
			string line;
			bool Chk = false;
			
			//Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SisePreProd.Sistema' at 18;6.", repo.SisePreProd.SistemaInfo, new RecordItemIndex(21));
			repo.SisePreProd.Sistema.Click("18;6");
			
			
			//Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Putty.CopyAllToClipboard' at 122;9.", repo.Putty.CopyAllToClipboardInfo, new RecordItemIndex(22));
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
					//Report.Log(ReportLevel.Info, "Info","Login Exitoso");
					Chk = true;
					break;
				}
				
				
			}
			
			// Validate.IsFalse(!Chk,"Failed");
			//Validate.IsTrue(Chk,"OK");
			
			if(Chk == false){
				Validate.IsTrue(Chk,"Validación de Texto Fallida - " + TituloAccion);
			}else{
				Validate.IsTrue(Chk,"Validación de Texto Exitosa - " + TituloAccion);
			}
		}



	}
}
