using BorderDrawingIssue.ViewModels;

namespace BorderDrawingIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage(PageViewModel pageViewModel)
        {
            InitializeComponent();
            this.BindingContext = pageViewModel;
        }

    }

}
