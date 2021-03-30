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

namespace SuraClaims.Actividad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CompletarChecklistFraude recording.
    /// </summary>
    [TestModule("f59345f5-b0ba-47eb-b90d-f1248b7250b3", ModuleType.Recording, 1)]
    public partial class CompletarChecklistFraude : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static CompletarChecklistFraude instance = new CompletarChecklistFraude();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CompletarChecklistFraude()
        {
            NumeroPoliza = "";
            TipoPoliza = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CompletarChecklistFraude Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumeroPoliza;

        /// <summary>
        /// Gets or sets the value of variable NumeroPoliza.
        /// </summary>
        [TestVariable("04ecaeaf-c7a6-40d1-a419-0f57877e35f7")]
        public string NumeroPoliza
        {
            get { return _NumeroPoliza; }
            set { _NumeroPoliza = value; }
        }

        string _TipoPoliza;

        /// <summary>
        /// Gets or sets the value of variable TipoPoliza.
        /// </summary>
        [TestVariable("cc9bd00d-2f36-436d-82f5-04c5a918ae21")]
        public string TipoPoliza
        {
            get { return _TipoPoliza; }
            set { _TipoPoliza = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Actividad.a_CompletarChecklistFraude' at Center.", repo.SuraClaims.Actividad.a_CompletarChecklistFraudeInfo, new RecordItemIndex(0));
            repo.SuraClaims.Actividad.a_CompletarChecklistFraude.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Actividad.bttn_PreguntasPendientes' at Center.", repo.SuraClaims.Actividad.bttn_PreguntasPendientesInfo, new RecordItemIndex(1));
            repo.SuraClaims.Actividad.bttn_PreguntasPendientes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Actividad.ventana_PreguntasPendientes'", repo.SuraClaims.Actividad.ventana_PreguntasPendientesInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SuraClaims.Actividad.ventana_PreguntasPendientesInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.Actividad.label_NumeroPoliza' and assigning its value to variable 'NumeroPoliza'.", repo.SuraClaims.Actividad.label_NumeroPolizaInfo, new RecordItemIndex(3));
            NumeroPoliza = repo.SuraClaims.Actividad.label_NumeroPoliza.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NumeroPoliza, new RecordItemIndex(4));
            
            obtenerTipoPoliza();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", TipoPoliza, new RecordItemIndex(6));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
