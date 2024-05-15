using Microsoft.AspNetCore.Components;

namespace TFCyberDemoBlazorWasm.Pages
{
    public partial class Demo2Enfant
    {
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public int ValueFromParent { get; set; }

        [Parameter]
        public EventCallback<string> Reponse { get; set; }

        //A chaque modification de la valeur d'un paramètre
        protected override void OnParametersSet()
        {
            ValueFromParent *= 2;  
        }

        public void Repondre()
        {
            Reponse.InvokeAsync("Oui seigneur des ténèbres");
        }

    }
}
