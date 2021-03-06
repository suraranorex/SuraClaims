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
    ///The IngresarReclamo recording.
    /// </summary>
    [TestModule("3d8ef32d-056a-41ad-8ba2-b7cc4500e8f6", ModuleType.Recording, 1)]
    public partial class IngresarReclamo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static IngresarReclamo instance = new IngresarReclamo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IngresarReclamo()
        {
            CodigoReclamo = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static IngresarReclamo Instance
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
        /// Gets or sets the value of variable CodigoReclamo.
        /// </summary>
        [TestVariable("c8058d98-3223-49cd-8774-96f2172317bc")]
        public string CodigoReclamo
        {
            get { return repo.CodigoReclamo; }
            set { repo.CodigoReclamo = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.Reclamos.tag_Reclamo' and assigning the part of its value captured by '[0-9]+' to variable 'CodigoReclamo'.", repo.SuraClaims.Reclamos.tag_ReclamoInfo, new RecordItemIndex(0));
            CodigoReclamo = repo.SuraClaims.Reclamos.tag_Reclamo.Element.GetAttributeValueText("InnerText", new Regex("[0-9]+"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", CodigoReclamo, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Reclamos.tag_Reclamo' at Center.", repo.SuraClaims.Reclamos.tag_ReclamoInfo, new RecordItemIndex(2));
            repo.SuraClaims.Reclamos.tag_Reclamo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Reclamos.txt_ItemReclamo'", repo.SuraClaims.Reclamos.txt_ItemReclamoInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SuraClaims.Reclamos.txt_ItemReclamoInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
