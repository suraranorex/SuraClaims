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
    ///The Reclamos_Hogar recording.
    /// </summary>
    [TestModule("425e1d90-507b-42f0-b118-db68031d891f", ModuleType.Recording, 1)]
    public partial class Reclamos_Hogar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static Reclamos_Hogar instance = new Reclamos_Hogar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Reclamos_Hogar()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Reclamos_Hogar Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.bttn_NuevoReclamo' at 35;2.", repo.SuraClaims.Hogar.bttn_NuevoReclamoInfo, new RecordItemIndex(0));
            repo.SuraClaims.Hogar.bttn_NuevoReclamo.Click("35;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.tag_Ubicacion' at 32;8.", repo.SuraClaims.Hogar.tag_UbicacionInfo, new RecordItemIndex(1));
            repo.SuraClaims.Hogar.tag_Ubicacion.Click("32;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.option_IncendioEdificioAProrrata' at 23;14.", repo.SuraClaims.Hogar.option_IncendioEdificioAProrrataInfo, new RecordItemIndex(2));
            repo.SuraClaims.Hogar.option_IncendioEdificioAProrrata.Click("23;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Hogar.txt_NuevaExposicion'", repo.SuraClaims.Hogar.txt_NuevaExposicionInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SuraClaims.Hogar.txt_NuevaExposicionInfo.WaitForExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar' at 20;4.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AceptarInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar.Click("20;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso4'", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4Info.WaitForExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(7));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
