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

namespace SuraClaims.JuiciosyMediaciones
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FInalizar_Litigio recording.
    /// </summary>
    [TestModule("9059d729-8a92-4902-9a8e-fa8d215b7d43", ModuleType.Recording, 1)]
    public partial class FInalizar_Litigio : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static FInalizar_Litigio instance = new FInalizar_Litigio();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FInalizar_Litigio()
        {
            RAJ = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FInalizar_Litigio Instance
        {
            get { return instance; }
        }

#region Variables

        string _RAJ;

        /// <summary>
        /// Gets or sets the value of variable RAJ.
        /// </summary>
        [TestVariable("877abcbc-8703-4c4f-bdf8-60ec704b2de4")]
        public string RAJ
        {
            get { return _RAJ; }
            set { _RAJ = value; }
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

            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.JuiciosYMediaciones.bttn_Actualizar' at Center.", repo.SuraClaims.JuiciosYMediaciones.bttn_ActualizarInfo, new RecordItemIndex(1));
            repo.SuraClaims.JuiciosYMediaciones.bttn_Actualizar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.JuiciosYMediaciones.bttn_VolverALitigacion'", repo.SuraClaims.JuiciosYMediaciones.bttn_VolverALitigacionInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SuraClaims.JuiciosYMediaciones.bttn_VolverALitigacionInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.JuiciosYMediaciones.txt_NumeroRAJ' and assigning its value to variable 'RAJ'.", repo.SuraClaims.JuiciosYMediaciones.txt_NumeroRAJInfo, new RecordItemIndex(3));
            RAJ = repo.SuraClaims.JuiciosYMediaciones.txt_NumeroRAJ.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "El número de RAJ emitido es", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "User", RAJ, new RecordItemIndex(5));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(6));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
