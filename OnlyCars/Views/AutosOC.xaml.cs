using OnlyCars.Models;

namespace OnlyCars.Autos;

public partial class AutosOC : ContentPage
{
    public List<Store> Stores { get; set; }
    public AutosOC()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;
    }

    private void LoadData()
    {

        Stores = new List<Store>
        {
            new Store
            {
                Id = 1,
                Header="header",
                Logo="b.png",
                Name = "Dodge Challenger 1970",
                km = "315km/h",
                Money  = 45000,
                Stock = 100,
                Rating = 4.5
            },
            new Store
            {
                Id = 2,
                Header="header",
                Logo="a.png",
                Name = "Nissan Skyline GTR R34",
                km = "315km/h",
                Money = 5,
                Stock = 10,
                Rating = 4.5
            },
             new Store
            {
                Id = 3,
                Header="header",
                Logo="b.png",
                Name = "Nissan Skyline GTR R34",
                km = "315km/h",
                Money = 5,
                Stock = 10,
                Rating = 4.5
            },
              new Store
            {
                Id = 4,
                Header="header",
                Logo="a.png",
                Name = "Nissan Skyline GTR R34",
                km = "315km/h",
                Money = 5,
                Stock = 10,
                Rating = 4.5
            },
               new Store
            {
                Id = 5,
                Header="header",
                Logo="b.png",
                Name = "Nissan Skyline GTR R34",
                km = "315km/h",
                Money = 5,
                Stock = 10,
                Rating = 4.5
            },
        };
    }
}