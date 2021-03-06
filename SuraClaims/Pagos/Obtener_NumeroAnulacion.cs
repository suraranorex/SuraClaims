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
    ///The Obtener_NumeroAnulacion recording.
    /// </summary>
    [TestModule("4e02bff7-a18b-488d-871b-2025c36a43a6", ModuleType.Recording, 1)]
    public partial class Obtener_NumeroAnulacion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static Obtener_NumeroAnulacion instance = new Obtener_NumeroAnulacion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Obtener_NumeroAnulacion()
        {
            NumeroAnulacion = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Obtener_NumeroAnulacion Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumeroAnulacion;

        /// <summary>
        /// Gets or sets the value of variable NumeroAnulacion.
        /// </summary>
        [TestVariable("5f04b518-ac75-4e43-a0f5-9a51b8a85893")]
        public string NumeroAnulacion
        {
            get { return _NumeroAnulacion; }
            set { _NumeroAnulacion = value; }
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

            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.AnulacionPago.txt_NumeroAnulacion' and assigning its value to variable 'NumeroAnulacion'.", repo.SuraClaims.AnulacionPago.txt_NumeroAnulacionInfo, new RecordItemIndex(1));
            NumeroAnulacion = repo.SuraClaims.AnulacionPago.txt_NumeroAnulacion.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "El número de anulación es", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "User", NumeroAnulacion, new RecordItemIndex(3));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
