namespace XW37;
using Models;

public partial class Page4 : ContentPage
{
    int tappedParentid = 0;
    int tappedChildid = 0;
	public Page4()
        
	{
		InitializeComponent();
		Children_List_Wiev.ItemsSource = App.DBTrans.GetChildren();
		Parent_List_Wiev.ItemsSource = App.DBTrans.GetParents();
	}

    private void Parent_List_Wiev_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tappedParent = (Parent)e.Item;
        tappedParentid = tappedParent.P_ID;
    }

    private void Children_List_Wiev_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tappedChild = (Child)e.Item;
        tappedChildid = tappedChild.C_ID;

    }

    private void Button_Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddAssignment(new Models.Assignment
        {
            C_ID = tappedChildid,
            P_ID = tappedParentid,
        });
    }
}