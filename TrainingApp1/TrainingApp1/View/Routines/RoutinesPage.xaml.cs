using System;
using TrainingApp1.ViewModel;
using TrainingApp1.ViewModel.Routines;
using TrainingData.RoutineData;
using Xamarin.Forms;

namespace TrainingApp1.View.Routines
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