
using System.Windows.Controls;
using ButenkoLab03.Tools.Navigation;
using ButenkoLab03.ViewModels;
namespace ButenkoLab03.Views
{
	/// <summary>
	/// Логика взаимодействия для UserHoroscopeControl.xaml
	/// </summary>
	public partial class UserHoroscopeControl : UserControl, INavigatable
	{
		public UserHoroscopeControl()
		{
			InitializeComponent();
			DataContext = new HoroscopViewModel();
		}
	}
}
