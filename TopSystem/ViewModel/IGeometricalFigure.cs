using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace TopSystem.ViewModel
{
    public interface IGeometricalFigure
    {
        public string Name { get; }
        public Page Page { get; set; }
    }
}
