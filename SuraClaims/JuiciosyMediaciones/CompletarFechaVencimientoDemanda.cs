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
    ///The CompletarFechaVencimientoDemanda recording.
    /// </summary>
    [TestModule("6d5f8bc9-6ecd-483b-92c2-cf956d608bdb", ModuleType.Recording, 1)]
    public partial class CompletarFechaVencimientoDemanda : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static CompletarFechaVencimientoDemanda instance = new CompletarFechaVencimientoDemanda();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CompletarFechaVencimientoDemanda()
        {
            FechaSiniestro = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CompletarFechaVencimientoDemanda Instance
        {
            get { return instance; }
        }

#region Variables

        string _FechaSiniestro;

        /// <summary>
        /// Gets or sets the value of variable FechaSiniestro.
        /// </summary>
        [TestVariable("3de5ced6-7a7a-448b-9aeb-eecde99678fd")]
        public string FechaSiniestro
        {
            get { return _FechaSiniestro; }
            set { _FechaSiniestro = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.JuiciosYMediaciones.txt_FechaSiniestro' and assigning its value to variable 'FechaSiniestro'.", repo.SuraClaims.JuiciosYMediaciones.txt_FechaSiniestroInfo, new RecordItemIndex(0));
            FechaSiniestro = repo.SuraClaims.JuiciosYMediaciones.txt_FechaSiniestro.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FechaSiniestro' with focus on 'SuraClaims.JuiciosYMediaciones.input_FechaVencimientoDemanda'.", repo.SuraClaims.JuiciosYMediaciones.input_FechaVencimientoDemandaInfo, new RecordItemIndex(1));
            repo.SuraClaims.JuiciosYMediaciones.input_FechaVencimientoDemanda.PressKeys(FechaSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.JuiciosYMediaciones.txt_NuevoRegistro' at Center.", repo.SuraClaims.JuiciosYMediaciones.txt_NuevoRegistroInfo, new RecordItemIndex(2));
            repo.SuraClaims.JuiciosYMediaciones.txt_NuevoRegistro.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
