using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace TopSystem.ViewModel
{
    class MainWindowModel: BaseViewModel, IMainWindow
    {
        private Page currentPage;
        public Page CurrentPage { get => currentPage; set => Set(ref currentPage, value); }
        public MainWindowModel()
        {
            CurrentPage = new MainMenuModel().Page;
        }

    }

    public interface IMainWindow
    {
        public Page CurrentPage { get; set; }
    }
}
