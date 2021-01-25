#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows;
using System.Windows.Input;
using System.Net;
using System.IO;
using BoldReports.UI.Xaml;

namespace BoldReports.Samples.ViewModel
{
    public class ReportViewModel 
    {
        public ReportModel Report { get; set; }
           
        #region Constructor

        public ReportViewModel()
        {
            this.Report = new ReportModel();
            this.Report.ReportPath = this.GetFullPath("InteractiveSorting.rdl");
        }

        public void Loaded(object sender, RoutedEventArgs e)
        {
            Window mainWindow = sender as Window;
            ReportViewer viewer= mainWindow.FindName("viewer") as ReportViewer;
            viewer.RefreshReport();
        }

        private string GetFullPath(string report)
        {
            string templateDirectory = @"../../../../../../Common/Data/ReportTemplate/";
            string dir = new DirectoryInfo(templateDirectory).FullName;
            return System.IO.Path.Combine(dir, report);  
        }

        #endregion
    }
}
