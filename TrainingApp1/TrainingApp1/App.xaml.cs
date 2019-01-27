using System;
using TrainingData;
using TrainingData.ExerciseData;
using TrainingData.RoutineData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TrainingApp1
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<ExerciseViewModel>();
            DependencyService.Register<RoutinesViewModel>();
            InitializeComponent();
            //NavigationPage braucht man für StackNavigation
            this.MainPage = new NavigationPage(new MainePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
