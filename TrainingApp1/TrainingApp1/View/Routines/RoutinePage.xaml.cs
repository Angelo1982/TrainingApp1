using System;
using TrainingApp1.View.Exercises;
using TrainingApp1.ViewModel.Exercises;
using TrainingApp1.ViewModel.Routines;
using Xamarin.Forms;

namespace TrainingApp1.View.Routines
{

    public partial class RoutinePage : ContentPage
	{
        private RoutineViewModel _ViewModel;

        public RoutinePage (int idRoutine)
		{
            NavigationPage.SetBackButtonTitle(this, "Back");
            _ViewModel = new RoutineViewModel(idRoutine);
            BindingContext = _ViewModel;
            _ViewModel.PropertyChanged += ViewModel_PropertyChanged;
            InitializeComponent();
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_ViewModel.Exercises))
            {
                lvExercises.ItemsSource = _ViewModel.Exercises;
            }
        }

        private void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var eep = new RoutineEditPage();
            eep.BindingContext = new RoutineEditViewModel(_ViewModel.Routine);
            Navigation.PushModalAsync(eep);
        }

        //Einzelne Exercise aus der Liste öffnen
        private async void OnExerciseTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ExercisePage(new ExerciseViewModelWrapper(_ViewModel)));
        }
    }
}