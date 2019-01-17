using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingData;
using TrainingData.Routine;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp1.Pages
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
            //ToDo: Überprüfung einbauen, ob diese Liste überhaupt geändert hat. Denn jedesmal, wenn siech diese Model ändert,
            //werden momentan neue RoutineExercises erzeugt.
            routine.RoutineExercises = new List<RoutineExercise>();
            var exerciseIds = vm.Exercises.Where(ex => ex.IsSelected).Select(ex => ex.Exercise.Id);
            foreach (var id in exerciseIds)
            {
                routine.RoutineExercises.Add(new RoutineExercise //_Uow.Routines.Add(...)
                {
                    Id = RoutineRepository.GetRoutineExerciseId(), //IdHelper.GetRoutineExerciseId(_Uow.Routines);
                    IdExercise = id,
                    IdRoutine = routine.Id
                });
            }

            await this.Navigation.PopModalAsync();
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}