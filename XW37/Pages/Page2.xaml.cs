namespace XW37;

public partial class Page2 : ContentPage
{
    string gender;
	public Page2()
	{
		InitializeComponent();
		Children_List_Wiev.ItemsSource = App.DBTrans.GetChildren();
	}

    private void Button_Add_Clicked(object sender, EventArgs e)
    {
		App.DBTrans.AddChild(new Models.Child
		{
			C_Name = Child_Name_Entry.Text,
			C_L_Name = Child_Last_Name_Entry.Text,
            C_Gender = gender,
		});
        Children_List_Wiev.ItemsSource = App.DBTrans.GetChildren();
    }

    private void Button_Delete_Clicked(object sender, EventArgs e)
    {
       

    }

    private void Button_Delete_Clicked_1(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteChild((int)button.BindingContext);
        Children_List_Wiev.ItemsSource = App.DBTrans.GetChildren();

    }

    private void Child_Male_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        gender = "Male";
    }

    private void Child_Female_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        gender = "Female";
    }
}