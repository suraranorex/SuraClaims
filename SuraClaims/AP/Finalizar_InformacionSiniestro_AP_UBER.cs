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
    ///The Finalizar_InformacionSiniestro_AP_UBER recording.
    /// </summary>
    [TestModule("3dd48fe7-1a74-42ec-8162-d2008f9af4ef", ModuleType.Recording, 1)]
    public partial class Finalizar_InformacionSiniestro_AP_UBER : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static Finalizar_InformacionSiniestro_AP_UBER instance = new Finalizar_InformacionSiniestro_AP_UBER();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Finalizar_InformacionSiniestro_AP_UBER()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Finalizar_InformacionSiniestro_AP_UBER Instance
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

            // Datos uber
            Report.Log(ReportLevel.Info, "Section", "Datos uber", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txt_SAFE' at Center.", repo.SuraClaims.AP_Uber.txt_SAFEInfo, new RecordItemIndex(1));
            repo.SuraClaims.AP_Uber.txt_SAFE.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.AP_Uber.txt_SAFE'.", repo.SuraClaims.AP_Uber.txt_SAFEInfo, new RecordItemIndex(2));
            repo.SuraClaims.AP_Uber.txt_SAFE.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1627373' with focus on 'SuraClaims.AP_Uber.txt_SAFE'.", repo.SuraClaims.AP_Uber.txt_SAFEInfo, new RecordItemIndex(3));
            repo.SuraClaims.AP_Uber.txt_SAFE.PressKeys("1627373");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txt_SAFE'", repo.SuraClaims.AP_Uber.Copy_of_txt_SAFEInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SuraClaims.AP_Uber.Copy_of_txt_SAFEInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txt_Nivel' at Center.", repo.SuraClaims.AP_Uber.txt_NivelInfo, new RecordItemIndex(6));
            repo.SuraClaims.AP_Uber.txt_Nivel.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'L1' with focus on 'SuraClaims.AP_Uber.txt_Nivel'.", repo.SuraClaims.AP_Uber.txt_NivelInfo, new RecordItemIndex(7));
            repo.SuraClaims.AP_Uber.txt_Nivel.PressKeys("L1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(8));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txt_Nivel'", repo.SuraClaims.AP_Uber.Copy_of_txt_NivelInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.SuraClaims.AP_Uber.Copy_of_txt_NivelInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txt_Periodo' at Center.", repo.SuraClaims.AP_Uber.txt_PeriodoInfo, new RecordItemIndex(10));
            repo.SuraClaims.AP_Uber.txt_Periodo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'P0' with focus on 'SuraClaims.AP_Uber.txt_Periodo'.", repo.SuraClaims.AP_Uber.txt_PeriodoInfo, new RecordItemIndex(11));
            repo.SuraClaims.AP_Uber.txt_Periodo.PressKeys("P0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(12));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txt_Periodo'", repo.SuraClaims.AP_Uber.Copy_of_txt_PeriodoInfo, new ActionTimeout(30000), new RecordItemIndex(13));
            repo.SuraClaims.AP_Uber.Copy_of_txt_PeriodoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(15));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso5'", repo.SuraClaims.Txt_Validaciones.txt_Paso5Info, new ActionTimeout(30000), new RecordItemIndex(16));
            repo.SuraClaims.Txt_Validaciones.txt_Paso5Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
