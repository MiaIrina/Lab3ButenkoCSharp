
using ButenkoLab03.Tools.Managers;
using ButenkoLab03.Tools.Navigation;
using ButenkoLab03.ViewModels;
using System.Windows;
using System.Windows.Controls;


namespace Lab3
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, IContentOwner
	{


		public ContentControl ContentControl => _contentControl;

		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
			InitializeApplication();
		}
		private void InitializeApplication()
		{

			NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
			NavigationManager.Instance.Navigate(ViewType.Main);
		}
	}
}
