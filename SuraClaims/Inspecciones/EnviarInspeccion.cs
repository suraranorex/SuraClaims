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

namespace SuraClaims.Inspecciones
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnviarInspeccion recording.
    /// </summary>
    [TestModule("5b636393-0656-4beb-a750-af8629dd8109", ModuleType.Recording, 1)]
    public partial class EnviarInspeccion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static EnviarInspeccion instance = new EnviarInspeccion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnviarInspeccion()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnviarInspeccion Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Inspeccion.lbl_EnviarSolicitud' at Center.", repo.SuraClaims.Inspeccion.lbl_EnviarSolicitudInfo, new RecordItemIndex(0));
            repo.SuraClaims.Inspeccion.lbl_EnviarSolicitud.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Inspeccion.bttn_AceptarVentanaEmergente' at Center.", repo.SuraClaims.Inspeccion.bttn_AceptarVentanaEmergenteInfo, new RecordItemIndex(1));
            repo.SuraClaims.Inspeccion.bttn_AceptarVentanaEmergente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Inspeccion.lbl_EnviarSolicitud'", repo.SuraClaims.Inspeccion.lbl_EnviarSolicitudInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SuraClaims.Inspeccion.lbl_EnviarSolicitudInfo.WaitForNotExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
