using System;
using TrainingApp1.ViewModel.Exercises;
using Xamarin.Forms;

namespace TrainingApp1.View.Exercises
{
    public partial class ExercisesPage : ContentPage
	{
        ExerciseViewModel _ViewModel;
        public ExercisesPage ()
		{
            _ViewModel = DependencyService.Get<ExerciseViewModel>();
            BindingContext = _ViewModel;
            InitializeComponent ();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            var eep = new ExerciseNewPage();
            eep.BindingContext = _ViewModel;
            Navigation.PushModalAsync(eep);
        }

        async void OnExerciseTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ExercisePage(_ViewModel));
        }
    }
}