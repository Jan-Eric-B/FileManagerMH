﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace FileManager.Services
{
    internal static class StartProcess
    {
        public static bool Start(string path, bool useShellExecute)
        {
            try
            {
                Process process = new()
                {
                    StartInfo = new ProcessStartInfo(path) { UseShellExecute = useShellExecute },
                };
                process.Start();
                return true;
            }
            catch (System.ComponentModel.Win32Exception)
            {
                ShowOpenWithDialog(path);
                return true;
            }
            catch (Exception ex)
            {
                MessageHandling.PrintException(path, ex);
                return false;
            }
        }

        public static void ShowOpenWithDialog(string path)
        {
            var args = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "shell32.dll");
            args += ",OpenAs_RunDLL " + path;
            Process.Start("rundll32.exe", args);
        }
    }
}