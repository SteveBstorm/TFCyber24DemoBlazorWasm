using Microsoft.AspNetCore.Components;

namespace TFCyberDemoBlazorWasm.Pages.Exercices
{
    public partial class Quizz
    {
        [Parameter]
        public string Prenom { get; set; }
        [Parameter]
        public EventCallback<string> Repondre { get; set; }

        public List<string> Questions { get; set; }
        public int Counter { get; set; }

        protected override void OnInitialized()
        {
            Questions = new List<string>();
            Questions.Add("Avez vous bien mangé à midi ?");
            Questions.Add("Pas trop du Blazor ?");
            Questions.Add("Vous en voulez plus ?");
            Counter = 0;
        }

        public void ValiderReponse(string rep)
        {
            Repondre.InvokeAsync(rep);
            Counter++;
        }
    }
}
