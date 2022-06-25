using System.Windows.Controls;

using Prism.Regions;

namespace HelloWorld.Modules.ModuleA.Views
{
    /// <summary>
    /// Interaction logic for ViewA
    /// </summary>
    [ViewSortHint("V1")]
    public partial class ViewA : UserControl
    {
        public ViewA()
        {
            InitializeComponent();
        }
    }
}
