using OnlyCars.Models;

public partial class Motos : ContentPage
{
	public List<Store> Stores { get; set; }

    public Motos()
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
                Logo="yr.png",
                Name = "Yamaha YZF-R6",
                km = "315km/h",
                Money  = 17000,
                Stock = 100,
                Rating = 4.5
            },
            new Store
            {
                Id = 2,
                Header="header",
                Logo="gtr.png",
                Name = "Nissan Skyline GTR R34",
                km = "266km/h",
                Money = 100000,
                Stock = 10,
                Rating = 5
            },
             new Store
            {
                Id = 3,
                Header="header",
                Logo="silvia.png",
                Name = "Nissan Silvia S15",
                km = "257Km/h",
                Money = 80000,
                Stock = 10,
                Rating = 4
            },
              new Store
            {
                Id = 4,
                Header="header",
                Logo="miata.png",
                Name = "Mazda MX 5 Miata",
                km = "195km/h",
                Money = 10000,
                Stock = 100,
                Rating = 3.5
            },
               new Store
            {
                Id = 5,
                Header="header",
                Logo="honda.png",
                Name = "Honda civic jaiba año 1998",
                km = "200/h",
                Money = 20000,
                Stock = 200,
                Rating = 5
            },
        };
    }
}