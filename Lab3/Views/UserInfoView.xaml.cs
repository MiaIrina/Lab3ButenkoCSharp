using ButenkoLab03.Model;
using ButenkoLab03.Tools.Navigation;
using ButenkoLab03.ViewModels;

using System.Windows.Controls;


namespace ButenkoLab03.Views
{
	/// <summary>
	/// Логика взаимодействия для UserInfoView.xaml
	/// </summary>
	public partial class UserInfoView : UserControl, INavigatable

	{
		internal UserInfoView(Person user)
		{
			InitializeComponent();
			DataContext = new UserInfoViewModel(user);
		}
	}
}
