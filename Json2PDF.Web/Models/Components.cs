namespace Json2PDF.Web.Models
{
    public class Components
    {
        public string type { get; set; }
        public Options options { get; set; }
        public List<Components> components { get; set; }
    }
}
