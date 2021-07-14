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

namespace SuraClaims.Motor
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CompletarInfo_Incendio recording.
    /// </summary>
    [TestModule("6cbfa79b-4aea-43ba-b2d5-0c97c9fd7b4e", ModuleType.Recording, 1)]
    public partial class CompletarInfo_Incendio : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static CompletarInfo_Incendio instance = new CompletarInfo_Incendio();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CompletarInfo_Incendio()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CompletarInfo_Incendio Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.input_FocoIncendio' at Center.", repo.SuraClaims.Motor.input_FocoIncendioInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.input_FocoIncendio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.option_FocoIncendio' at Center.", repo.SuraClaims.Motor.option_FocoIncendioInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.option_FocoIncendio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.lbl_Incendio' at Center.", repo.SuraClaims.Motor.lbl_IncendioInfo, new RecordItemIndex(2));
            repo.SuraClaims.Motor.lbl_Incendio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to not exist. Associated repository item: 'SuraClaims.Motor.Copy_of_input_FocoIncendio'", repo.SuraClaims.Motor.Copy_of_input_FocoIncendioInfo, new ActionTimeout(20000), new RecordItemIndex(3));
            repo.SuraClaims.Motor.Copy_of_input_FocoIncendioInfo.WaitForNotExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.input_ComoSeApago' at Center.", repo.SuraClaims.Motor.input_ComoSeApagoInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.input_ComoSeApago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.option_ComoSeApago' at Center.", repo.SuraClaims.Motor.option_ComoSeApagoInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.option_ComoSeApago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.lbl_Incendio' at Center.", repo.SuraClaims.Motor.lbl_IncendioInfo, new RecordItemIndex(6));
            repo.SuraClaims.Motor.lbl_Incendio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to not exist. Associated repository item: 'SuraClaims.Motor.Copy_of_input_ComoSeApago'", repo.SuraClaims.Motor.Copy_of_input_ComoSeApagoInfo, new ActionTimeout(20000), new RecordItemIndex(7));
            repo.SuraClaims.Motor.Copy_of_input_ComoSeApagoInfo.WaitForNotExists(20000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}