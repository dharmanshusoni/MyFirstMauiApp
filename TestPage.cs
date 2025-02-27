
namespace MyFirstMauiApp;

public class TestPage : ContentPage
{
	int Count = 0;
	Label lblCounter;

	public TestPage()
	{
		var scrollView = new ScrollView();
		var stackLayout = new StackLayout();
		scrollView.Content = stackLayout;

		lblCounter = new Label
		{
			Text = "Test",
			FontSize = 22,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Center,
		};

		stackLayout.Children.Add(lblCounter);

		var btnCounter = new Button
		{
			Text = "Click To Count",
			HorizontalOptions= LayoutOptions.Center,
		};

		stackLayout.Children.Add(btnCounter);

		btnCounter.Clicked += OnClickedEvent;

		this.Content = scrollView;
	}

    private void OnClickedEvent(object? sender, EventArgs e)
    {
        Count++;
		lblCounter.Text = $"Click Count: {Count}";

		SemanticScreenReader.Announce(lblCounter.Text);
    }
}