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
    ///The InformacionBasica_CompletarTelMail recording.
    /// </summary>
    [TestModule("2c023744-04a7-478f-998d-a34c8715eb08", ModuleType.Recording, 1)]
    public partial class InformacionBasica_CompletarTelMail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static InformacionBasica_CompletarTelMail instance = new InformacionBasica_CompletarTelMail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionBasica_CompletarTelMail()
        {
            NumTelefono = "32039201";
            Correo = "prueba@gmail.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionBasica_CompletarTelMail Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumTelefono;

        /// <summary>
        /// Gets or sets the value of variable NumTelefono.
        /// </summary>
        [TestVariable("ae06ff49-2c88-4cf2-90b1-cf0f65392a66")]
        public string NumTelefono
        {
            get { return _NumTelefono; }
            set { _NumTelefono = value; }
        }

        string _Correo;

        /// <summary>
        /// Gets or sets the value of variable Correo.
        /// </summary>
        [TestVariable("0e606bcb-709d-4fac-89b5-37bded33b849")]
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
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

            // No hace falta. Se completa automáticamente porque no estoy cargando una persona nueva sino que seleccioné al asegurado
            //Report.Log(ReportLevel.Info, "Section", "No hace falta. Se completa automáticamente porque no estoy cargando una persona nueva sino que seleccioné al asegurado", new RecordItemIndex(0));
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Asegurado' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_RelacionConAsegurado'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_RelacionConAseguradoInfo, new RecordItemIndex(1));
            //repo.SuraClaims.Motor.InformacionBasica.txtbox_RelacionConAsegurado.PressKeys("Asegurado");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(2));
            //repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_RelacionConAsegurado'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_RelacionConAseguradoInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            //repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_RelacionConAseguradoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.input_TelefonoNinguna' at 66;16.", repo.SuraClaims.Motor.InformacionBasica.input_TelefonoNingunaInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.InformacionBasica.input_TelefonoNinguna.Click("66;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.JuiciosYMediaciones.option_Reclamo' at 13;14.", repo.SuraClaims.JuiciosYMediaciones.option_ReclamoInfo, new RecordItemIndex(5));
            repo.SuraClaims.JuiciosYMediaciones.option_Reclamo.Click("13;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal'", repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipalInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipalInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipalInfo, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Particular' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipalInfo, new RecordItemIndex(8));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal.PressKeys("Particular");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(9));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipal'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipalInfo, new ActionTimeout(30000), new RecordItemIndex(10));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipalInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeAreaInfo, new RecordItemIndex(11));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '011' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeAreaInfo, new RecordItemIndex(12));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea.PressKeys("011");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(13));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeArea'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeAreaInfo, new ActionTimeout(30000), new RecordItemIndex(14));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeAreaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_NumeroInfo, new RecordItemIndex(15));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_Numero);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumTelefono' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_NumeroInfo, new RecordItemIndex(16));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_Numero.PressKeys(NumTelefono);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(17));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_Numero'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NumeroInfo, new ActionTimeout(30000), new RecordItemIndex(18));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NumeroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronicoInfo, new RecordItemIndex(19));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Correo' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronicoInfo, new RecordItemIndex(20));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico.PressKeys(Correo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(21));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}