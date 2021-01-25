
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BoldReports.UI.Xaml;
using Microsoft.Win32;
using System.Windows.Threading;
using System.IO;
using System.Collections;
using BoldReports.Samples.ViewModel;
using Syncfusion.Windows.Shared;

namespace BoldReports.Samples
{
    public partial class ReportView : Window
    {
        #region Constructor

        public ReportView()
        {
            InitializeComponent();
            SkinStorage.SetVisualStyle(this, "Metro");
        }

        #endregion
    }
}
