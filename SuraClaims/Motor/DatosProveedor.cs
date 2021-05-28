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
    ///The DatosProveedor recording.
    /// </summary>
    [TestModule("d693d3b8-e744-4f49-a1c0-42ab7648eaf3", ModuleType.Recording, 1)]
    public partial class DatosProveedor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static DatosProveedor instance = new DatosProveedor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DatosProveedor()
        {
            CodProveedor = "23766";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DatosProveedor Instance
        {
            get { return instance; }
        }

#region Variables

        string _CodProveedor;

        /// <summary>
        /// Gets or sets the value of variable CodProveedor.
        /// </summary>
        [TestVariable("c5447b31-d851-48cb-bd1f-9354441c492a")]
        public string CodProveedor
        {
            get { return _CodProveedor; }
            set { _CodProveedor = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.Arrow_BuscaProveedor' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.Arrow_BuscaProveedorInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.InformacionSiniestro.Arrow_BuscaProveedor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.BuscarProveedor' at Center.", repo.SuraClaims.Motor.BuscarProveedorInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.BuscarProveedor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SuraClaims.Motor.txt_BuscarProveedor'", repo.SuraClaims.Motor.txt_BuscarProveedorInfo, new ActionTimeout(20000), new RecordItemIndex(2));
            repo.SuraClaims.Motor.txt_BuscarProveedorInfo.WaitForExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.picker_Provincia' at Center.", repo.SuraClaims.Motor.picker_ProvinciaInfo, new RecordItemIndex(3));
            repo.SuraClaims.Motor.picker_Provincia.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.SelectProvinciaNinguna' at Center.", repo.SuraClaims.Motor.InformacionBasica.SelectProvinciaNingunaInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.InformacionBasica.SelectProvinciaNinguna.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txt_BuscarProveedor' at Center.", repo.SuraClaims.Motor.txt_BuscarProveedorInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.txt_BuscarProveedor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to not exist. Associated repository item: 'SuraClaims.Motor.Copy_of_input_Provincia'", repo.SuraClaims.Motor.Copy_of_input_ProvinciaInfo, new ActionTimeout(20000), new RecordItemIndex(6));
            repo.SuraClaims.Motor.Copy_of_input_ProvinciaInfo.WaitForNotExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.MenuLateral.input_Proveedor' at Center.", repo.SuraClaims.Generales.MenuLateral.input_ProveedorInfo, new RecordItemIndex(7));
            repo.SuraClaims.Generales.MenuLateral.input_Proveedor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CodProveedor' with focus on 'SuraClaims.Generales.MenuLateral.input_Proveedor'.", repo.SuraClaims.Generales.MenuLateral.input_ProveedorInfo, new RecordItemIndex(8));
            repo.SuraClaims.Generales.MenuLateral.input_Proveedor.PressKeys(CodProveedor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.Btn_BuscarProveedor' at Center.", repo.SuraClaims.Motor.Btn_BuscarProveedorInfo, new RecordItemIndex(9));
            repo.SuraClaims.Motor.Btn_BuscarProveedor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(10));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.Seleccionar' at Center.", repo.SuraClaims.Motor.SeleccionarInfo, new RecordItemIndex(11));
            repo.SuraClaims.Motor.Seleccionar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAsegurado'", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo, new ActionTimeout(10000), new RecordItemIndex(12));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo.WaitForExists(10000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(13));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
