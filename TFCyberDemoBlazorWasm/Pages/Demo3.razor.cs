namespace TFCyberDemoBlazorWasm.Pages
{
    public partial class Demo3
    {
        public List<Guid> MaSuperListe { get; set; }

        protected override void OnInitialized()
        {
            MaSuperListe = new List<Guid>();
            for(int i = 0; i < 50; i++)
            {
                MaSuperListe.Add(Guid.NewGuid());
            }
        }
    }
}
