namespace Pulsar_Site.Models
{
    public class Resources
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public class Product
    {
        public string Href { get; set; } = "";
        public string Title { get; set; } = "";
        public string Details { get; set; } = "";
        public string Image { get; set; } = "";
        public Resources[]? Resources { get; set; }
        public string Acronym { get; set; }
        public string Category { get; set; }
        public string Youtube_URL { get; set; }
        public string Description {  get; set; }

        public Product(string href, string title, string image, string details = "", string acronym = "", string category = null)
        {
            this.Href = "/produtos" + href;
            this.Title = title;
            this.Image = image;
            this.Details = details;
            this.Acronym = acronym;
            this.Category = category;

            if (image.Contains("SVG/softwares/"))
            {
                this.Image = image;
            }
            else
            {
                this.Image = "SVG/softwares/" + image;
            }
        }
    }
}
