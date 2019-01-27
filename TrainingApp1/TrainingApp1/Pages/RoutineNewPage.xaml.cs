using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TrainingData;
using TrainingData.RoutineData;
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

            //_Routine.RoutineExercises = new HashSet<int>(_ViewModel.Exercises.Where(ex => ex.IsSelected)
            //    .Select(ex => ex.Exercise.Id).ToArray());

            //Was mache ich hier? Das verstehe ich momentan noch nicht:
            //Speichere ich über die Routine separat von den RoutineExercises? 
            //Und die RoutineExercise über ihr eigenes Repository? Und wie mache ich das beim laden der Routine?
            //Oder speichere ich alles über die Routine und die Unit of Work speichert dann alles selber?

            _Routine.RoutineExercises = new List<RoutineExercise>();
            var exerciseIds = _ViewModel.Exercises.Where(ex => ex.IsSelected).Select(ex => ex.Exercise.Id);
            foreach(var id in exerciseIds)
            {
                _Routine.RoutineExercises.Add(new RoutineExercise
                {
                    Id = TrainingContext.GetRoutineExerciseId(), //IdHelper.GetRoutineExerciseId(_Uow.Routines);
                    IdExercise = id,
                    IdRoutine = _Routine.Id
                });
            }
            RoutineRepository.Instance.Add(_Routine); //_Uow.Routines.Add(_Routine);
            
            await this.Navigation.PopModalAsync();
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}