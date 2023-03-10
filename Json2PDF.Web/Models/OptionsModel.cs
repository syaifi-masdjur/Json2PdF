namespace Json2PDF.Web.Models
{
    public class Options
    {
        public string report_title { get; set; }
        public string report_byline { get; set; }
        public string version_number { get; set; }
        public string section_title { get; set; }
        public bool highlighted { get; set; }
        public int columns { get; set; }
        public string title { get; set; }
        public object value { get; set; }
        public string units { get; set; }
        public string icon { get; set; }
        public string width { get; set; }
        public string text { get; set; }
        public List<string> headings { get; set; }
        public bool? striped { get; set; }
        public List<List<string>> rows { get; set; }
    }
}
