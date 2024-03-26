using MAUI8Example.Data;

namespace MAUI8Example.Pages.Monkeys;

public partial class MonkeyMenu : ContentPage
{
	MonkeyService monkeyService;
	public MonkeyMenu(MonkeyService monkeyService)
	{
		InitializeComponent();

		this.monkeyService = monkeyService;
	}
}