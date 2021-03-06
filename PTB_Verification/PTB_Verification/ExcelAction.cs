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
using static PTB_Verification.PTB_VerificationRepositoryFolders;


namespace PTB_Verification
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ExcelAction recording.
    /// </summary>
    [TestModule("9489782e-26f0-457e-a1ec-ae4ff3aec1b3", ModuleType.Recording, 1)]
    public partial class ExcelAction : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PTB_VerificationRepository repository.
        /// </summary>
        public static PTB_VerificationRepository repo = PTB_VerificationRepository.Instance;

        static ExcelAction instance = new ExcelAction();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ExcelAction()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ExcelAction Instance
        {
            get { return instance; }
        }

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
            Mouse.DefaultMoveTime = 800;
            Keyboard.DefaultKeyPressTime = 300;
            Delay.SpeedFactor = 2.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automation_MX\\Automation_PTB\\Reports\\PTB_results.xls' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automation_MX\\Automation_PTB\\Reports\\PTB_results.xls", "", "D:\\Dobri\\Reports", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'ExcelPTBResultsTable'.", repo.ExcelPTBResultsTable.SelfInfo, new RecordItemIndex(1));
            repo.ExcelPTBResultsTable.Self.Maximize();
            Delay.Milliseconds(0);
            
            // Click "Alt"
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"Alt\"\r\nKey sequence '{LMenu}'.", new RecordItemIndex(2));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            // Click "H"
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"H\"\r\nKey sequence 'h'.", new RecordItemIndex(3));
            Keyboard.Press("h");
            Delay.Milliseconds(0);
            
            // Click "O"
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"O\"\r\nKey sequence 'o'.", new RecordItemIndex(4));
            Keyboard.Press("o");
            Delay.Milliseconds(0);
            
            // Click "M"
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"M\"\r\nKey sequence 'm'.", new RecordItemIndex(5));
            Keyboard.Press("m");
            Delay.Milliseconds(0);
            
            // Click "Down Arrow" and hold it
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"Down Arrow\" and hold it\r\nKey sequence '{Down 81}'.", new RecordItemIndex(6));
            Keyboard.Press("{Down 81}");
            Delay.Milliseconds(0);
            
            // Click "Alt+C" together
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"Alt+C\" together\r\nKey 'Alt+C' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.Alt, 46, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            // Click "Enter"
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"Enter\"\r\nKey sequence '{Return}'.", new RecordItemIndex(8));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);


            Report.Log(ReportLevel.Info, "Keyboard", "Click \"Alt\"\r\nKey sequence '{LMenu}'.", new RecordItemIndex(2));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);

            // Click "H"
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"H\"\r\nKey sequence 'h'.", new RecordItemIndex(3));
            Keyboard.Press("h");
            Delay.Milliseconds(0);

            // Click "O"
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"O\"\r\nKey sequence 'o'.", new RecordItemIndex(4));
            Keyboard.Press("o");
            Delay.Milliseconds(0);

            // Click "R"
            Report.Log(ReportLevel.Info, "Keyboard", "Click \"R\"\r\nKey sequence 'r'.", new RecordItemIndex(5));
            Keyboard.Press("r");
            Delay.Milliseconds(0);


            Keyboard.Press(MXAction.versionMXglobal);  //Hardcoded Example: Keyboard.Press("5.2.114"); //With Variable example: Keyboard.Press(MXAction.versionMXglobal); 
            Delay.Milliseconds(0);

            // Click "Enter"            
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Keyboard", "Click \"Alt\"\r\nKey sequence '{LMenu}'.", new RecordItemIndex(2));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
                        
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(10));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(11));
            Keyboard.Press("o");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ExcelPTBResultsTable.FileNameFieldForResults_txt' at Center.", repo.ExcelPTBResultsTable.FileNameFieldForResults_txtInfo, new RecordItemIndex(12));
            repo.ExcelPTBResultsTable.FileNameFieldForResults_txt.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(13));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automation_MX\\Automation_PTB\\Reports\\results.txt'.", new RecordItemIndex(14));
            Keyboard.Press("D:\\Joro\\GIT_Automation_MX\\Automation_PTB\\Reports\\results.txt");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(15));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelPTBResultsTable.Next' at Center.", repo.ExcelPTBResultsTable.NextInfo, new RecordItemIndex(16));
            repo.ExcelPTBResultsTable.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelPTBResultsTable.Next' at Center.", repo.ExcelPTBResultsTable.NextInfo, new RecordItemIndex(17));
            repo.ExcelPTBResultsTable.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelPTBResultsTable.Finish' at Center.", repo.ExcelPTBResultsTable.FinishInfo, new RecordItemIndex(18));
            repo.ExcelPTBResultsTable.Finish.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelPTBResultsTable.Results.CellB3' at 34;11.", repo.ExcelPTBResultsTable.Results.CellB3Info, new RecordItemIndex(19));
            repo.ExcelPTBResultsTable.Results.CellB3.Click("34;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -8160 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(-8160);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}'.", new RecordItemIndex(21));
            Keyboard.Press("{LShiftKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelPTBResultsTable.Results.D217' at 28;11.", repo.ExcelPTBResultsTable.Results.D217Info, new RecordItemIndex(22));
            repo.ExcelPTBResultsTable.Results.D217.Click("28;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey up}'.", new RecordItemIndex(23));
            Keyboard.Press("{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}'.", new RecordItemIndex(24));
            Keyboard.Press("{LControlKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Ckey}{LControlKey up}'.", new RecordItemIndex(25));
            Keyboard.Press("{Ckey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+Tab' Press with focus on 'ExcelPTBResultsTable.Results.Row3'.", repo.ExcelPTBResultsTable.Results.Row3Info, new RecordItemIndex(26));
            Keyboard.PrepareFocus(repo.ExcelPTBResultsTable.Results.Row3);
            Keyboard.Press(System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.Control, 15, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);

            //Bellow you can see ......

            string strB4 = ".//table[@name='" + MXAction.versionMXglobal + "']/row[@index='4']/cell[@address='B4']";
            ExcelPTBResultsTableAppFolder._cellb4Info = new RepoItemInfo(repo.ExcelPTBResultsTable, "CellB4", strB4, 30000, null, "3d3f27aa-5aeb-422f-926b-e037164b164e");
            //_cellb4Info = new RepoItemInfo(this, "CellB4", ".//table[@name='5.2.112 (2)']/row[@index='4']/cell[@address='B4']", 30000, null, "3d3f27aa-5aeb-422f-926b-e037164b164e");

            string strD218 = ".//table[@name='" + MXAction.versionMXglobal + "']/row[@index='218']/cell[@address='D218']";
            //_d218Info = new RepoItemInfo(this, "D218", ".//table[@name='5.2.112 (2)']/row[@index='218']/cell[@address='D218']", 30000, null, "c06a7e2e-8a6f-4430-87ec-47d8ffd01851");
            ExcelPTBResultsTableAppFolder._d218Info = new RepoItemInfo(repo.ExcelPTBResultsTable, "D218", strD218, 30000, null, "c06a7e2e-8a6f-4430-87ec-47d8ffd01851");

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelPTBResultsTable.CellB4' at 37;9.", repo.ExcelPTBResultsTable.CellB4Info, new RecordItemIndex(27));
            repo.ExcelPTBResultsTable.CellB4.Click("37;9");
            Delay.Milliseconds(200);

            //string cellB4 = repo.ExcelPTBResultsTable.CellB4Info.Path.ToString();

            //int iposition = cellB4.IndexOf("name");

            //string strBegin = cellB4.Substring(0, iposition + 6);

            //string VersionPlusAllTillTheEnd = cellB4.Substring(iposition + 6); //thisi is a substring command with only one parameter. This operation will take all values till the end from iposition+6. (iposition + 6 is name=' )

            //int ipositionOfApostrophe = VersionPlusAllTillTheEnd.IndexOf("'");

            //string versionName = VersionPlusAllTillTheEnd.Substring(0, ipositionOfApostrophe);

            //string strApostropheToEnd = VersionPlusAllTillTheEnd.Substring(ipositionOfApostrophe); //thisi is a substring command with only one parameter. This operation will take all values till the end with start point apostrophe

            //string strNewVer = "2.0.33.beta5";

            //string strNewStr = strBegin + strNewVer + strApostropheToEnd; // We need to replace the path on the B4 and D218 with this string

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -7920 units.", new RecordItemIndex(28));
            Mouse.ScrollWheel(-7920);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}'.", new RecordItemIndex(29));
            Keyboard.Press("{LShiftKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelPTBResultsTable.D218' at 32;8.", repo.ExcelPTBResultsTable.D218Info, new RecordItemIndex(30));
            repo.ExcelPTBResultsTable.D218.Click("32;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey up}'.", new RecordItemIndex(31));
            Keyboard.Press("{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Vkey}{LControlKey up}'.", new RecordItemIndex(32));
            Keyboard.Press("{LControlKey down}{Vkey}{LControlKey up}");
            Delay.Milliseconds(200);

            
            ExcelPTBResultsTableAppFolder._cellm4Info = new RepoItemInfo(repo.ExcelPTBResultsTable, "CellM4", ".//table[@name='" + MXAction.versionMXglobal + "']/row[@index='4']/cell[@address='M4']", 30000, null);


        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
