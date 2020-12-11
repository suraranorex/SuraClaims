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
    ///The DescripTipoSiniestro_Tercero recording.
    /// </summary>
    [TestModule("61e4dcef-1aae-4a13-840b-3898125ec2e1", ModuleType.Recording, 1)]
    public partial class DescripTipoSiniestro_Tercero : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraClaimsRepository repository.
        /// </summary>
        public static SuraClaimsRepository repo = SuraClaimsRepository.Instance;

        static DescripTipoSiniestro_Tercero instance = new DescripTipoSiniestro_Tercero();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DescripTipoSiniestro_Tercero()
        {
            TipoAccidente = "Colisión";
            TipoColision = "Vehículo";
            DanioTercero = "Frontal";
            DescripcionDanios = "Choque Frontal";
            CantPasaj = "1";
            Dolencia = "No";
            CantAsegu = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DescripTipoSiniestro_Tercero Instance
        {
            get { return instance; }
        }

#region Variables

        string _DescripcionDanios;

        /// <summary>
        /// Gets or sets the value of variable DescripcionDanios.
        /// </summary>
        [TestVariable("e9963c27-334f-489a-8169-3eb341beceaa")]
        public string DescripcionDanios
        {
            get { return _DescripcionDanios; }
            set { _DescripcionDanios = value; }
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

        /// <summary>
        /// Gets or sets the value of variable TipoAccidente.
        /// </summary>
        [TestVariable("a1f3e695-bff6-4f81-8ea8-9af16e84c8bb")]
        public string TipoAccidente
        {
            get { return repo.TipoAccidente; }
            set { repo.TipoAccidente = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoColision.
        /// </summary>
        [TestVariable("818e442a-84c8-4b4a-9ca1-923462714ab4")]
        public string TipoColision
        {
            get { return repo.TipoColision; }
            set { repo.TipoColision = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DanioTercero.
        /// </summary>
        [TestVariable("2ba93c69-e8e8-41c3-95eb-44a7b419c612")]
        public string DanioTercero
        {
            get { return repo.DanioTercero; }
            set { repo.DanioTercero = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Dolencia.
        /// </summary>
        [TestVariable("53daebca-d8bf-414f-b96a-871e390bb227")]
        public string Dolencia
        {
            get { return repo.Dolencia; }
            set { repo.Dolencia = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CantPasaj.
        /// </summary>
        [TestVariable("e2bf9d33-36d2-4fd9-a145-278adbc85d1a")]
        public string CantPasaj
        {
            get { return repo.CantPasaj; }
            set { repo.CantPasaj = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CantAsegu.
        /// </summary>
        [TestVariable("0f588447-09db-4a8a-84db-fdd707cbd88e")]
        public string CantAsegu
        {
            get { return repo.CantAsegu; }
            set { repo.CantAsegu = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.pestana_DescripTipoSiniestro' at 119;6.", repo.SuraClaims.Motor.pestana_DescripTipoSiniestroInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.pestana_DescripTipoSiniestro.Click("119;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidente' at 66;6.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidenteInfo, new RecordItemIndex(1));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidente.DoubleClick("66;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoAccidente' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidente'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidenteInfo, new RecordItemIndex(2));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidente.PressKeys(TipoAccidente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.Copy_of_SelectTipoAccidente' at 33;8.", repo.SuraClaims.SiniestroTercero.Copy_of_SelectTipoAccidenteInfo, new RecordItemIndex(3));
            repo.SuraClaims.SiniestroTercero.Copy_of_SelectTipoAccidente.Click("33;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_ColisionCon' at 31;12.", repo.SuraClaims.SiniestroTercero.txt_ColisionConInfo, new RecordItemIndex(5));
            repo.SuraClaims.SiniestroTercero.txt_ColisionCon.DoubleClick("31;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoColision' with focus on 'SuraClaims.SiniestroTercero.txt_ColisionCon'.", repo.SuraClaims.SiniestroTercero.txt_ColisionConInfo, new RecordItemIndex(6));
            repo.SuraClaims.SiniestroTercero.txt_ColisionCon.PressKeys(TipoColision);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectTipoColision' at 29;5.", repo.SuraClaims.SiniestroTercero.SelectTipoColisionInfo, new RecordItemIndex(7));
            repo.SuraClaims.SiniestroTercero.SelectTipoColision.Click("29;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_DanioATercero' at 56;11.", repo.SuraClaims.SiniestroTercero.txt_DanioATerceroInfo, new RecordItemIndex(8));
            repo.SuraClaims.SiniestroTercero.txt_DanioATercero.DoubleClick("56;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DanioTercero' with focus on 'SuraClaims.SiniestroTercero.txt_DanioATercero'.", repo.SuraClaims.SiniestroTercero.txt_DanioATerceroInfo, new RecordItemIndex(9));
            repo.SuraClaims.SiniestroTercero.txt_DanioATercero.PressKeys(DanioTercero);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectDanioTerceroFrontal' at 34;12.", repo.SuraClaims.SiniestroTercero.SelectDanioTerceroFrontalInfo, new RecordItemIndex(10));
            repo.SuraClaims.SiniestroTercero.SelectDanioTerceroFrontal.Click("34;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_Dolencias' at 93;12.", repo.SuraClaims.SiniestroTercero.txt_DolenciasInfo, new RecordItemIndex(11));
            repo.SuraClaims.SiniestroTercero.txt_Dolencias.DoubleClick("93;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dolencia' with focus on 'SuraClaims.SiniestroTercero.txt_Dolencias'.", repo.SuraClaims.SiniestroTercero.txt_DolenciasInfo, new RecordItemIndex(12));
            repo.SuraClaims.SiniestroTercero.txt_Dolencias.PressKeys(Dolencia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectDolencia' at 26;11.", repo.SuraClaims.SiniestroTercero.SelectDolenciaInfo, new RecordItemIndex(13));
            repo.SuraClaims.SiniestroTercero.SelectDolencia.Click("26;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_CantPasaj' at 55;9.", repo.SuraClaims.SiniestroTercero.txt_CantPasajInfo, new RecordItemIndex(14));
            repo.SuraClaims.SiniestroTercero.txt_CantPasaj.DoubleClick("55;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CantPasaj' with focus on 'SuraClaims.SiniestroTercero.txt_CantPasaj'.", repo.SuraClaims.SiniestroTercero.txt_CantPasajInfo, new RecordItemIndex(15));
            repo.SuraClaims.SiniestroTercero.txt_CantPasaj.PressKeys(CantPasaj);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectCantPasaj' at 16;6.", repo.SuraClaims.SiniestroTercero.SelectCantPasajInfo, new RecordItemIndex(16));
            repo.SuraClaims.SiniestroTercero.SelectCantPasaj.Click("16;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_CantAseg' at 46;2.", repo.SuraClaims.SiniestroTercero.txt_CantAsegInfo, new RecordItemIndex(17));
            repo.SuraClaims.SiniestroTercero.txt_CantAseg.DoubleClick("46;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CantAsegu' with focus on 'SuraClaims.SiniestroTercero.txt_CantAseg'.", repo.SuraClaims.SiniestroTercero.txt_CantAsegInfo, new RecordItemIndex(18));
            repo.SuraClaims.SiniestroTercero.txt_CantAseg.PressKeys(CantAsegu);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectCantAseg' at 25;12.", repo.SuraClaims.SiniestroTercero.SelectCantAsegInfo, new RecordItemIndex(19));
            repo.SuraClaims.SiniestroTercero.SelectCantAseg.Click("25;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.txt_DescripDaniosTercero' at Center.", repo.SuraClaims.SiniestroTercero.txt_DescripDaniosTerceroInfo, new RecordItemIndex(20));
            repo.SuraClaims.SiniestroTercero.txt_DescripDaniosTercero.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescripcionDanios' with focus on 'SuraClaims.SiniestroTercero.txt_DescripDaniosTercero'.", repo.SuraClaims.SiniestroTercero.txt_DescripDaniosTerceroInfo, new RecordItemIndex(21));
            repo.SuraClaims.SiniestroTercero.txt_DescripDaniosTercero.PressKeys(DescripcionDanios);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_Aceptar' at 25;5.", repo.SuraClaims.Motor.btn_AceptarInfo, new RecordItemIndex(22));
            repo.SuraClaims.Motor.btn_Aceptar.Click("25;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(23));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}