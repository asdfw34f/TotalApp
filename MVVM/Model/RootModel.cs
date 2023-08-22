using System.Text.Json.Serialization;

namespace TotalApp.MVVM.Model
{
    public class RootModel
    {
        public string ID { get; set; }

        public string Owner { get; set; }

        public string Remain { get; set; }

        public string Name { get; set; }
    }
}