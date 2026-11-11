using CalculadoraDePropinas.ViewModels;

namespace CalculadoraDePropinas.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}