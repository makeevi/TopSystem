using System;
using System.Collections.Generic;
using System.Text;
using TopSystem.View;

namespace TopSystem.ViewModel
{
    public class RectangleModel: BaseViewModel, IGeometricalFigure
    {
        public string Name => "Прямоугольник";

        public RectangleModel()
        {
            Page = new RectangleView(this);
        }
    }
}
