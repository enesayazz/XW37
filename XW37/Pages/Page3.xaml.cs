namespace XW37;

public partial class Page3 : ContentPage
{
    string gender;
	public Page3()
    {
        InitializeComponent();
        Parent_List_Wiev.ItemsSource = App.DBTrans.GetParents();
    }

    private void Button_Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddParent(new Models.Parent
        {
            P_Name = Parent_Name_Entry.Text,
            P_L_Name = Parent_Last_Name_Entry.Text,
            P_Tel= Parent_Tel_Entry.Text,
            P_Mother_Father = gender,
        });
        Parent_List_Wiev.ItemsSource = App.DBTrans.GetParents();
    }

    private void Button_Delete_Clicked(object sender, EventArgs e)
    {
       

    }

    private void Button_Delete_Clicked_1(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteParent((int)button.BindingContext);
        Parent_List_Wiev.ItemsSource = App.DBTrans.GetParents();
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        gender = "Mother";
    }

    private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
    {
        gender = "Father";
    }
}