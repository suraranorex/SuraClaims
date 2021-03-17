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

namespace SuraClaims.Hogar
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InformacionSiniestro_Hogar recording.
    /// </summary>
    [TestModule("7660e446-401e-4c60-a588-5248f8fa3529", ModuleType.Recording, 1)]
    public partial class InformacionSiniestro_Hogar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static InformacionSiniestro_Hogar instance = new InformacionSiniestro_Hogar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionSiniestro_Hogar()
        {
            CausaSiniestro = "Cortocircuito";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionSiniestro_Hogar Instance
        {
            get { return instance; }
        }

#region Variables

        string _CausaSiniestro;

        /// <summary>
        /// Gets or sets the value of variable CausaSiniestro.
        /// </summary>
        [TestVariable("4fd11c4f-bc9b-429c-9957-4fd452cba29b")]
        public string CausaSiniestro
        {
            get { return _CausaSiniestro; }
            set { _CausaSiniestro = value; }
        }

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
        /// Gets or sets the value of variable TIPO_DANIOS.
        /// </summary>
        [TestVariable("ecbd8e9b-6086-4998-9ca9-8d8df24ca875")]
        public string TIPO_DANIOS
        {
            get { return repo.TIPO_DANIOS; }
            set { repo.TIPO_DANIOS = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFail' at Center.", repo.SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFailInfo, new RecordItemIndex(0));
                repo.SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFail.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestro'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.txtbox_CausaSiniestro' at Center.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(2));
            repo.SuraClaims.Hogar.txtbox_CausaSiniestro.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.SuraClaims.Hogar.txtbox_CausaSiniestro);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CausaSiniestro' with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(4));
            repo.SuraClaims.Hogar.txtbox_CausaSiniestro.PressKeys(CausaSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestro'", repo.SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(6));
            repo.SuraClaims.Hogar.txtbox_CausaSiniestro.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.bttn_SoloIncidente' at Center.", repo.SuraClaims.Hogar.bttn_SoloIncidenteInfo, new RecordItemIndex(7));
            repo.SuraClaims.Hogar.bttn_SoloIncidente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.check_TipoDanios' at Center.", repo.SuraClaims.Hogar.check_TipoDaniosInfo, new RecordItemIndex(8));
            repo.SuraClaims.Hogar.check_TipoDanios.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Hogar.txt_Preguntas'", repo.SuraClaims.Hogar.txt_PreguntasInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.SuraClaims.Hogar.txt_PreguntasInfo.WaitForExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(11));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso4'", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new ActionTimeout(30000), new RecordItemIndex(12));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}