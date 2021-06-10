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

namespace SuraClaims.Generales
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InformacionBasica recording.
    /// </summary>
    [TestModule("4afd7ade-4bd3-436e-85a2-aa47e7e56042", ModuleType.Recording, 1)]
    public partial class InformacionBasica : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static InformacionBasica instance = new InformacionBasica();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionBasica()
        {
            Correo = "prueba@gmail.com";
            NumTelefono = "32039201";
            Ambiente = "preproducciongestion.segurossura.com.ar";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionBasica Instance
        {
            get { return instance; }
        }

#region Variables

        string _Correo;

        /// <summary>
        /// Gets or sets the value of variable Correo.
        /// </summary>
        [TestVariable("bab5c512-8f69-4665-bc29-43a4f1d8a3ab")]
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        string _NumTelefono;

        /// <summary>
        /// Gets or sets the value of variable NumTelefono.
        /// </summary>
        [TestVariable("545baad1-7cdc-4ee6-873f-69ea55c3ce58")]
        public string NumTelefono
        {
            get { return _NumTelefono; }
            set { _NumTelefono = value; }
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

        /// <summary>
        /// Gets or sets the value of variable NombreAsegurado.
        /// </summary>
        [TestVariable("40d4fbbd-ac5c-4801-a089-9b02b3349092")]
        public string NombreAsegurado
        {
            get { return repo.NombreAsegurado; }
            set { repo.NombreAsegurado = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.bttn_SelecNombre' at 9;10.", repo.SuraClaims.Motor.InformacionBasica.bttn_SelecNombreInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.InformacionBasica.bttn_SelecNombre.Click("9;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.optionLI_NombreAsegurado' at Center.", repo.SuraClaims.Motor.InformacionBasica.optionLI_NombreAseguradoInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionBasica.optionLI_NombreAsegurado.Click();
            Delay.Milliseconds(0);
            
            //verificarSiTieneDatosCargados();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(3));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_Nombre'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NombreInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NombreInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(6));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
