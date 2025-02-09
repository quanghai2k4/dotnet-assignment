using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Views;

namespace VideoGameManagement.Controllers;

internal class MainController
{
    MainView _mainView = new();

    public void ShowMenu()
    {
        _mainView.ShowMenu();
    }

    public void Clear()
    {
        _mainView.Clear();
    }
}
