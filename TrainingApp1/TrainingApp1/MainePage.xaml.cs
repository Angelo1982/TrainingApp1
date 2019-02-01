using TrainingApp1.View.Exercises;
using TrainingApp1.View.Plans;
using TrainingApp1.View.Routines;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainePage : TabbedPage
    {
        public MainePage ()
        {
            InitializeComponent();

            this.Children.Add(new PlanPage());
            this.Children.Add(new RoutinesPage());
            this.Children.Add(new ExercisesPage());
        }
    }
}