using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawAndSelect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InkEditingModes editingModes = new InkEditingModes();
        public MainWindow()
        {
            InitializeComponent();

            //inkCanvas.DataContext = editingModes;

        }

        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            //editingModes.EditingMode = InkCanvasEditingMode.Select;
            (this.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Select;
        }

        private void Drawing_Click(object sender, RoutedEventArgs e)
        {
            //editingModes.EditingMode = InkCanvasEditingMode.Ink;
            (this.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}
