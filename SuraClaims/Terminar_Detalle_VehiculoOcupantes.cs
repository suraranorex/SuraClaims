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

namespace SuraClaims
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Terminar_Detalle_VehiculoOcupantes recording.
    /// </summary>
    [TestModule("c2c2c4e6-a847-41d7-a0f9-0d449d03597d", ModuleType.Recording, 1)]
    public partial class Terminar_Detalle_VehiculoOcupantes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static Terminar_Detalle_VehiculoOcupantes instance = new Terminar_Detalle_VehiculoOcupantes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Terminar_Detalle_VehiculoOcupantes()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Terminar_Detalle_VehiculoOcupantes Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Daños ocasionados' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_DescripcionDeLosDanios'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_DescripcionDeLosDaniosInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_DescripcionDeLosDanios.PressKeys("Daños ocasionados");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAsegurado' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAsegurado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DescripcionDeLosDanios'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DescripcionDeLosDaniosInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DescripcionDeLosDaniosInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AceptarInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
