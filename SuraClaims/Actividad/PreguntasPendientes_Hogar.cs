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

namespace SuraClaims.Actividad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PreguntasPendientes_Hogar recording.
    /// </summary>
    [TestModule("3f519212-8653-495e-b635-cec9f8ae22b6", ModuleType.Recording, 1)]
    public partial class PreguntasPendientes_Hogar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SuraClaims.SuraClaimsRepository repository.
        /// </summary>
        public static global::SuraClaims.SuraClaimsRepository repo = global::SuraClaims.SuraClaimsRepository.Instance;

        static PreguntasPendientes_Hogar instance = new PreguntasPendientes_Hogar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PreguntasPendientes_Hogar()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PreguntasPendientes_Hogar Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Actividad.Preguntas.pregunta_PoseeAntecedentes' at Center.", repo.SuraClaims.Actividad.Preguntas.pregunta_PoseeAntecedentesInfo, new RecordItemIndex(0));
            repo.SuraClaims.Actividad.Preguntas.pregunta_PoseeAntecedentes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Actividad.option_No' at Center.", repo.SuraClaims.Actividad.option_NoInfo, new RecordItemIndex(1));
            repo.SuraClaims.Actividad.option_No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Actividad.Preguntas.pregunta_ModificacionesPoliza' at Center.", repo.SuraClaims.Actividad.Preguntas.pregunta_ModificacionesPolizaInfo, new RecordItemIndex(2));
            repo.SuraClaims.Actividad.Preguntas.pregunta_ModificacionesPoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Actividad.option_No' at Center.", repo.SuraClaims.Actividad.option_NoInfo, new RecordItemIndex(3));
            repo.SuraClaims.Actividad.option_No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Actividad.Preguntas.pregunta_ModificacionRelato' at Center.", repo.SuraClaims.Actividad.Preguntas.pregunta_ModificacionRelatoInfo, new RecordItemIndex(4));
            repo.SuraClaims.Actividad.Preguntas.pregunta_ModificacionRelato.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Actividad.option_No' at Center.", repo.SuraClaims.Actividad.option_NoInfo, new RecordItemIndex(5));
            repo.SuraClaims.Actividad.option_No.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
