using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp1.Pages
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