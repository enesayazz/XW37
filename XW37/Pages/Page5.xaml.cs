namespace XW37;

public partial class Page5 : ContentPage
{
	public Page5()
	{
		InitializeComponent();
		Assignment_List_Wiev.ItemsSource= App.DBTrans.GetAssignments();
	}

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        Assignment_List_Wiev.ItemsSource = App.DBTrans.GetAssignments();
    }

    private void Button_Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteAssignment((int)button.BindingContext);
        Assignment_List_Wiev.ItemsSource = App.DBTrans.GetAssignments();

    }
}