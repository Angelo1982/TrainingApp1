using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TrainingData;
using TrainingData.Routine;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RoutineNewPage : ContentPage
	{
        RoutineEditViewModel _ViewModel;
        Routine _Routine;

        public RoutineNewPage()
		{
            _Routine = new Routine();
            _ViewModel = new RoutineEditViewModel(_Routine);
            BindingContext = _ViewModel;
			InitializeComponent ();

        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {

            _Routine.Exercises = new HashSet<int>(_ViewModel.Exercises.Where(ex => ex.IsSelected)
                .Select(ex => ex.Exercise.Id).ToArray());
            RoutineRepository.Instance.Add(_Routine);
            

            await this.Navigation.PopModalAsync();
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}