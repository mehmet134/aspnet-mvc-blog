namespace App.Web.Mvc.Models
{
	public class SliderList
	{


		public int Id { get; set; }
		public string Name { get; set; }

		public string UstListId { get; set; }

		public string Baslik { get; set; }
		public string Yazi { get; set; }
		public string ResimDosyaAdi { get; set; } // Resim dosya adını burada saklayabilirsiniz.

		public string ResimYolu
		{
			get
			{
				if (!string.IsNullOrEmpty(ResimDosyaAdi))
				{
					return "/images/" + ResimDosyaAdi; // wwwroot klasöründeki images altındaki dosyaya göre yol belirtilir.
				}
				return null;
			}
		}
	}
	
}
