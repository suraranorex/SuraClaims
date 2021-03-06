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
    ///The Completar_AjusteDanios recording.
    /// </summary>
    [TestModule("4a37b052-84cc-4c62-8b0d-505b4a9b29f1", ModuleType.Recording, 1)]
    public partial class Completar_AjusteDanios : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static Completar_AjusteDanios instance = new Completar_AjusteDanios();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Completar_AjusteDanios()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Completar_AjusteDanios Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Reclamos.input_AjusteDanios'", repo.SuraClaims.Reclamos.input_AjusteDaniosInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.SuraClaims.Reclamos.input_AjusteDaniosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Reclamos.input_AjusteDanios' at Center.", repo.SuraClaims.Reclamos.input_AjusteDaniosInfo, new RecordItemIndex(1));
            repo.SuraClaims.Reclamos.input_AjusteDanios.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1000' with focus on 'SuraClaims.Reclamos.input_AjusteDanios'.", repo.SuraClaims.Reclamos.input_AjusteDaniosInfo, new RecordItemIndex(2));
            repo.SuraClaims.Reclamos.input_AjusteDanios.PressKeys("1000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.Reclamos.input_AjusteDanios'.", repo.SuraClaims.Reclamos.input_AjusteDaniosInfo, new RecordItemIndex(3));
            repo.SuraClaims.Reclamos.input_AjusteDanios.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
