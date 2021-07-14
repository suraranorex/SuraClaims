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

namespace SuraClaims.Reclamos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ActualizarReclamo recording.
    /// </summary>
    [TestModule("a26bff71-87f3-49ee-a14d-bc02081a330a", ModuleType.Recording, 1)]
    public partial class ActualizarReclamo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static ActualizarReclamo instance = new ActualizarReclamo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActualizarReclamo()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActualizarReclamo Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Reclamos.bttn_Actualizar'", repo.SuraClaims.Reclamos.bttn_ActualizarInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.SuraClaims.Reclamos.bttn_ActualizarInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Reclamos.bttn_Actualizar' at Center.", repo.SuraClaims.Reclamos.bttn_ActualizarInfo, new RecordItemIndex(1));
            repo.SuraClaims.Reclamos.bttn_Actualizar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Reclamos.bttn_FinalizarChecklist'", repo.SuraClaims.Reclamos.bttn_FinalizarChecklistInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SuraClaims.Reclamos.bttn_FinalizarChecklistInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Reclamos.bttn_FinalizarChecklist' at Center.", repo.SuraClaims.Reclamos.bttn_FinalizarChecklistInfo, new RecordItemIndex(3));
            repo.SuraClaims.Reclamos.bttn_FinalizarChecklist.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Reclamos.bttn_CheckListFinalizado'", repo.SuraClaims.Reclamos.bttn_CheckListFinalizadoInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            repo.SuraClaims.Reclamos.bttn_CheckListFinalizadoInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}