namespace TFCyberDemoBlazorWasm.Pages
{
    public partial class Demo2
    {
        public int MyProp { get; set; }
        public string MyString { get; set; }
        protected override void OnInitialized()
        {
            //l'instant ou le composant est chargé pour l'affichage
            MyProp = 42;
        }

        //Un rendu se produit lors d'un changement VISUEL dans la page
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                MyString = "toto";
                MyProp = 55;
            }
            else {  }
        }
        public int Counter { get; set; } = 0;
        public void SimulateRender()
        {
            MyProp *= 2;
            MyString = "Nombre de rendu" + Counter++;
        }

        protected override bool ShouldRender()
        {
            return !(MyProp == 220);
        }

        public void ReceptionReponse(string s)
        {
            MyString = s;
        }

    }
}
