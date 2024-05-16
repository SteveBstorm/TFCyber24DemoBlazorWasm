using Newtonsoft.Json;
using System.Text.Json.Serialization;
using TFCyberDemoBlazorWasm.Models;

namespace TFCyberDemoBlazorWasm.Pages
{
    public partial class Demo4
    {
        public Film MyFormObject { get; set; }

        protected override void OnInitialized()
        {
            MyFormObject = new Film();
        }

        public void ValidationFormulaire()
        {
            Console.WriteLine(JsonConvert.SerializeObject(MyFormObject));
        }
    }
}
