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

namespace SuraClaims.Pagos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Paso1_InformacionBeneficiario recording.
    /// </summary>
    [TestModule("11944d3c-4963-4dc3-9749-443b34435492", ModuleType.Recording, 1)]
    public partial class Paso1_InformacionBeneficiario : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static Paso1_InformacionBeneficiario instance = new Paso1_InformacionBeneficiario();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Paso1_InformacionBeneficiario()
        {
            MetodoPagoSiniestro = "Cheque";
            NombreAsegurado = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Paso1_InformacionBeneficiario Instance
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
        /// Gets or sets the value of variable NombreAsegurado.
        /// </summary>
        [TestVariable("a7e06275-7e93-4bd9-a4b3-fbc7d39cbd9c")]
        public string NombreAsegurado
        {
            get { return repo.NombreAsegurado; }
            set { repo.NombreAsegurado = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable MetodoPagoSiniestro.
        /// </summary>
        [TestVariable("b2934580-1f2e-43e6-842c-2f7cae943313")]
        public string MetodoPagoSiniestro
        {
            get { return repo.MetodoPagoSiniestro; }
            set { repo.MetodoPagoSiniestro = value; }
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

            // Datos Beneficiario Principal
            Report.Log(ReportLevel.Info, "Section", "Datos Beneficiario Principal", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.ArrowNombre' at Center.", repo.SuraClaims.InformacionPagoSiniestro.ArrowNombreInfo, new RecordItemIndex(1));
            repo.SuraClaims.InformacionPagoSiniestro.ArrowNombre.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.InformacionPagoSiniestro.NombreAsegurado' and assigning the part of its value captured by '[A-Z]+' to variable 'NombreAsegurado'.", repo.SuraClaims.InformacionPagoSiniestro.NombreAseguradoInfo, new RecordItemIndex(2));
            NombreAsegurado = repo.SuraClaims.InformacionPagoSiniestro.NombreAsegurado.Element.GetAttributeValueText("InnerText", new Regex("[A-Z]+"));
            Delay.Milliseconds(0);
            
            // Nombre Asegurado
            Report.Log(ReportLevel.Info, "User", NombreAsegurado, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txtbox_Nombre' at Center.", repo.SuraClaims.Motor.txtbox_NombreInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.txtbox_Nombre.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NombreAsegurado' with focus on 'SuraClaims.InformacionPagoSiniestro.txt_Nombre'.", repo.SuraClaims.InformacionPagoSiniestro.txt_NombreInfo, new RecordItemIndex(5));
            repo.SuraClaims.InformacionPagoSiniestro.txt_Nombre.PressKeys(NombreAsegurado);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.lbl_Paso1_PagoSiniestro' at Center.", repo.SuraClaims.InformacionPagoSiniestro.lbl_Paso1_PagoSiniestroInfo, new RecordItemIndex(6));
            repo.SuraClaims.InformacionPagoSiniestro.lbl_Paso1_PagoSiniestro.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_Nombre'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NombreInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NombreInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.Select_NombreAsegurado' at Center.", repo.SuraClaims.Motor.InformacionBasica.Select_NombreAseguradoInfo, new RecordItemIndex(8));
            //repo.SuraClaims.Motor.InformacionBasica.Select_NombreAsegurado.Click();
            //Delay.Milliseconds(0);
            
            // Método de Pago
            Report.Log(ReportLevel.Info, "Section", "Método de Pago", new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestro' at Center.", repo.SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestroInfo, new RecordItemIndex(10));
            repo.SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestro.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_Nombre'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NombreInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NombreInfo.WaitForNotExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
