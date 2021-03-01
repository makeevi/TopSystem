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
    /// Логика взаимодействия для TriangleView.xaml
    /// </summary>
    public partial class TriangleView : Page
    {
        public TriangleView(TriangleModel triangleModel)
        {
            InitializeComponent();
            this.DataContext = triangleModel;
        }
    }
}
