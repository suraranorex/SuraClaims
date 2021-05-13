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
    ///The Asignar_Tramitador recording.
    /// </summary>
    [TestModule("8cfe90ab-a7b7-45f4-95f2-44f0e6c9965d", ModuleType.Recording, 1)]
    public partial class Asignar_Tramitador : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static Asignar_Tramitador instance = new Asignar_Tramitador();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Asignar_Tramitador()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Asignar_Tramitador Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.JuiciosYMediaciones.arrow_AsignarTramitador' at Center.", repo.SuraClaims.JuiciosYMediaciones.arrow_AsignarTramitadorInfo, new RecordItemIndex(0));
            repo.SuraClaims.JuiciosYMediaciones.arrow_AsignarTramitador.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.JuiciosYMediaciones.option_BuscarUsuario' at Center.", repo.SuraClaims.JuiciosYMediaciones.option_BuscarUsuarioInfo, new RecordItemIndex(1));
            repo.SuraClaims.JuiciosYMediaciones.option_BuscarUsuario.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SuraClaims.JuiciosYMediaciones.txt_BuscarAsignacion'", repo.SuraClaims.JuiciosYMediaciones.txt_BuscarAsignacionInfo, new ActionTimeout(20000), new RecordItemIndex(2));
            repo.SuraClaims.JuiciosYMediaciones.txt_BuscarAsignacionInfo.WaitForExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.JuiciosYMediaciones.bttn_Buscar' at Center.", repo.SuraClaims.JuiciosYMediaciones.bttn_BuscarInfo, new RecordItemIndex(3));
            repo.SuraClaims.JuiciosYMediaciones.bttn_Buscar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.JuiciosYMediaciones.bttn_Asignar' at Center.", repo.SuraClaims.JuiciosYMediaciones.bttn_AsignarInfo, new RecordItemIndex(4));
            repo.SuraClaims.JuiciosYMediaciones.bttn_Asignar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SuraClaims.JuiciosYMediaciones.txt_NuevoRegistro'", repo.SuraClaims.JuiciosYMediaciones.txt_NuevoRegistroInfo, new ActionTimeout(20000), new RecordItemIndex(5));
            repo.SuraClaims.JuiciosYMediaciones.txt_NuevoRegistroInfo.WaitForExists(20000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
