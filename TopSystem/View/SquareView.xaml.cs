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
using TopSystem.ViewModel;

namespace TopSystem.View
{
    /// <summary>
    /// Логика взаимодействия для SquareView.xaml
    /// </summary>
    public partial class SquareView : Page
    {
        public SquareView(SquareModel squareModel)
        {
            InitializeComponent();
            this.DataContext = squareModel;
        }
    }
}
