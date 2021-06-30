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

namespace SuraClaims.Motor
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DetalleVehiculoAsegurado_Tercero_UBER recording.
    /// </summary>
    [TestModule("742b93f9-8fc9-4f74-9be5-2f8ac179be88", ModuleType.Recording, 1)]
    public partial class DetalleVehiculoAsegurado_Tercero_UBER : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static DetalleVehiculoAsegurado_Tercero_UBER instance = new DetalleVehiculoAsegurado_Tercero_UBER();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DetalleVehiculoAsegurado_Tercero_UBER()
        {
            AnioAutoAsegurado = "2020";
            MarcaAutoAsegurado = "FIAT";
            ModeloAutoAsegurado = "147";
            TipoAutoAsegurado = "AUTO";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DetalleVehiculoAsegurado_Tercero_UBER Instance
        {
            get { return instance; }
        }

#region Variables

        string _AnioAutoAsegurado;

        /// <summary>
        /// Gets or sets the value of variable AnioAutoAsegurado.
        /// </summary>
        [TestVariable("afa805c2-a264-42a1-9e9f-83d3cfc1d93a")]
        public string AnioAutoAsegurado
        {
            get { return _AnioAutoAsegurado; }
            set { _AnioAutoAsegurado = value; }
        }

        string _MarcaAutoAsegurado;

        /// <summary>
        /// Gets or sets the value of variable MarcaAutoAsegurado.
        /// </summary>
        [TestVariable("42dde806-5b73-4b06-a633-60843992e3e5")]
        public string MarcaAutoAsegurado
        {
            get { return _MarcaAutoAsegurado; }
            set { _MarcaAutoAsegurado = value; }
        }

        string _ModeloAutoAsegurado;

        /// <summary>
        /// Gets or sets the value of variable ModeloAutoAsegurado.
        /// </summary>
        [TestVariable("4ddf773e-0faa-4205-b5fa-2b103c5d71e5")]
        public string ModeloAutoAsegurado
        {
            get { return _ModeloAutoAsegurado; }
            set { _ModeloAutoAsegurado = value; }
        }

        string _TipoAutoAsegurado;

        /// <summary>
        /// Gets or sets the value of variable TipoAutoAsegurado.
        /// </summary>
        [TestVariable("8ca84b6e-0ce4-4900-9e9c-4f33db3922e2")]
        public string TipoAutoAsegurado
        {
            get { return _TipoAutoAsegurado; }
            set { _TipoAutoAsegurado = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AceptarInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.tag_Vehiculo' at 21;8.", repo.SuraClaims.Motor.InformacionSiniestro.tag_VehiculoInfo, new RecordItemIndex(2));
            repo.SuraClaims.Motor.InformacionSiniestro.tag_Vehiculo.Click("21;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAsegurado'", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo.WaitForExists(30000);
            
            // Datos de Asegurado
            Report.Log(ReportLevel.Info, "Section", "Datos de Asegurado", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_AgregarConductorUber' at 46;4.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AgregarConductorUberInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_AgregarConductorUber.Click("46;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados'", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionadosInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionadosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Agregar' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AgregarInfo, new RecordItemIndex(7));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Agregar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SuraClaims.Motor.txt_TipoDoc'", repo.SuraClaims.Motor.txt_TipoDocInfo, new ActionTimeout(10000), new RecordItemIndex(8));
            repo.SuraClaims.Motor.txt_TipoDocInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txt_TipoDoc' at Center.", repo.SuraClaims.Motor.txt_TipoDocInfo, new RecordItemIndex(9));
            repo.SuraClaims.Motor.txt_TipoDoc.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.option_DNI' at Center.", repo.SuraClaims.Motor.option_DNIInfo, new RecordItemIndex(10));
            repo.SuraClaims.Motor.option_DNI.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionadosInfo, new RecordItemIndex(11));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Apellido'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ApellidoInfo, new ActionTimeout(20000), new RecordItemIndex(12));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ApellidoInfo.WaitForNotExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_UberInfo, new RecordItemIndex(13));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_UberInfo, new RecordItemIndex(14));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '23143223' with focus on 'SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber'.", repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_UberInfo, new RecordItemIndex(15));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber.PressKeys("23143223");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionadosInfo, new RecordItemIndex(16));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Apellido'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ApellidoInfo, new ActionTimeout(20000), new RecordItemIndex(17));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ApellidoInfo.WaitForNotExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txt_Nombre' at Center.", repo.SuraClaims.AP_Uber.txt_NombreInfo, new RecordItemIndex(18));
            repo.SuraClaims.AP_Uber.txt_Nombre.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Conductor' with focus on 'SuraClaims.AP_Uber.txt_Nombre'.", repo.SuraClaims.AP_Uber.txt_NombreInfo, new RecordItemIndex(19));
            repo.SuraClaims.AP_Uber.txt_Nombre.PressKeys("Conductor");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionadosInfo, new RecordItemIndex(20));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txtbox_Apellido' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ApellidoInfo, new RecordItemIndex(21));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Apellido.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Uber' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Apellido'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ApellidoInfo, new RecordItemIndex(22));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Apellido.PressKeys("Uber");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionadosInfo, new RecordItemIndex(23));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDeLosLesionados.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar' at 22;3.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AceptarInfo, new RecordItemIndex(24));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar.Click("22;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAsegurado'", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo, new ActionTimeout(30000), new RecordItemIndex(25));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo.WaitForExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(26));
            
            // Elementos básicos del vehículo
            Report.Log(ReportLevel.Info, "Section", "Elementos básicos del vehículo", new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculoInfo, new RecordItemIndex(28));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculo.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculo'.", repo.SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculoInfo, new RecordItemIndex(29));
            //repo.SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AnioAutoAsegurado' with focus on 'SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculo'.", repo.SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculoInfo, new RecordItemIndex(30));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculo.PressKeys(AnioAutoAsegurado);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculo'.", repo.SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculoInfo, new RecordItemIndex(31));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_AnioVehiculo.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'Copy_of_txtAnioVehiculo'", repo.Copy_of_txtAnioVehiculoInfo, new ActionTimeout(30000), new RecordItemIndex(32));
            repo.Copy_of_txtAnioVehiculoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txt_Marca' at Center.", repo.SuraClaims.Motor.txt_MarcaInfo, new RecordItemIndex(33));
            repo.SuraClaims.Motor.txt_Marca.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.Motor.txt_Marca'.", repo.SuraClaims.Motor.txt_MarcaInfo, new RecordItemIndex(34));
            //repo.SuraClaims.Motor.txt_Marca.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$MarcaAutoAsegurado' with focus on 'SuraClaims.Motor.txt_Marca'.", repo.SuraClaims.Motor.txt_MarcaInfo, new RecordItemIndex(35));
            repo.SuraClaims.Motor.txt_Marca.PressKeys(MarcaAutoAsegurado);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.Motor.txt_Marca'.", repo.SuraClaims.Motor.txt_MarcaInfo, new RecordItemIndex(36));
            repo.SuraClaims.Motor.txt_Marca.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.Copy_of_txtmarca'", repo.SuraClaims.Motor.Copy_of_txtmarcaInfo, new ActionTimeout(30000), new RecordItemIndex(37));
            repo.SuraClaims.Motor.Copy_of_txtmarcaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txt_Modelo' at Center.", repo.SuraClaims.Motor.txt_ModeloInfo, new RecordItemIndex(38));
            repo.SuraClaims.Motor.txt_Modelo.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.Motor.txt_Modelo'.", repo.SuraClaims.Motor.txt_ModeloInfo, new RecordItemIndex(39));
            //repo.SuraClaims.Motor.txt_Modelo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ModeloAutoAsegurado' with focus on 'SuraClaims.Motor.txt_Modelo'.", repo.SuraClaims.Motor.txt_ModeloInfo, new RecordItemIndex(40));
            repo.SuraClaims.Motor.txt_Modelo.PressKeys(ModeloAutoAsegurado);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.Motor.txt_Modelo'.", repo.SuraClaims.Motor.txt_ModeloInfo, new RecordItemIndex(41));
            repo.SuraClaims.Motor.txt_Modelo.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.Copy_of_txt_Modelo'", repo.SuraClaims.Motor.Copy_of_txt_ModeloInfo, new ActionTimeout(30000), new RecordItemIndex(42));
            repo.SuraClaims.Motor.Copy_of_txt_ModeloInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculo' at Center.", repo.SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculoInfo, new RecordItemIndex(43));
            repo.SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculo.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculo'.", repo.SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculoInfo, new RecordItemIndex(44));
            //repo.SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoAutoAsegurado' with focus on 'SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculo'.", repo.SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculoInfo, new RecordItemIndex(45));
            repo.SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculo.PressKeys(TipoAutoAsegurado);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculo'.", repo.SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculoInfo, new RecordItemIndex(46));
            repo.SuraClaims.Motor.SiniestroTercero.txt_TipoVehiculo.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.SiniestroTercero.Copy_of_txtTipoVehiculo'", repo.SuraClaims.Motor.SiniestroTercero.Copy_of_txtTipoVehiculoInfo, new ActionTimeout(30000), new RecordItemIndex(47));
            repo.SuraClaims.Motor.SiniestroTercero.Copy_of_txtTipoVehiculoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(48));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.Aceptar' at Center.", repo.SuraClaims.Motor.AceptarInfo, new RecordItemIndex(49));
            repo.SuraClaims.Motor.Aceptar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(50));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
