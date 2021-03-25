﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SuraClaims.AP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NuevaExposicion recording.
    /// </summary>
    [TestModule("5d57222f-571e-47c3-8251-f28f8945c89d", ModuleType.Recording, 1)]
    public partial class NuevaExposicion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static NuevaExposicion instance = new NuevaExposicion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NuevaExposicion()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NuevaExposicion Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("e7903828-6ac1-46d3-a887-f52fdafb621a")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NombreLesionado.
        /// </summary>
        [TestVariable("9c849daa-a7f3-445d-b9d7-1521b0728a90")]
        public string NombreLesionado
        {
            get { return repo.NombreLesionado; }
            set { repo.NombreLesionado = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NombreAsegurado.
        /// </summary>
        [TestVariable("40d4fbbd-ac5c-4801-a089-9b02b3349092")]
        public string NombreAsegurado
        {
            get { return repo.NombreAsegurado; }
            set { repo.NombreAsegurado = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // Nueva Exposición
            Report.Log(ReportLevel.Info, "Section", "Nueva Exposición", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtbox_Reclamante' at Center.", repo.SuraClaims.AP_Uber.txtbox_ReclamanteInfo, new RecordItemIndex(1));
            repo.SuraClaims.AP_Uber.txtbox_Reclamante.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_ReclamanteUber' at Center.", repo.SuraClaims.Motor.InformacionBasica.option_ReclamanteUberInfo, new RecordItemIndex(2));
            //repo.SuraClaims.Motor.InformacionBasica.option_ReclamanteUber.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_NombreLesionado4' at Center.", repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionado4Info, new RecordItemIndex(3));
            repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionado4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtbox_Reclamante'", repo.SuraClaims.AP_Uber.Copy_of_txtbox_ReclamanteInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            repo.SuraClaims.AP_Uber.Copy_of_txtbox_ReclamanteInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtbox_Tipo' at Center.", repo.SuraClaims.AP_Uber.txtbox_TipoInfo, new RecordItemIndex(5));
            repo.SuraClaims.AP_Uber.txtbox_Tipo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Cadete en moto' with focus on 'SuraClaims.AP_Uber.txtbox_Tipo'.", repo.SuraClaims.AP_Uber.txtbox_TipoInfo, new RecordItemIndex(6));
            repo.SuraClaims.AP_Uber.txtbox_Tipo.PressKeys("Cadete en moto");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.txt_NuevaExposicion' at Center.", repo.SuraClaims.Hogar.txt_NuevaExposicionInfo, new RecordItemIndex(7));
            repo.SuraClaims.Hogar.txt_NuevaExposicion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtbox_Tipo'", repo.SuraClaims.AP_Uber.Copy_of_txtbox_TipoInfo, new ActionTimeout(30000), new RecordItemIndex(8));
            repo.SuraClaims.AP_Uber.Copy_of_txtbox_TipoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(9));
            
            // Agrego lesiones - Información Básica
            Report.Log(ReportLevel.Info, "Section", "Agrego lesiones - Información Básica", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.btn_AddIncidente2' at Center.", repo.SuraClaims.AP_Uber.btn_AddIncidente2Info, new RecordItemIndex(11));
            repo.SuraClaims.AP_Uber.btn_AddIncidente2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.SelectNuevoIncidente' at Center.", repo.SuraClaims.AP_Uber.SelectNuevoIncidenteInfo, new RecordItemIndex(12));
            repo.SuraClaims.AP_Uber.SelectNuevoIncidente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new ActionTimeout(30000), new RecordItemIndex(13));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionada' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionadaInfo, new RecordItemIndex(14));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionada.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.optionLI_NombreNOasegurado' at Center.", repo.SuraClaims.Motor.InformacionBasica.optionLI_NombreNOaseguradoInfo, new RecordItemIndex(15));
            //repo.SuraClaims.Motor.InformacionBasica.optionLI_NombreNOasegurado.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_NombreLesionado4' at Center.", repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionado4Info, new RecordItemIndex(16));
            repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionado4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_PersonaLesionada'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_PersonaLesionadaInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_PersonaLesionadaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado_SI' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado_SIInfo, new RecordItemIndex(18));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado_SI.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '21/06/2020' with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporte'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporteInfo, new RecordItemIndex(19));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporte.PressKeys("21/06/2020");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new RecordItemIndex(20));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporte'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporteInfo, new ActionTimeout(30000), new RecordItemIndex(21));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporteInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamoInfo, new RecordItemIndex(22));
            Keyboard.PrepareFocus(repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Por mostrador' with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamoInfo, new RecordItemIndex(23));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo.PressKeys("Por mostrador");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new RecordItemIndex(24));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamo'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamoInfo, new ActionTimeout(30000), new RecordItemIndex(25));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(26));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
