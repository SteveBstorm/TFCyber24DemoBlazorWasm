using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using TFCyberDemoBlazorWasm.Models;
using TFCyberDemoBlazorWasm.Services;

namespace TFCyberDemoBlazorWasm.Pages
{
    public partial class Demo4
    {
        [Inject]
        public MovieService MonService { get; set; }
        [Inject]
        public NavigationManager Nav { get; set; }
        public Film MyFormObject { get; set; }

        protected override void OnInitialized()
        {
            MyFormObject = new Film();
        }

        public void ValidationFormulaire()
        {
            MonService.Ajouter(MyFormObject);
            Console.WriteLine(JsonConvert.SerializeObject(MyFormObject));
            Nav.NavigateTo("home");
        }
    }
}
