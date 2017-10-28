using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;




namespace UI
{
    public partial class App : Application
    {
        //INTERFACE FOR GETTING IMAGES FROM GALLERY
        public interface IPicturePicker
        {
            Task<Stream> GetImageStreamAsync();
        }

        public App()
        {
            InitializeComponent();

            MainPage = new Login();



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
