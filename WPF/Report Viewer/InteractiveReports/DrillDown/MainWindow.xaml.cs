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
using Syncfusion.Windows.Reports;

namespace Drilldowndemo
{
    public partial class MainWindow : Window
    {
       
        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        #endregion

      }
}
