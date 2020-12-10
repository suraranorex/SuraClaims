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
    ///The InformacionBasica_Hogar recording.
    /// </summary>
    [TestModule("c8c5ed1d-1384-48cf-bc1f-d3091e43bd0a", ModuleType.Recording, 1)]
    public partial class InformacionBasica_Hogar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static InformacionBasica_Hogar instance = new InformacionBasica_Hogar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionBasica_Hogar()
        {
            NumTelefono = "32039201";
            Correo = "prueba@gmail.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionBasica_Hogar Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumTelefono;

        /// <summary>
        /// Gets or sets the value of variable NumTelefono.
        /// </summary>
        [TestVariable("42efe7c8-ae15-460e-ba5a-d694a228a260")]
        public string NumTelefono
        {
            get { return _NumTelefono; }
            set { _NumTelefono = value; }
        }

        string _Correo;

        /// <summary>
        /// Gets or sets the value of variable Correo.
        /// </summary>
        [TestVariable("24a91463-8178-4708-a7eb-e7d015801354")]
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipalInfo, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Particular' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipalInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal.PressKeys("Particular");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(2));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipal'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipalInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipalInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeAreaInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '011' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeAreaInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea.PressKeys("011");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(6));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeArea'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeAreaInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeAreaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_NumeroInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_Numero);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumTelefono' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_NumeroInfo, new RecordItemIndex(9));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_Numero.PressKeys(NumTelefono);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(10));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_Numero'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NumeroInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NumeroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronicoInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Correo' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronicoInfo, new RecordItemIndex(13));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico.PressKeys(Correo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(14));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CorreoElectronico'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CorreoElectronicoInfo, new ActionTimeout(30000), new RecordItemIndex(15));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CorreoElectronicoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(17));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(18));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
