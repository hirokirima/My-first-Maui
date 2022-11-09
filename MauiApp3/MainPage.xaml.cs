namespace MauiApp3;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void enenyNameSelect_Clicked(object sender, EventArgs e)
	{
	enenyName.Text = eneny.Text;
	}

	private void myNameSelect_Clicked(object sender, EventArgs e)
	{
	myName.Text = my.Text;
	}

	private async void fightbtn_Clicked(object sender, EventArgs e)
	{
       Random rnd = new Random();
		int attack = rnd.Next(30);
		enenyHP.Value = enenyHP.Value - attack;
		message.Text = enenyName.Text + "に" + attack + "のダメージ" ;
		if (enenyHP.Value == 0) 
		{
			result.Text = "WIN";
			return;
		}
		await Task.Delay(1000);
		int  enenyatack =rnd .Next(30);	
		myHP.Value = myHP.Value - enenyatack;		
		message.Text = myName.Text + "に" + attack + "のダメージ";
		if (myHP.Value == 0)
		{
			result.Text = "LOSE";
			return;
		}
    }

	private void backbtn_Clicked(object sender, EventArgs e)
	{
        message.Text = "バックできない";
    }

	private void otherbtn_Clicked(object sender, EventArgs e)
	{
		message.Text = "ほかにアプリがない";

    }

	private void nigerubtn_Clicked(object sender, EventArgs e)
	{
        message.Text = "逃げられない";
	}
}

