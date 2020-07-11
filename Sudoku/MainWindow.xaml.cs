using Sudoku.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sudoku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Point p = PointToScreen(Mouse.GetPosition(this));
            Picker picker = new Picker();
            picker.Left = p.X;
            picker.Top = p.Y;
            picker.ShowDialog();
            if(picker.Value != 0)
            {
                (sender as Button).Content = picker.Value.ToString();
            }
        }
    }
}
