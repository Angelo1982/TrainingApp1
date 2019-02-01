using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp1;
using TrainingData.ExerciseData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp1.View.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseNewPage : ContentPage
    {
        public ExerciseNewPage()
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
            var exercise = new Exercise();
            exercise.Title = entryTitle.Text;
            exercise.Description = entryDescription.Text;
            ExerciseRepository.Instance.Add(exercise);
            
            await this.Navigation.PopModalAsync();
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}