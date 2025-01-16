using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.Views;

namespace CourseManagement.Controllers;
internal class MainController
{
    private readonly MainView _mainView;
    public MainController()
    {
        _mainView = new MainView();
    }
    public void ShowHelp()
    {
        _mainView.Help();
    }
    public void Clear()
    {
        _mainView.Clear();
    }
}
