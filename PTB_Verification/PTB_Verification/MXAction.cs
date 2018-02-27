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

namespace PTB_Verification
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MXAction recording.
    /// </summary>
    [TestModule("ad9f253b-e8e2-42d2-8a6b-7de815b9dab5", ModuleType.Recording, 1)]
    public partial class MXAction : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PTB_VerificationRepository repository.
        /// </summary>
        public static PTB_VerificationRepository repo = PTB_VerificationRepository.Instance;

        static MXAction instance = new MXAction();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MXAction()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MXAction Instance
        {
            get { return instance; }
        }

        public static string versionMXglobal; // HERE WE DECLARE THIS STRING WHICH NAME IS VERSIONMXGLOBAL

        #region Variables

        #endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 500;
            Keyboard.DefaultKeyPressTime = 200;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\QVI\\MeasureX\\PTB.bat' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\QVI\\MeasureX\\PTB.bat", "", "C:\\QVI\\MeasureX", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 4m for item 'MeasureXUntitled.TitleBar' to exist.", repo.MeasureXUntitled.TitleBarInfo, new ActionTimeout(240000), new RecordItemIndex(1));
            repo.MeasureXUntitled.TitleBarInfo.WaitForExists(240000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MeasureXUntitled.TitleBar' at 691;10.", repo.MeasureXUntitled.TitleBarInfo, new RecordItemIndex(2));
            repo.MeasureXUntitled.TitleBar.Click("691;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(3));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(4));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(5));
            Keyboard.Press("o");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OpenMeasureXRoutine.FileNameField' at 216;4.", repo.OpenMeasureXRoutine.FileNameFieldInfo, new RecordItemIndex(6));
            repo.OpenMeasureXRoutine.FileNameField.DoubleClick("216;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'OpenMeasureXRoutine.FileNameField'.", repo.OpenMeasureXRoutine.FileNameFieldInfo, new RecordItemIndex(7));
            repo.OpenMeasureXRoutine.FileNameField.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automation_MX\\Automation_PTB\\Routine\\PTB_Certification.mxi'.", new RecordItemIndex(8));
            Keyboard.Press("D:\\Joro\\GIT_Automation_MX\\Automation_PTB\\Routine\\PTB_Certification.mxi"); 
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'OpenMeasureXRoutine.FileNameField'.", repo.OpenMeasureXRoutine.FileNameFieldInfo, new RecordItemIndex(9));
            repo.OpenMeasureXRoutine.FileNameField.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MeasureXUntitled.Help' at Center.", repo.MeasureXUntitled.HelpInfo, new RecordItemIndex(10));
            repo.MeasureXUntitled.Help.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MXNT.AboutMeasureX' at CenterLeft.", repo.MXNT.AboutMeasureXInfo, new RecordItemIndex(11));
            repo.MXNT.AboutMeasureX.Click(Location.CenterLeft);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AboutMeasureX.Text1928' at Center.", repo.AboutMeasureX.Text1928Info, new RecordItemIndex(12));
            repo.AboutMeasureX.Text1928.Click();
            Delay.Milliseconds(200);

            string checkVersionName = ((PTB_Verification.PTB_VerificationRepositoryFolders.AboutMeasureXAppFolder)repo.AboutMeasureX.Text1928Info.ParentFolder).Text1928.TextValue;

            int ipositionVersion = checkVersionName.IndexOf("Version");

            string strBegining = checkVersionName.Substring(0, ipositionVersion + 7);

            string nameMXToEnd = checkVersionName.Substring(ipositionVersion + 8);

            int ipositionOfSpace = nameMXToEnd.IndexOf(" ");

            string versionMX = nameMXToEnd.Substring(0, ipositionOfSpace); // Use this string in the Excel Action.cs when give a name to the Sheet 
            versionMXglobal = versionMX; // here we give a value 

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(13));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MeasureXUntitled.TitleBar' at 691;10.", repo.MeasureXUntitled.TitleBarInfo, new RecordItemIndex(2));
            repo.MeasureXUntitled.TitleBar.Click("691;10");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MeasureXRunRoutine.TitleBarWithLoadedRoutine' at 670;10.", repo.MeasureXRunRoutine.TitleBarWithLoadedRoutineInfo, new RecordItemIndex(14));
            //repo.MeasureXRunRoutine.TitleBarWithLoadedRoutine.Click("670;10");
            //Delay.Milliseconds(200); THIS WAS CREATED FROM THE BEGGINING. IT WORKS FINE. IF THE PATH OR THE ROUTINE NAME ARE CHANGE FOR SOME REASON THIS WILL CAUSE AN EXEPTION

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(15));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(16));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(17));
            Keyboard.Press("r");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MeasureXRunRoutine.RunRoutineButtonOK' at 58;10.", repo.MeasureXRunRoutine.RunRoutineButtonOKInfo, new RecordItemIndex(18));
            repo.MeasureXRunRoutine.RunRoutineButtonOK.Click("58;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Inspection.EndOfRunButtonOK' at 37;12.", repo.Inspection.EndOfRunButtonOKInfo, new RecordItemIndex(19));
            repo.Inspection.EndOfRunButtonOK.Click("37;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MeasureXUntitled.TitleBar' at 691;10.", repo.MeasureXUntitled.TitleBarInfo, new RecordItemIndex(2));
            repo.MeasureXUntitled.TitleBar.Click("691;10");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MeasureXRunRoutine.TitleBarWithLoadedRoutine' at 642;7.", repo.MeasureXRunRoutine.TitleBarWithLoadedRoutineInfo, new RecordItemIndex(20));
            //repo.MeasureXRunRoutine.TitleBarWithLoadedRoutine.Click("642;7");
            //Delay.Milliseconds(200); THIS WAS CREATED FROM THE BEGGINING. IT WORKS FINE. IF THE PATH OR THE ROUTINE NAME ARE CHANGE FOR SOME REASON THIS WILL CAUSE AN EXEPTION 

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}f'.", new RecordItemIndex(21));
            Keyboard.Press("{LMenu}f");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'n'.", new RecordItemIndex(22));
            Keyboard.Press("n");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'MeasureXUntitled'.", repo.MeasureXUntitled.SelfInfo, new RecordItemIndex(23));
            Host.Current.CloseApplication(repo.MeasureXUntitled.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SystemExit.ExitButtonOK' at 35;11.", repo.SystemExit.ExitButtonOKInfo, new RecordItemIndex(24));
            repo.SystemExit.ExitButtonOK.Click("35;11");
            Delay.Milliseconds(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
