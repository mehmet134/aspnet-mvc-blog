using App.Web.Mvc.Models;
using static System.Net.Mime.MediaTypeNames;

namespace App.Web.Mvc.Data
{
	public class Database
	{
		public List<UstList> UstList { get; set; }
		public List<AnaList> AnaList { get; set; }
		public List<SliderList> SliderList { get; set; }

		public Database()
		{
			UstList = new List<UstList>()
			{
			new UstList() {Id=1, Name = "Home"},
			new UstList() {Id = 2, Name = "Blog Posts"},
			new UstList() {Id=3, Name = "About"},
			new UstList() {Id=4, Name = "Category"},
			new UstList() {Id=5, Name = "Post Format"},
			new UstList() {Id=6, Name = "Contact"},


            };

			AnaList = new List<AnaList>()
			{
				new AnaList(){Id=1, Name="Explore" ,Baslik="The best place to explore to enjoy",Yazi="June 15, 2019" ,ResimDosyaAdi="news/f1.jpg" },
				new AnaList(){Id=2, Name="Lifestyle" ,Baslik="How to Make list for travelling alone",Yazi="September 15, 2019" ,ResimDosyaAdi="news/f2.jpg" },
				new AnaList(){Id=3, Name="Food" ,Baslik="5 ingredient cilantro vinaigrette",Yazi="September 15, 2019"  ,ResimDosyaAdi="news/f3.jpg"},
				new AnaList(){Id=4, Name="Explore" ,Baslik="A Simple Way to Feel Like Home When You Travel",Yazi="March 20, 2019"  ,ResimDosyaAdi="news/f4.jpg"},
				new AnaList(){Id=5, Name="March 20, 2019" ,Baslik="What Type of Traveller Are You?",Yazi="September 15, 2019" ,ResimDosyaAdi="news/f5.jpg"},

                new AnaList(){Id=6, Name="Experience" ,Baslik="A Road Trip Review of the 2018",Yazi="July 10, 2019" ,ResimDosyaAdi="news/f6.jpg" },
                new AnaList(){Id=7, Name="music" ,Baslik="Portugal’s Sunset summer vission",Yazi="September 15, 2019" ,ResimDosyaAdi="news/f7.jpg" },
                new AnaList(){Id=8, Name="beauty" ,Baslik="The best soft Tropical Getaway",Yazi="March 12, 2019"  ,ResimDosyaAdi="news/f8.jpg"},
                new AnaList(){Id=9, Name="Travel" ,Baslik="Memoriable Paris Girls Trip",Yazi="April 19, 2019"  ,ResimDosyaAdi="news/f9.jpg"},
                new AnaList(){Id=10, Name="Experience" ,Baslik="How to Plan your Trip the Right Way" ,Yazi="February 15, 2019",ResimDosyaAdi="news/f10.jpg"},
                new AnaList(){Id=11, Name="Travel" ,Baslik="8 Powerful Ways to Add Vibrant Colour to Your Life" ,Yazi="April 19, 2019"  ,ResimDosyaAdi="news/f11.jpg"},
                new AnaList(){Id=12, Name="Lifestyle" ,Baslik="The best to-do list to help boost your productivity" ,Yazi="October 2, 2019",ResimDosyaAdi="news/f2.jpg"}
            };
			SliderList = new List<SliderList>()
			{
				new SliderList(){Id=1, Name="Lifestyle" ,Baslik="Tips for Taking a Long-term Trip",Yazi="January 2, 2019" ,ResimDosyaAdi="slider/slider1.jpg" },
				new SliderList(){Id=2, Name="Travel" ,Baslik="Trip to California",Yazi="September 15, 2019" ,ResimDosyaAdi="slider/slider2.jpg" },
				new SliderList(){Id=3, Name="weekends" ,Baslik="Our Favorite Weekend Getaways",Yazi="June 12, 2019"  ,ResimDosyaAdi="slider/slider3.jpg"},
                new SliderList(){Id=4, Name="Travel" ,Baslik="Trip to California",Yazi="September 15, 2019" ,ResimDosyaAdi="slider/slider2.jpg" },
                new SliderList(){Id=5, Name="weekends" ,Baslik="Our Favorite Weekend Getaways",Yazi="June 12, 2019"  ,ResimDosyaAdi="slider/slider3.jpg"},
                new SliderList(){Id=6, Name="Lifestyle" ,Baslik="Tips for Taking a Long-term Trip",Yazi="January 2, 2019" ,ResimDosyaAdi="slider/slider1.jpg" },



            };
		}


	}
}
