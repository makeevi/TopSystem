using System;
using System.Collections.Generic;
using System.Text;
using TopSystem.View;

namespace TopSystem.ViewModel
{
    public class TriangleModel : BaseViewModel, IGeometricalFigure
    {
        public string Name => "Треугольник";

        public TriangleModel()
        {
            Page = new TriangleView(this);
        }
    }
}
