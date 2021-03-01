using System;
using System.Collections.Generic;
using System.Text;
using TopSystem.View;

namespace TopSystem.ViewModel
{
    public class SquareModel : BaseViewModel, IGeometricalFigure
    {
        public string Name => "Квадрат";

        public SquareModel()
        {
            Page = new SquareView(this);
        }
    }
}
