using System;
using System.Collections.Generic;
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

namespace ComboBoxTest
{
    /// <summary>
    /// Interaction logic for TestUC.xaml
    /// </summary>
    public partial class TestUC : UserControl
    {
        public TestUC()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VMManager.Instance.TransitionToVM<OtherVM>();
        }
    }
}
