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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExercisePage : ContentPage
	{
        private readonly ExerciseViewModel _ViewModel;

        public ExercisePage (ExerciseViewModel viewModel)
		{
            NavigationPage.SetBackButtonTitle(this, "Back");
            BindingContext = viewModel;

            InitializeComponent ();
            this._ViewModel = viewModel;
        }

        private void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var eep = new ExerciseEditPage();
            eep.BindingContext =  _ViewModel;
            Navigation.PushModalAsync(eep);
        }
    }
}