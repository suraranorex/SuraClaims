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
    ///The SeleccionarPersonas recording.
    /// </summary>
    [TestModule("b9e7b7c6-39f5-41e2-b917-a08ee4a85bb7", ModuleType.Recording, 1)]
    public partial class SeleccionarPersonas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static SeleccionarPersonas instance = new SeleccionarPersonas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SeleccionarPersonas()
        {
            Nombre = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SeleccionarPersonas Instance
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
        /// Gets or sets the value of variable Nombre.
        /// </summary>
        [TestVariable("8ddc398a-bf46-43a7-afd4-787a2ffa676e")]
        public string Nombre
        {
            get { return repo.NOMBRE; }
            set { repo.NOMBRE = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.check_PersonaImplicada' at Center.", repo.SuraClaims.AP_Uber.check_PersonaImplicadaInfo, new RecordItemIndex(0));
            repo.SuraClaims.AP_Uber.check_PersonaImplicada.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.AP_Uber.txt_Nombre' and assigning its value to variable 'Nombre'.", repo.SuraClaims.AP_Uber.txt_NombreInfo, new RecordItemIndex(2));
            Nombre = repo.SuraClaims.AP_Uber.txt_Nombre.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Nombre, new RecordItemIndex(3));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(5));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}