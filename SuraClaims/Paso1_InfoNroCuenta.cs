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
    ///The Paso1_InfoNroCuenta recording.
    /// </summary>
    [TestModule("f1d6a770-4a97-4d02-80f0-bc61a442330d", ModuleType.Recording, 1)]
    public partial class Paso1_InfoNroCuenta : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static Paso1_InfoNroCuenta instance = new Paso1_InfoNroCuenta();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Paso1_InfoNroCuenta()
        {
            Banco = "GALICIA";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Paso1_InfoNroCuenta Instance
        {
            get { return instance; }
        }

#region Variables

        string _Banco;

        /// <summary>
        /// Gets or sets the value of variable Banco.
        /// </summary>
        [TestVariable("639d2980-c0b5-4a42-849e-a963b3214514")]
        public string Banco
        {
            get { return _Banco; }
            set { _Banco = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SuraClaims.InformacionPagoSiniestro.lbl_SeleccionarCuenta'.", repo.SuraClaims.InformacionPagoSiniestro.lbl_SeleccionarCuentaInfo, new RecordItemIndex(0));
            Validate.Exists(repo.SuraClaims.InformacionPagoSiniestro.lbl_SeleccionarCuentaInfo);
            Delay.Milliseconds(0);
            
            // Error: No tiene CBU cargado.
            //Report.Log(ReportLevel.Info, "User", "", new RecordItemIndex(1));
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoOblig'.", repo.SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoObligInfo, new RecordItemIndex(2));
            //Validate.Exists(repo.SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoObligInfo);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.txt_BancoEmisorSugerido' at Center.", repo.SuraClaims.InformacionPagoSiniestro.txt_BancoEmisorSugeridoInfo, new RecordItemIndex(3));
            repo.SuraClaims.InformacionPagoSiniestro.txt_BancoEmisorSugerido.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.option_NombreMayusculas' at Center.", repo.SuraClaims.InformacionPagoSiniestro.option_NombreMayusculasInfo, new RecordItemIndex(4));
            repo.SuraClaims.InformacionPagoSiniestro.option_NombreMayusculas.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.InformacionPagoSiniestro.Copy_of_OptionSelecBancoEmisor'", repo.SuraClaims.InformacionPagoSiniestro.Copy_of_OptionSelecBancoEmisorInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SuraClaims.InformacionPagoSiniestro.Copy_of_OptionSelecBancoEmisorInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_MetodoDePago' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_MetodoDePagoInfo, new RecordItemIndex(6));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_MetodoDePago.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoOblig' at Center.", repo.SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoObligInfo, new RecordItemIndex(7));
            //repo.SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoOblig.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.InformacionPagoSiniestro.lbl_Banco' and assigning the part of its value captured by '[A-Z.]+' to variable 'Banco'.", repo.SuraClaims.InformacionPagoSiniestro.lbl_BancoInfo, new RecordItemIndex(8));
            Banco = repo.SuraClaims.InformacionPagoSiniestro.lbl_Banco.Element.GetAttributeValueText("InnerText", new Regex("[A-Z.]+"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoOblig' at Center.", repo.SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoObligInfo, new RecordItemIndex(9));
            repo.SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoOblig.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Banco' with focus on 'SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoOblig'.", repo.SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoObligInfo, new RecordItemIndex(10));
            repo.SuraClaims.InformacionPagoSiniestro.txt_SeleccionarCuenta_CampoOblig.PressKeys(Banco);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.InformacionPagoSiniestro.Copy_of_txt_SeleccionarCuenta_CampoOblig'", repo.SuraClaims.InformacionPagoSiniestro.Copy_of_txt_SeleccionarCuenta_CampoObligInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.SuraClaims.InformacionPagoSiniestro.Copy_of_txt_SeleccionarCuenta_CampoObligInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.ArrowSelectCuenta' at CenterRight.", repo.SuraClaims.InformacionPagoSiniestro.ArrowSelectCuentaInfo, new RecordItemIndex(12));
            //repo.SuraClaims.InformacionPagoSiniestro.ArrowSelectCuenta.Click(Location.CenterRight);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SuraClaims.InformacionPagoSiniestro.OptionSelectCuenta' at Center.", repo.SuraClaims.InformacionPagoSiniestro.OptionSelectCuentaInfo, new RecordItemIndex(13));
            //repo.SuraClaims.InformacionPagoSiniestro.OptionSelectCuenta.MoveTo();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.OptionSelectCuenta' at Center.", repo.SuraClaims.InformacionPagoSiniestro.OptionSelectCuentaInfo, new RecordItemIndex(14));
            //repo.SuraClaims.InformacionPagoSiniestro.OptionSelectCuenta.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.InformacionPagoSiniestro.Copy_of_OptionSelectCuenta'", repo.SuraClaims.InformacionPagoSiniestro.Copy_of_OptionSelectCuentaInfo, new ActionTimeout(30000), new RecordItemIndex(15));
            //repo.SuraClaims.InformacionPagoSiniestro.Copy_of_OptionSelectCuentaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_MetodoDePago' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_MetodoDePagoInfo, new RecordItemIndex(16));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_MetodoDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(17));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
