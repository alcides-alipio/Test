using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EaseStay.Core.Managers
{
    internal class Navigator
    {
        private readonly Panel _host;
        private INavigableController _currentController;
        private readonly Dictionary<string, Type> _routes;

        public Navigator(Panel host)
        {
            _host = host;
            _routes = new Dictionary<string, Type>();
            _currentController = null;
        }

        public void Register<T>(string route)
            where T : INavigableController
        {
            if (_routes.ContainsKey(route))
                return;

            _routes.Add(route, typeof(T));
        }

        public void Navigate(string route) => 
            Navigate(route, null);

        public void Navigate(string route, params object[] args)
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
            _host.Controls.Add(_currentController.View);
            Application.DoEvents();
            _currentController.OnCreate(this, args);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
