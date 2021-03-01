using System;
using System.Collections.Generic;
using System.Text;
using TopSystem.View;

namespace TopSystem.ViewModel
{
    public class CircleModel: BaseViewModel, IGeometricalFigure
    {
        public string Name => "Круг";

        public CircleModel()
        {
            Page = new CircleView(this);
        }
    }
}
