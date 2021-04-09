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
    ///The ObtenerUsuarioParaAprobarPago recording.
    /// </summary>
    [TestModule("f28111a3-40ee-4213-a5d3-c2409dc5b5ca", ModuleType.Recording, 1)]
    public partial class ObtenerUsuarioParaAprobarPago : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static ObtenerUsuarioParaAprobarPago instance = new ObtenerUsuarioParaAprobarPago();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ObtenerUsuarioParaAprobarPago()
        {
            NombreAprobadorPago = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ObtenerUsuarioParaAprobarPago Instance
        {
            get { return instance; }
        }

#region Variables

        string _NombreAprobadorPago;

        /// <summary>
        /// Gets or sets the value of variable NombreAprobadorPago.
        /// </summary>
        [TestVariable("b3b80e17-9472-4fa4-9ad6-9aea40ad62be")]
        public string NombreAprobadorPago
        {
            get { return _NombreAprobadorPago; }
            set { _NombreAprobadorPago = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.MenuLateral.menu_PlanDeTrabajo' at Center.", repo.SuraClaims.Generales.MenuLateral.menu_PlanDeTrabajoInfo, new RecordItemIndex(0));
            repo.SuraClaims.Generales.MenuLateral.menu_PlanDeTrabajo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Generales.MenuLateral.title_PlanDeTrabajo'", repo.SuraClaims.Generales.MenuLateral.title_PlanDeTrabajoInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SuraClaims.Generales.MenuLateral.title_PlanDeTrabajoInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.PlanDeTrabajo.txt_NombreAprobadorPago' and assigning its value to variable 'NombreAprobadorPago'.", repo.SuraClaims.PlanDeTrabajo.txt_NombreAprobadorPagoInfo, new RecordItemIndex(2));
            NombreAprobadorPago = repo.SuraClaims.PlanDeTrabajo.txt_NombreAprobadorPago.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "El usuario que debe aprobar el pago es:", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "User", NombreAprobadorPago, new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
