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

namespace SuraClaims.SISE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidarGeneracionSiniestro_SISE_PreProd recording.
    /// </summary>
    [TestModule("1f80ea6d-6d97-4a47-87ad-9d8e3f98bcd9", ModuleType.Recording, 1)]
    public partial class ValidarGeneracionSiniestro_SISE_PreProd : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static ValidarGeneracionSiniestro_SISE_PreProd instance = new ValidarGeneracionSiniestro_SISE_PreProd();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidarGeneracionSiniestro_SISE_PreProd()
        {
            NroSiniestro = "1220194200601";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidarGeneracionSiniestro_SISE_PreProd Instance
        {
            get { return instance; }
        }

#region Variables

        string _NroSiniestro;

        /// <summary>
        /// Gets or sets the value of variable NroSiniestro.
        /// </summary>
        [TestVariable("2b426858-3933-4096-a6f0-def4113aea8a")]
        public string NroSiniestro
        {
            get { return _NroSiniestro; }
            set { _NroSiniestro = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'sistema{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(1));
            repo.SisePreProd.Self.PressKeys("sistema{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(2));
            Delay.Duration(20000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '990{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(3));
            repo.SisePreProd.Self.PressKeys("990{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Sura2039{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(5));
            repo.SisePreProd.Self.PressKeys("Sura2039{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
            // Validación del Login (Texto: MENU PRINICPAL)
            ValidarLogin("M E N U    P R I N C I P A L", "Validación del Login");
            Delay.Milliseconds(0);
            
            // Ambiente
            Report.Log(ReportLevel.Info, "Section", "Ambiente", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(9));
            repo.SisePreProd.Self.PressKeys("1{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(10));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '3{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(11));
            repo.SisePreProd.Self.PressKeys("3{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(13));
            repo.SisePreProd.Self.PressKeys("2{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(14));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '4{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(15));
            repo.SisePreProd.Self.PressKeys("4{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(16));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(17));
            repo.SisePreProd.Self.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NroSiniestro' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(18));
            repo.SisePreProd.Self.PressKeys(NroSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(19));
            repo.SisePreProd.Self.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(20));
            Delay.Duration(2000, false);
            
            // Número del pago
            Report.Log(ReportLevel.Info, "Section", "Número del pago", new RecordItemIndex(21));
            
            // Validación de Pago
            ValidarLogin("Cobertura", "Validación de Generación del Siniestro");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(23));
            repo.SisePreProd.Self.PressKeys("1{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(24));
            Delay.Duration(2000, false);
            
            // Validación de Pago
            ValidarLogin("Estimaciones en $", "Validación de Cobertura Existente");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SisePreProd.Self, false, new RecordItemIndex(26));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SisePreProd.Sistema' at 18;6.", repo.SisePreProd.SistemaInfo, new RecordItemIndex(27));
            //repo.SisePreProd.Sistema.Click("18;6");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Putty.CopyAllToClipboard' at 122;9.", repo.Putty.CopyAllToClipboardInfo, new RecordItemIndex(28));
            //repo.Putty.CopyAllToClipboard.Click("122;9");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
