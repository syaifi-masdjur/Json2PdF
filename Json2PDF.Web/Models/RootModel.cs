using Microsoft.Extensions.Options;
using System.ComponentModel;

namespace Json2PDF.Web.Models
{
    public class Root
    {
        public string type { get; set; }
        public Options options { get; set; }
        public Config config { get; set; }
        public List<Components> components { get; set; }
    }
}
