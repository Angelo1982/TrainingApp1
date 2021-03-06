﻿using TrainingApp1.ViewModel.Exercises;
using TrainingApp1.ViewModel.Plans;
using TrainingApp1.ViewModel.Routines;
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
            DependencyService.Register<PlansViewModel>();
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
