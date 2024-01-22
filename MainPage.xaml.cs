namespace AppNumeroSorte;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumbers(object sender, EventArgs e)
	{
		if (LabelNameApp.IsVisible)
			LabelNameApp.IsVisible = false;

		if (!ContainerNumbers.IsVisible)
			ContainerNumbers.IsVisible = true;

        SortedSet<int> set = GenerateLuckNumbers();

		LuckNumber01.Text = set.ElementAt(0).ToString("D2");
		LuckNumber02.Text = set.ElementAt(1).ToString("D2");
		LuckNumber03.Text = set.ElementAt(2).ToString("D2");
		LuckNumber04.Text = set.ElementAt(3).ToString("D2");
		LuckNumber05.Text = set.ElementAt(4).ToString("D2");
		LuckNumber06.Text = set.ElementAt(5).ToString("D2");
    }

	private SortedSet<int> GenerateLuckNumbers()
	{
        SortedSet<int> set = new SortedSet<int>();

		while (set.Count < 6)
		{
            Random random = new Random();
			int randoredNumber = random.Next(01, 60);

			set.Add(randoredNumber);
        }

		return set;
    }
}