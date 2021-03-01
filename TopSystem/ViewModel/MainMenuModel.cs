using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using TopSystem.View;

namespace TopSystem.ViewModel
{
    public class MainMenuModel : BaseViewModel
    {
        /// <summary>
        /// Вся коллекция фигур
        /// </summary>
        public List<IGeometricalFigure> GeometricalFigures { get; private set; }
        public double FrameOpacity { get => frameOpacity; set => Set(ref frameOpacity, value); }

        public IGeometricalFigure GeometricalFigure 
        {
            set => SlowOpacity(value?.Page);
        }

        private Page figures;
        private double frameOpacity;

        public Page Figures { get => figures; set => Set(ref figures, value); }

        public MainMenuModel()
        {
            Page = new MainMenuView(this);

            GeometricalFigures = new List<IGeometricalFigure>()
            {
                new TriangleModel(), 
                new SquareModel(), 
                new CircleModel(), 
                new RectangleModel()
            };
        }

        /// <summary>
        /// Волшебство с прозрачностью цвета. Плавный переход между страницами
        /// </summary>
        /// <param name="page"></param>
        private async void SlowOpacity(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0.0; i -= 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(25);
                }
                Figures = page;
                for (double i = 0.0; i < 1.1; i += 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(25);
                }
            });
        }
    }
}
