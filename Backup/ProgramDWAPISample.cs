//--------------------------------------------------------------------
// FILENAME:		ProgramDWAPISample.cs
//
// Copyright(c) 2009 Motorola, Inc. All rights reserved.
//
// DESCRIPTION:		Visual Studio generated file for DataWedge API 
//                  CSharp Sample Application
//--------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpDWAPISample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            FormDWAPISample f = new FormDWAPISample();
            Application.Run(f);
            f.Dispose();
            f = null;
        }
    }
}