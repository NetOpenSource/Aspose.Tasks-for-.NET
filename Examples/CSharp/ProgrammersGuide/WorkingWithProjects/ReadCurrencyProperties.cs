//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System;

namespace CSharp.Projects
{
    public class ReadCurrencyProperties
    {
        public static void Run()
        {
            //ExStart: ReadCurrencyProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            Project project = new Project(dataDir+ "ReadCurrencyProperties.mpp");

            //Display currency properties
            Console.WriteLine("Currency Code : " + project.Get(Prj.CurrencyCode).ToString());
            Console.WriteLine("<br>Currency Digits : " + project.Get(Prj.CurrencyDigits).ToString());
            Console.WriteLine("<br>Currency Symbol : " + project.Get(Prj.CurrencySymbol).ToString());
            Console.WriteLine("Currency Symbol Position" + project.Get(Prj.CurrencySymbolPosition).ToString());
            //ExEnd: ReadCurrencyProperties
        }
    }
}