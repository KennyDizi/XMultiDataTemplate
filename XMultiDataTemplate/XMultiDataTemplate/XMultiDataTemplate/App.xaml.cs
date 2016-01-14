using Xamarin.Forms;
using XMultiDataTemplate.SourceCode.Views;

namespace XMultiDataTemplate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new TestPageView());
        }
    }
}
