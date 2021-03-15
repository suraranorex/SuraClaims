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
    ///The InformacionSiniestro_AP_Uber recording.
    /// </summary>
    [TestModule("82160f09-1b26-4257-9faf-e5edd2c52ef5", ModuleType.Recording, 1)]
    public partial class InformacionSiniestro_AP_Uber : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static InformacionSiniestro_AP_Uber instance = new InformacionSiniestro_AP_Uber();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionSiniestro_AP_Uber()
        {
            CausaSiniestro = "Accidente In Itinere (AT)";
            Provincia = "BUENOS AIRES";
            Localidad = "LANUS ESTE";
            Calle = "Colón";
            Numero = "1828";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionSiniestro_AP_Uber Instance
        {
            get { return instance; }
        }

#region Variables

        string _CausaSiniestro;

        /// <summary>
        /// Gets or sets the value of variable CausaSiniestro.
        /// </summary>
        [TestVariable("b2b30f97-7dfe-4d09-90e4-cd519bdc17de")]
        public string CausaSiniestro
        {
            get { return _CausaSiniestro; }
            set { _CausaSiniestro = value; }
        }

        string _Provincia;

        /// <summary>
        /// Gets or sets the value of variable Provincia.
        /// </summary>
        [TestVariable("3fa15131-6a0e-47f3-8771-59fd6e083c60")]
        public string Provincia
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }

        string _Localidad;

        /// <summary>
        /// Gets or sets the value of variable Localidad.
        /// </summary>
        [TestVariable("2bf9ab21-80cd-4e12-b8af-19ff149945cf")]
        public string Localidad
        {
            get { return _Localidad; }
            set { _Localidad = value; }
        }

        string _Calle;

        /// <summary>
        /// Gets or sets the value of variable Calle.
        /// </summary>
        [TestVariable("77ecfd0b-b588-4ea5-9f1d-5e825eacf5bc")]
        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; }
        }

        string _Numero;

        /// <summary>
        /// Gets or sets the value of variable Numero.
        /// </summary>
        [TestVariable("484205c6-f516-4301-af19-c8c4ce7d8a04")]
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

            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFail' at Center.", repo.SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFailInfo, new RecordItemIndex(0));
                repo.SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFail.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestro'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.SuraClaims.Hogar.txtbox_CausaSiniestro);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CausaSiniestro' with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(3));
            repo.SuraClaims.Hogar.txtbox_CausaSiniestro.PressKeys(CausaSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(4));
            repo.SuraClaims.Hogar.txtbox_CausaSiniestro.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestro'", repo.SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ProvinciaInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Provincia' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ProvinciaInfo, new RecordItemIndex(7));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia.PressKeys(Provincia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso4' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new RecordItemIndex(8));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Provincia'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ProvinciaInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ProvinciaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_LocalidadInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Localidad' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_LocalidadInfo, new RecordItemIndex(11));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad.PressKeys(Localidad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso4' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new RecordItemIndex(12));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Localidad'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_LocalidadInfo, new ActionTimeout(30000), new RecordItemIndex(13));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_LocalidadInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Calle' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Calle'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CalleInfo, new RecordItemIndex(14));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Calle.PressKeys(Calle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso4' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new RecordItemIndex(15));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Calle'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CalleInfo, new ActionTimeout(30000), new RecordItemIndex(16));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CalleInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Numero' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_NumeroInfo, new RecordItemIndex(17));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Numero.PressKeys(Numero);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso4' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new RecordItemIndex(18));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Numero'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_NumeroInfo, new ActionTimeout(30000), new RecordItemIndex(19));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_NumeroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccion' at 35;9.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccionInfo, new RecordItemIndex(20));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccion.Click("35;9");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'SuraClaims.Motor.option_VerificaLaDireccion'", repo.SuraClaims.Motor.option_VerificaLaDireccionInfo, new ActionTimeout(15000), new RecordItemIndex(21));
            //repo.SuraClaims.Motor.option_VerificaLaDireccionInfo.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.option_VerificaLaDireccion' at 19;5.", repo.SuraClaims.Motor.option_VerificaLaDireccionInfo, new RecordItemIndex(22));
            repo.SuraClaims.Motor.option_VerificaLaDireccion.Click("19;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Verificada'", repo.SuraClaims.Txt_Validaciones.txt_VerificadaInfo, new ActionTimeout(40000), new RecordItemIndex(23));
            repo.SuraClaims.Txt_Validaciones.txt_VerificadaInfo.WaitForExists(40000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(24));
            
            // Agrego lesiones - Información Básica
            Report.Log(ReportLevel.Info, "Section", "Agrego lesiones - Información Básica", new RecordItemIndex(25));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.bttn_AgregarLesion' at Center.", repo.SuraClaims.AP_Uber.bttn_AgregarLesionInfo, new RecordItemIndex(26));
            //repo.SuraClaims.AP_Uber.bttn_AgregarLesion.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new ActionTimeout(30000), new RecordItemIndex(27));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo.WaitForExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionada' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionadaInfo, new RecordItemIndex(28));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionada.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.optionLI_NombreLesionado' at Center.", repo.SuraClaims.Motor.InformacionBasica.optionLI_NombreLesionadoInfo, new RecordItemIndex(29));
            //repo.SuraClaims.Motor.InformacionBasica.optionLI_NombreLesionado.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(30));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentadoInfo, new RecordItemIndex(31));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '21/06/2020' with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporte'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporteInfo, new RecordItemIndex(32));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporte.PressKeys("21/06/2020");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new RecordItemIndex(33));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporte'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporteInfo, new ActionTimeout(30000), new RecordItemIndex(34));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporteInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamoInfo, new RecordItemIndex(35));
            //Keyboard.PrepareFocus(repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Por mostrador' with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamoInfo, new RecordItemIndex(36));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo.PressKeys("Por mostrador");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new RecordItemIndex(37));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamo'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamoInfo, new ActionTimeout(30000), new RecordItemIndex(38));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamoInfo.WaitForNotExists(30000);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(39));
            
            // Descripción de lesiones
            //Report.Log(ReportLevel.Info, "Section", "Descripción de lesiones", new RecordItemIndex(40));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesiones' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesionesInfo, new RecordItemIndex(41));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesiones.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesiones'", repo.SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesionesInfo, new ActionTimeout(30000), new RecordItemIndex(42));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesionesInfo.WaitForExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(43));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(44));
            //Keyboard.PrepareFocus(repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Peatón' with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(45));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.PressKeys("Peatón");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(46));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.PressKeys("{Return}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictima'", repo.SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictimaInfo, new ActionTimeout(30000), new RecordItemIndex(47));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictimaInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.bttn_Ambulancia' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.bttn_AmbulanciaInfo, new RecordItemIndex(48));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.bttn_Ambulancia.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(49));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictima' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictimaInfo, new RecordItemIndex(50));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictima.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.fila_Lesion'", repo.SuraClaims.AP_Uber.DescripcionLesiones.fila_LesionInfo, new ActionTimeout(30000), new RecordItemIndex(51));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.fila_LesionInfo.WaitForExists(30000);
            
            // Datos uber
            Report.Log(ReportLevel.Info, "Section", "Datos uber", new RecordItemIndex(52));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestroInfo, new RecordItemIndex(53));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CausaSiniestro' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestroInfo, new RecordItemIndex(54));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro.PressKeys(CausaSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(55));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtSAFE' at Center.", repo.SuraClaims.AP_Uber.txtSAFEInfo, new RecordItemIndex(56));
            repo.SuraClaims.AP_Uber.txtSAFE.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.AP_Uber.txtSAFE'.", repo.SuraClaims.AP_Uber.txtSAFEInfo, new RecordItemIndex(57));
            repo.SuraClaims.AP_Uber.txtSAFE.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1627373' with focus on 'SuraClaims.AP_Uber.txtSAFE'.", repo.SuraClaims.AP_Uber.txtSAFEInfo, new RecordItemIndex(58));
            repo.SuraClaims.AP_Uber.txtSAFE.PressKeys("1627373");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(59));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtSAFE'", repo.SuraClaims.AP_Uber.Copy_of_txtSAFEInfo, new ActionTimeout(30000), new RecordItemIndex(60));
            repo.SuraClaims.AP_Uber.Copy_of_txtSAFEInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtNivel' at Center.", repo.SuraClaims.AP_Uber.txtNivelInfo, new RecordItemIndex(61));
            repo.SuraClaims.AP_Uber.txtNivel.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'L1' with focus on 'SuraClaims.AP_Uber.txtNivel'.", repo.SuraClaims.AP_Uber.txtNivelInfo, new RecordItemIndex(62));
            repo.SuraClaims.AP_Uber.txtNivel.PressKeys("L1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(63));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtNivel'", repo.SuraClaims.AP_Uber.Copy_of_txtNivelInfo, new ActionTimeout(30000), new RecordItemIndex(64));
            repo.SuraClaims.AP_Uber.Copy_of_txtNivelInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtPeriodo' at Center.", repo.SuraClaims.AP_Uber.txtPeriodoInfo, new RecordItemIndex(65));
            repo.SuraClaims.AP_Uber.txtPeriodo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'P0' with focus on 'SuraClaims.AP_Uber.txtPeriodo'.", repo.SuraClaims.AP_Uber.txtPeriodoInfo, new RecordItemIndex(66));
            repo.SuraClaims.AP_Uber.txtPeriodo.PressKeys("P0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(67));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtPeriodo'", repo.SuraClaims.AP_Uber.Copy_of_txtPeriodoInfo, new ActionTimeout(30000), new RecordItemIndex(68));
            repo.SuraClaims.AP_Uber.Copy_of_txtPeriodoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(69));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(70));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso5'", repo.SuraClaims.Txt_Validaciones.txt_Paso5Info, new ActionTimeout(30000), new RecordItemIndex(71));
            repo.SuraClaims.Txt_Validaciones.txt_Paso5Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
