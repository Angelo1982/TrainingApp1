using System;
using TrainingData;
using TrainingData.Routine;
using Xamarin.Forms;

namespace TrainingApp1.Pages
{
    public partial class RoutinesPage : ContentPage
	{
        RoutinesViewModel _ViewModel;
        public RoutinesPage ()
		{
            _ViewModel = DependencyService.Get<RoutinesViewModel>();
            BindingContext = _ViewModel;
            
            InitializeComponent();
		}

        private void btnAdd_Clicked(object sender, EventArgs e)
        { 
            var eep = new RoutineNewPage();
            Navigation.PushModalAsync(eep);
        }

        async void OnRoutineTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new RoutinePage(((Routine)e.Item).Id));
        }
    }
}