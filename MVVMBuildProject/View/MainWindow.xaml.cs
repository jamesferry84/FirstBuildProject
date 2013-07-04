using System;
using System.Windows;
using log4net;
using log4net.Config;
namespace MVVMBuildProject.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ILog log = LogManager.GetLogger(typeof(MainWindow));
        public MainWindow()
        {
           
            InitializeComponent();
           log.Error("This is an error");
        }

       

    }
}
