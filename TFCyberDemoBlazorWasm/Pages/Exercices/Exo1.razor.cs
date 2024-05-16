namespace TFCyberDemoBlazorWasm.Pages.Exercices
{
    public partial class Exo1
    {
        public string Prenom { get; set; }
        List<string> Reponses { get; set; }
        private bool gameOver;

        public bool GameOver
        {
            get { return Reponses.Count == 3; }
        }


        protected override void OnInitialized()
        {
            Reponses = new List<string>();
        }

        public void EnregistrerReponse(string reponse)
        {
            Reponses.Add(reponse);
        }
    }
}
