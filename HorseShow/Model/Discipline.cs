using System.ComponentModel;
using Newtonsoft.Json;
using PropertyChanged;

namespace HorseShow.Model
{
    [ImplementPropertyChanged]
    public class Discipline
    { 
        [JsonProperty(PropertyName = "discipline")]
        public string discipline { get; set; }

        public string headerName { get; set; }
    }
       
    
}