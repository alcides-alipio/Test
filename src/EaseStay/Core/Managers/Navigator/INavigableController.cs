using System.Windows.Forms;

namespace EaseStay.Core.Managers
{
    internal interface INavigableController
    {
        UserControl View { get; }

        void OnCreate(Navigator navigator, object[] args);
        void OnDestroy();
    }
}
