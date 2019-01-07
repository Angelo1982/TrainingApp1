using System;
using System.Diagnostics;
using TrainingData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseEditPage : ContentPage
    {
        private bool CreateNew { get; }

        public ExerciseEditPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            //ToDo:
            var answer = DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
            return false;
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            Exercise currentExercise;
            ExerciseViewModel vm = (ExerciseViewModel)BindingContext;
            currentExercise = vm.CurrentExercise;

            if (currentExercise.Title != entryTitle.Text)
            {
                currentExercise.Title = entryTitle.Text;
                ExerciseRepository.Instance.OrderExercises();
            }

            currentExercise.Description = entryDescription.Text;

            await this.Navigation.PopModalAsync();
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}