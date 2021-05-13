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

namespace SuraClaims.AP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Reclamos_AP recording.
    /// </summary>
    [TestModule("94d73442-04fc-4dfc-99b8-de1874570730", ModuleType.Recording, 1)]
    public partial class Reclamos_AP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static Reclamos_AP instance = new Reclamos_AP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Reclamos_AP()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Reclamos_AP Instance
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
        /// Gets or sets the value of variable NombreLesionado.
        /// </summary>
        [TestVariable("9c849daa-a7f3-445d-b9d7-1521b0728a90")]
        public string NombreLesionado
        {
            get { return repo.NombreLesionado; }
            set { repo.NombreLesionado = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.bttn_NuevoReclamo' at Center.", repo.SuraClaims.Hogar.bttn_NuevoReclamoInfo, new RecordItemIndex(0));
            repo.SuraClaims.Hogar.bttn_NuevoReclamo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'option_NombreLesionado3' at Center.", repo.option_NombreLesionado3Info, new RecordItemIndex(1));
            repo.option_NombreLesionado3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.option_Reclamo' at Center.", repo.SuraClaims.AP_Uber.option_ReclamoInfo, new RecordItemIndex(2));
            repo.SuraClaims.AP_Uber.option_Reclamo.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.option_IncapacidadTotal' at Center.", repo.SuraClaims.AP_Uber.option_IncapacidadTotalInfo, new RecordItemIndex(3));
            //repo.SuraClaims.AP_Uber.option_IncapacidadTotal.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Hogar.txt_NuevaExposicion'", repo.SuraClaims.Hogar.txt_NuevaExposicionInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            repo.SuraClaims.Hogar.txt_NuevaExposicionInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
