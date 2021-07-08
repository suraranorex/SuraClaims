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

namespace SuraClaims.Administracion
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerificarEstado_ColaMensajes recording.
    /// </summary>
    [TestModule("057bbe76-7118-471d-b26e-9ef3c771d4c6", ModuleType.Recording, 1)]
    public partial class VerificarEstado_ColaMensajes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static VerificarEstado_ColaMensajes instance = new VerificarEstado_ColaMensajes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerificarEstado_ColaMensajes()
        {
            hayProcesosSuspendidos = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerificarEstado_ColaMensajes Instance
        {
            get { return instance; }
        }

#region Variables

        string _hayProcesosSuspendidos;

        /// <summary>
        /// Gets or sets the value of variable hayProcesosSuspendidos.
        /// </summary>
        [TestVariable("0e2c12ab-c4b4-4b49-b8fb-22dc0adb60e2")]
        public string hayProcesosSuspendidos
        {
            get { return _hayProcesosSuspendidos; }
            set { _hayProcesosSuspendidos = value; }
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

            haySuspendidos();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
