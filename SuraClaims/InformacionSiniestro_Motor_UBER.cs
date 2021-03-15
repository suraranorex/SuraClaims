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
    ///The InformacionSiniestro_Motor_UBER recording.
    /// </summary>
    [TestModule("335b1193-4ca1-4305-99be-324813a08a34", ModuleType.Recording, 1)]
    public partial class InformacionSiniestro_Motor_UBER : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static InformacionSiniestro_Motor_UBER instance = new InformacionSiniestro_Motor_UBER();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionSiniestro_Motor_UBER()
        {
            DetalleSiniestro = "Ingreso el detalle del siniestro ocurrido";
            CausaSiniestro = "Otros";
            TipoCalle = "Calle";
            Provincia = "BUENOS AIRES";
            Localidad = "LOMAS DE ZAMORA";
            Calle = "Loria";
            Numero = "1828";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionSiniestro_Motor_UBER Instance
        {
            get { return instance; }
        }

#region Variables

        string _DetalleSiniestro;

        /// <summary>
        /// Gets or sets the value of variable DetalleSiniestro.
        /// </summary>
        [TestVariable("e900df8d-a096-4f12-b5b9-7f7165ecf96d")]
        public string DetalleSiniestro
        {
            get { return _DetalleSiniestro; }
            set { _DetalleSiniestro = value; }
        }

        string _CausaSiniestro;

        /// <summary>
        /// Gets or sets the value of variable CausaSiniestro.
        /// </summary>
        [TestVariable("32648fde-a792-4bd2-8843-ab929cd86b7d")]
        public string CausaSiniestro
        {
            get { return _CausaSiniestro; }
            set { _CausaSiniestro = value; }
        }

        string _TipoCalle;

        /// <summary>
        /// Gets or sets the value of variable TipoCalle.
        /// </summary>
        [TestVariable("7d8a40b4-cb6d-4f97-bb10-82161197436a")]
        public string TipoCalle
        {
            get { return _TipoCalle; }
            set { _TipoCalle = value; }
        }

        string _Provincia;

        /// <summary>
        /// Gets or sets the value of variable Provincia.
        /// </summary>
        [TestVariable("635f31ac-9079-4677-a7b3-388a3ded1533")]
        public string Provincia
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }

        string _Localidad;

        /// <summary>
        /// Gets or sets the value of variable Localidad.
        /// </summary>
        [TestVariable("3a1cd2bf-dfea-4767-9a0f-6a4c889cce4a")]
        public string Localidad
        {
            get { return _Localidad; }
            set { _Localidad = value; }
        }

        string _Calle;

        /// <summary>
        /// Gets or sets the value of variable Calle.
        /// </summary>
        [TestVariable("aced0f7b-18bd-449c-8404-19d7faef06e9")]
        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; }
        }

        string _Numero;

        /// <summary>
        /// Gets or sets the value of variable Numero.
        /// </summary>
        [TestVariable("057287c0-d165-4e8a-8516-f625e2f0abe1")]
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFail' at Center.", repo.SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFailInfo, new RecordItemIndex(0));
                repo.SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFail.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestro'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DetalleSiniestro' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_DetalleSiniestro'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_DetalleSiniestroInfo, new RecordItemIndex(2));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_DetalleSiniestro.PressKeys(DetalleSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(3));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestro'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestroInfo, new RecordItemIndex(5));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CausaSiniestro' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestroInfo, new RecordItemIndex(6));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro.PressKeys(CausaSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(7));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CausaSiniestro'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CausaSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(8));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CausaSiniestroInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Subrogacion'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_SubrogacionInfo, new RecordItemIndex(9));
            //Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Subrogacion);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'NO' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Subrogacion'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_SubrogacionInfo, new RecordItemIndex(10));
            //repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Subrogacion.PressKeys("NO");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(11));
            //repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Subrogacion'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_SubrogacionInfo, new ActionTimeout(30000), new RecordItemIndex(12));
            //repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_SubrogacionInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalle'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalleInfo, new RecordItemIndex(13));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalle);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoCalle' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalle'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalleInfo, new RecordItemIndex(14));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalle.PressKeys(TipoCalle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(15));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_TipoCalle'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_TipoCalleInfo, new ActionTimeout(30000), new RecordItemIndex(16));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_TipoCalleInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ProvinciaInfo, new RecordItemIndex(17));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Provincia' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ProvinciaInfo, new RecordItemIndex(18));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia.PressKeys(Provincia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(19));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Provincia'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ProvinciaInfo, new ActionTimeout(30000), new RecordItemIndex(20));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ProvinciaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_LocalidadInfo, new RecordItemIndex(21));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Localidad' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_LocalidadInfo, new RecordItemIndex(22));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad.PressKeys(Localidad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(23));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Localidad'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_LocalidadInfo, new ActionTimeout(30000), new RecordItemIndex(24));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_LocalidadInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Calle' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Calle'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CalleInfo, new RecordItemIndex(25));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Calle.PressKeys(Calle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(26));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Calle'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CalleInfo, new ActionTimeout(30000), new RecordItemIndex(27));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CalleInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Numero' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_NumeroInfo, new RecordItemIndex(28));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Numero.PressKeys(Numero);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(29));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Numero'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_NumeroInfo, new ActionTimeout(30000), new RecordItemIndex(30));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_NumeroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccion' at 35;9.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccionInfo, new RecordItemIndex(31));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccion.Click("35;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'SuraClaims.Motor.option_VerificaLaDireccion'", repo.SuraClaims.Motor.option_VerificaLaDireccionInfo, new ActionTimeout(15000), new RecordItemIndex(32));
            repo.SuraClaims.Motor.option_VerificaLaDireccionInfo.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.option_VerificaLaDireccion' at 19;5.", repo.SuraClaims.Motor.option_VerificaLaDireccionInfo, new RecordItemIndex(33));
            repo.SuraClaims.Motor.option_VerificaLaDireccion.Click("19;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Verificada'", repo.SuraClaims.Txt_Validaciones.txt_VerificadaInfo, new ActionTimeout(40000), new RecordItemIndex(34));
            repo.SuraClaims.Txt_Validaciones.txt_VerificadaInfo.WaitForExists(40000);
            
            // Datos UBER
            Report.Log(ReportLevel.Info, "Section", "Datos UBER", new RecordItemIndex(35));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtSAFE_MotorUber' at Center.", repo.SuraClaims.AP_Uber.txtSAFE_MotorUberInfo, new RecordItemIndex(36));
            repo.SuraClaims.AP_Uber.txtSAFE_MotorUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.AP_Uber.txtSAFE_MotorUber'.", repo.SuraClaims.AP_Uber.txtSAFE_MotorUberInfo, new RecordItemIndex(37));
            repo.SuraClaims.AP_Uber.txtSAFE_MotorUber.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1627373' with focus on 'SuraClaims.AP_Uber.txtSAFE_MotorUber'.", repo.SuraClaims.AP_Uber.txtSAFE_MotorUberInfo, new RecordItemIndex(38));
            repo.SuraClaims.AP_Uber.txtSAFE_MotorUber.PressKeys("1627373");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(39));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(40));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txtNivel' at 7;13.", repo.SuraClaims.Motor.InformacionSiniestro.txtNivelInfo, new RecordItemIndex(41));
            //repo.SuraClaims.Motor.InformacionSiniestro.txtNivel.Click("7;13");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisor' at 17;13.", repo.SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisorInfo, new RecordItemIndex(42));
            //repo.SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisor.Click("17;13");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txtEstado' at 6;10.", repo.SuraClaims.Motor.InformacionSiniestro.txtEstadoInfo, new RecordItemIndex(43));
            //repo.SuraClaims.Motor.InformacionSiniestro.txtEstado.Click("6;10");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisor' at 34;9.", repo.SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisorInfo, new RecordItemIndex(44));
            //repo.SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisor.Click("34;9");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber1' at 34;8.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUber1Info, new RecordItemIndex(45));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber1.Click("34;8");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
