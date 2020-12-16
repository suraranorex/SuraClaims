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
    ///The Cerradura recording.
    /// </summary>
    [TestModule("57ec232e-229d-4f59-bee9-b5093e4a518d", ModuleType.Recording, 1)]
    public partial class Cerradura : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static Cerradura instance = new Cerradura();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Cerradura()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Cerradura Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.tag_Descripcion' at 43;10.", repo.SuraClaims.Motor.InformacionSiniestro.tag_DescripcionInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.InformacionSiniestro.tag_Descripcion.Click("43;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.Cantidad' at 29;11.", repo.SuraClaims.Motor.InformacionBasica.CantidadInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionBasica.Cantidad.Click("29;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.tag_Descripcion' at 44;9.", repo.SuraClaims.Motor.InformacionSiniestro.tag_DescripcionInfo, new RecordItemIndex(3));
            repo.SuraClaims.Motor.InformacionSiniestro.tag_Descripcion.Click("44;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_tipo' at 36;7.", repo.SuraClaims.Motor.InformacionBasica.option_tipoInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.InformacionBasica.option_tipo.Click("36;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAsegurado' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAsegurado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SuraClaims.Motor.lbl_ReposicionDe'", repo.SuraClaims.Motor.lbl_ReposicionDeInfo, new ActionTimeout(10000), new RecordItemIndex(6));
            repo.SuraClaims.Motor.lbl_ReposicionDeInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.Button' at 7;7.", repo.SuraClaims.Motor.ButtonInfo, new RecordItemIndex(7));
            repo.SuraClaims.Motor.Button.Click("7;7");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
