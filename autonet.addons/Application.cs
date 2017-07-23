﻿using System;
using System.Diagnostics;
using System.IO;
using autonet.Common.Settings;
using autonet.CustomCommands;
using autonet.Extensions;
using autonet.Forms;
using autonet.lsp;
using autonet.Settings;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Customization;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Runtime;
using Common;
using App = Autodesk.AutoCAD.ApplicationServices.Core.Application;

namespace autonet {
    public class Application : IExtensionApplication {

        public void Initialize() {
            try {
                //Load Directories!
                Paths.ConfigDirectory.EnsureCreated();
                LspLoader.Load("C2P");
                LspLoader.Load("E2P");
            } catch (System.Exception e) {
                Console.WriteLine(e);
                Debug.WriteLine(e);
                Quick.Write(" "+e);
            }

            /*string strFileName = "Z:\\AutoCAD\\C#\\autonet\\dbg.dwg";

            DocumentCollection acDocMgr = App.DocumentManager;

            if (File.Exists(strFileName)) {
                acDocMgr.Open(strFileName, false);
            } else {
                acDocMgr.MdiActiveDocument.Editor.WriteMessage("File " + strFileName + " does not exist.");
            }*/
        }

        public void Terminate() { }
    }
}