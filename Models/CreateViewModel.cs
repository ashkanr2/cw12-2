using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace web_app.Models
{
    public class CreateViewModel
    {
        
        public string Name { get; set; }

        
        public string Color { get; set; }

        public string Model { get; set; }

        public int Code { get; set; }
        public Brand Brand { get; set; }


    }
}
