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
    ///The Reclamos_AP recording.
    /// </summary>
    [TestModule("94d73442-04fc-4dfc-99b8-de1874570730", ModuleType.Recording, 1)]
    public partial class Reclamos_AP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

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
        /// Gets or sets the value of variable NOMBRE.
        /// </summary>
        [TestVariable("5708cec9-a319-4013-82b4-d7025ac889ce")]
        public string NOMBRE
        {
            get { return repo.NOMBRE; }
            set { repo.NOMBRE = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.bttn_NuevoReclamo' at Center.", repo.SuraClaims.Hogar.bttn_NuevoReclamoInfo, new RecordItemIndex(0));
            repo.SuraClaims.Hogar.bttn_NuevoReclamo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_NombreLesionado3' at Center.", repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionado3Info, new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionado3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.option_ReembolsoGastos' at Center.", repo.SuraClaims.AP_Uber.option_ReembolsoGastosInfo, new RecordItemIndex(2));
            repo.SuraClaims.AP_Uber.option_ReembolsoGastos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Hogar.txt_NuevaExposicion'", repo.SuraClaims.Hogar.txt_NuevaExposicionInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SuraClaims.Hogar.txt_NuevaExposicionInfo.WaitForExists(30000);
            
            // Nueva Exposición
            Report.Log(ReportLevel.Info, "Section", "Nueva Exposición", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtbox_Reclamante' at Center.", repo.SuraClaims.AP_Uber.txtbox_ReclamanteInfo, new RecordItemIndex(5));
            repo.SuraClaims.AP_Uber.txtbox_Reclamante.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_ReclamanteUber' at Center.", repo.SuraClaims.Motor.InformacionBasica.option_ReclamanteUberInfo, new RecordItemIndex(6));
            repo.SuraClaims.Motor.InformacionBasica.option_ReclamanteUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtbox_Reclamante'", repo.SuraClaims.AP_Uber.Copy_of_txtbox_ReclamanteInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.SuraClaims.AP_Uber.Copy_of_txtbox_ReclamanteInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtbox_Tipo' at Center.", repo.SuraClaims.AP_Uber.txtbox_TipoInfo, new RecordItemIndex(8));
            repo.SuraClaims.AP_Uber.txtbox_Tipo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Cadete en moto' with focus on 'SuraClaims.AP_Uber.txtbox_Tipo'.", repo.SuraClaims.AP_Uber.txtbox_TipoInfo, new RecordItemIndex(9));
            repo.SuraClaims.AP_Uber.txtbox_Tipo.PressKeys("Cadete en moto");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Hogar.txt_NuevaExposicion' at Center.", repo.SuraClaims.Hogar.txt_NuevaExposicionInfo, new RecordItemIndex(10));
            repo.SuraClaims.Hogar.txt_NuevaExposicion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtbox_Tipo'", repo.SuraClaims.AP_Uber.Copy_of_txtbox_TipoInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.SuraClaims.AP_Uber.Copy_of_txtbox_TipoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(12));
            
            // Agrego lesiones - Información Básica
            Report.Log(ReportLevel.Info, "Section", "Agrego lesiones - Información Básica", new RecordItemIndex(13));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.bttn_AgregarLesion' at Center.", repo.SuraClaims.AP_Uber.bttn_AgregarLesionInfo, new RecordItemIndex(14));
            //repo.SuraClaims.AP_Uber.bttn_AgregarLesion.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.btn_AddIncidente' at Center.", repo.SuraClaims.AP_Uber.btn_AddIncidenteInfo, new RecordItemIndex(15));
            repo.SuraClaims.AP_Uber.btn_AddIncidente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.SelectNuevoIncidente' at Center.", repo.SuraClaims.AP_Uber.SelectNuevoIncidenteInfo, new RecordItemIndex(16));
            repo.SuraClaims.AP_Uber.SelectNuevoIncidente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionada' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionadaInfo, new RecordItemIndex(18));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionada.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_NombreLesionado' at Center.", repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionadoInfo, new RecordItemIndex(19));
            repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(20));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentadoInfo, new RecordItemIndex(21));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '21/06/2020' with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporte'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporteInfo, new RecordItemIndex(22));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporte.PressKeys("21/06/2020");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new RecordItemIndex(23));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporte'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporteInfo, new ActionTimeout(30000), new RecordItemIndex(24));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporteInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamoInfo, new RecordItemIndex(25));
            Keyboard.PrepareFocus(repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Por mostrador' with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamoInfo, new RecordItemIndex(26));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo.PressKeys("Por mostrador");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new RecordItemIndex(27));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamo'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamoInfo, new ActionTimeout(30000), new RecordItemIndex(28));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(29));
            
            // Descripción de lesiones
            Report.Log(ReportLevel.Info, "Section", "Descripción de lesiones", new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesiones' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesionesInfo, new RecordItemIndex(31));
            repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesiones.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesiones'", repo.SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesionesInfo, new ActionTimeout(30000), new RecordItemIndex(32));
            repo.SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesionesInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(33));
            Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(34));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(35));
            //Keyboard.PrepareFocus(repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Peatón' with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(36));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.PressKeys("Peatón");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(37));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.PressKeys("{Return}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictima'", repo.SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictimaInfo, new ActionTimeout(30000), new RecordItemIndex(38));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictimaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.bttn_Ambulancia' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.bttn_AmbulanciaInfo, new RecordItemIndex(39));
            repo.SuraClaims.AP_Uber.DescripcionLesiones.bttn_Ambulancia.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(40));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictima' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictimaInfo, new RecordItemIndex(41));
            repo.SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictima.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(42));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.fila_Lesion'", repo.SuraClaims.AP_Uber.DescripcionLesiones.fila_LesionInfo, new ActionTimeout(40000), new RecordItemIndex(43));
            repo.SuraClaims.AP_Uber.DescripcionLesiones.fila_LesionInfo.WaitForExists(40000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(44));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AceptarInfo, new RecordItemIndex(45));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(46));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.btn_AceptarExpo' at 20;5.", repo.SuraClaims.AP_Uber.btn_AceptarExpoInfo, new RecordItemIndex(47));
            repo.SuraClaims.AP_Uber.btn_AceptarExpo.Click("20;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso5'", repo.SuraClaims.Txt_Validaciones.txt_Paso5Info, new ActionTimeout(30000), new RecordItemIndex(48));
            repo.SuraClaims.Txt_Validaciones.txt_Paso5Info.WaitForExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(49));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
