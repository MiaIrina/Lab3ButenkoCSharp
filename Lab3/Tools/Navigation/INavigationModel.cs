using ButenkoLab03.Model;


namespace ButenkoLab03.Tools.Navigation
{
	internal enum ViewType
	{
		FormUser,
		Main
	}

	interface INavigationModel
	{
		void Navigate(ViewType viewType);
		void Navigate(ViewType viewType, Person user);
	}
}
