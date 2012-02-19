using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quentinrider.ViewModules
{
    interface IViewModule
    {
        string GetStyles();
        string GetScripts();
        string Render();
    }
}
