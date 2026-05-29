using System.Windows.Forms;

namespace EaseStay.Core
{
    internal interface INavigableController
    {
        UserControl View { get; }

        void OnCreate(Navigator navigator);
        void OnDestroy();
    }
}
