using System.Threading.Tasks;
using Xamarin.Forms;

namespace SyncFusionTest
{
    public partial class SyncFusionTestPage : ContentPage
    {
        public SyncFusionTestPage()
        {
            InitializeComponent();
            BindingContext = this;
            IsBusy = false;
            Done();
        }

        private async void Done(){
            IsBusy = true;
            await Task.Delay(5000);
            IsBusy = false;
        }
    }
}
