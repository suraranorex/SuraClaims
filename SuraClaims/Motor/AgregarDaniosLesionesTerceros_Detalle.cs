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
    ///The AgregarDaniosLesionesTerceros_Detalle recording.
    /// </summary>
    [TestModule("e04fa98f-3e00-4afe-bb2e-b02a11583603", ModuleType.Recording, 1)]
    public partial class AgregarDaniosLesionesTerceros_Detalle : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static AgregarDaniosLesionesTerceros_Detalle instance = new AgregarDaniosLesionesTerceros_Detalle();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgregarDaniosLesionesTerceros_Detalle()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgregarDaniosLesionesTerceros_Detalle Instance
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
        /// Gets or sets the value of variable Responsabilidad.
        /// </summary>
        [TestVariable("811dedf4-3591-4699-a423-2ca44a8785f1")]
        public string Responsabilidad
        {
            get { return repo.Responsabilidad; }
            set { repo.Responsabilidad = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NOMBRE.
        /// </summary>
        [TestVariable("5708cec9-a319-4013-82b4-d7025ac889ce")]
        public string NOMBRE
        {
            get { return repo.NOMBRE; }
            set { repo.NOMBRE = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Apellido.
        /// </summary>
        [TestVariable("7ffce370-41b3-46bf-bd04-c0884c142557")]
        public string Apellido
        {
            get { return repo.Apellido; }
            set { repo.Apellido = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.op_ambulancia' at 8;7.", repo.SuraClaims.Motor.op_ambulanciaInfo, new RecordItemIndex(0));
            //repo.SuraClaims.Motor.op_ambulancia.Click("8;7");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.op_ambulancia_NO' at Center.", repo.SuraClaims.Motor.op_ambulancia_NOInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.op_ambulancia_NO.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.op_policia_NO' at Center.", repo.SuraClaims.Motor.op_policia_NOInfo, new RecordItemIndex(2));
            repo.SuraClaims.Motor.op_policia_NO.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.op_responsabilidad' at Center.", repo.SuraClaims.Motor.op_responsabilidadInfo, new RecordItemIndex(3));
            repo.SuraClaims.Motor.op_responsabilidad.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_PropietarioVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_PropietarioVehiculoInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_PropietarioVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(5));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.option_NombrePropietario' at Center.", repo.SuraClaims.InformacionPagoSiniestro.option_NombrePropietarioInfo, new RecordItemIndex(6));
            repo.SuraClaims.InformacionPagoSiniestro.option_NombrePropietario.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.pestana_DescripTipoSiniestro' at Center.", repo.SuraClaims.Motor.pestana_DescripTipoSiniestroInfo, new RecordItemIndex(7));
            repo.SuraClaims.Motor.pestana_DescripTipoSiniestro.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.lbl_Danos'", repo.SuraClaims.Motor.InformacionSiniestro.lbl_DanosInfo, new ActionTimeout(30000), new RecordItemIndex(8));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_DanosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
