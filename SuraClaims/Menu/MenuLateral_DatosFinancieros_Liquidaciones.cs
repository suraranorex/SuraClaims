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

namespace SuraClaims.Menu
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MenuLateral_DatosFinancieros_Liquidaciones recording.
    /// </summary>
    [TestModule("86bc9978-cbae-46a7-998f-4beecc068775", ModuleType.Recording, 1)]
    public partial class MenuLateral_DatosFinancieros_Liquidaciones : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static MenuLateral_DatosFinancieros_Liquidaciones instance = new MenuLateral_DatosFinancieros_Liquidaciones();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MenuLateral_DatosFinancieros_Liquidaciones()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MenuLateral_DatosFinancieros_Liquidaciones Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.MenuLateral.menu_DatosFinancieros' at Center.", repo.SuraClaims.Generales.MenuLateral.menu_DatosFinancierosInfo, new RecordItemIndex(0));
            repo.SuraClaims.Generales.MenuLateral.menu_DatosFinancieros.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_DatosFinancierosTotal'", repo.SuraClaims.Txt_Validaciones.txt_DatosFinancierosTotalInfo, new ActionTimeout(20000), new RecordItemIndex(1));
            repo.SuraClaims.Txt_Validaciones.txt_DatosFinancierosTotalInfo.WaitForExists(20000);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            //Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.MenuLateral.submenuLateral_LiquiOrdenDePago' at Center.", repo.SuraClaims.Generales.MenuLateral.submenuLateral_LiquiOrdenDePagoInfo, new RecordItemIndex(3));
            repo.SuraClaims.Generales.MenuLateral.submenuLateral_LiquiOrdenDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_LiquidacionesOrdenPago'", repo.SuraClaims.Txt_Validaciones.txt_LiquidacionesOrdenPagoInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            repo.SuraClaims.Txt_Validaciones.txt_LiquidacionesOrdenPagoInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
