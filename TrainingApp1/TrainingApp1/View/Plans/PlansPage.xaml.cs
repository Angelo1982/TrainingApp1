
using TrainingApp1.ViewModel.Plans;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp1.View.Plans
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlansPage : ContentPage
	{
        private PlansViewModel _ViewModel;
		public PlansPage ()
		{
            _ViewModel = DependencyService.Get<PlansViewModel>();
            BindingContext = _ViewModel;

            InitializeComponent ();
		}
	}
}