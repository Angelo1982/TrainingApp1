using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrainingData.RoutineData;
using TrainingApp1.ViewModel.Routines;
using TrainingData;

namespace TrainingApp1.View.Routines
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RoutineEditPage : ContentPage
	{
		public RoutineEditPage ()
		{
			InitializeComponent ();
		}

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            Routine routine;
            RoutineEditViewModel vm = (RoutineEditViewModel)BindingContext;
            routine = vm.Routine;

            if (routine.Title != entryTitle.Text)
            {
                routine.Title = entryTitle.Text;
            }

            routine.Description = entryDescription.Text;

            var choosenRoutineExercises = new List<RoutineExercise>();
            var exerciseIds = vm.Exercises.Where(ex => ex.IsSelected).Select(ex => ex.Exercise.Id);

            //Add the selected exercises to the routine
            foreach (var id in exerciseIds)
            {
                choosenRoutineExercises.Add(new RoutineExercise //_Uow.Routines.Add(...)
                {
                    Id = TrainingContext.GetRoutineExerciseId(), //IdHelper.GetRoutineExerciseId(_Uow.Routines);
                    IdExercise = id,
                    IdRoutine = routine.Id
                });
            }

            //This causes a PropertyChanged event on the routine which leads to an update of the Exercises
            //which is the collection that is represented in the ListView
            routine.RoutineExercises = choosenRoutineExercises;

            await this.Navigation.PopModalAsync();
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}