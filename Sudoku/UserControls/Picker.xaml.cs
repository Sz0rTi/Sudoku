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

namespace Sudoku.UserControls
{
    /// <summary>
    /// Interaction logic for Picker.xaml
    /// </summary>
    public partial class Picker : Window
    {
        public int Value { get; set; }
        public Picker()
        {
            InitializeComponent();   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Point p = PointToScreen(Mouse.GetPosition(sender as Button));
            this.Left = p.X;
            this.Top = p.Y;
            var btn = (Button)sender;
            Value = int.Parse((string)btn.Content);
            this.Close();
        }
    }
}
