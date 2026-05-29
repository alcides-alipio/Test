using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EaseStay.Core
{
    internal class Navigator
    {
        private Panel _host;
        private INavigableController _currentController;
        private Dictionary<string, Type> _routes;

        public Navigator(Panel host)
        {
            _host = host;
            _routes = new Dictionary<string, Type>();
            _currentController = null;
        }

        public void Register<T>(string route)
        {
            if (_routes.ContainsKey(route))
                return;

            _routes.Add(route, typeof(T));
        }

        public void Navigate(string route)
        {
            if (!_routes.TryGetValue(route, out Type controller))
                throw new Exception($"Route '{route}' not found.");

            if (_currentController != null)
            {
                _currentController.OnDestroy();
                _host.Controls.Remove(_currentController.View);
                _currentController.View.Dispose();
                
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

            _currentController = (INavigableController)Activator.CreateInstance(controller);
            if (_currentController == null)
            {
                MessageBox.Show("A minha vida n faz sentido :(");
                return;
            }
            _host.Controls.Add(_currentController.View);
            _currentController.OnCreate(this);
            

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
