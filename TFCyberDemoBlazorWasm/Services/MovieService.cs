using TFCyberDemoBlazorWasm.Models;

namespace TFCyberDemoBlazorWasm.Services
{
    public class MovieService
    {
        public List<Film> MaListe { get; set; }

        public MovieService() {
            MaListe = new List<Film>();
        }

        public void Ajouter(Film f)
        {
            
            f.Id = MaListe.Count > 0 ? MaListe.Max(a => a.Id) + 1 : 1;
            MaListe.Add(f);
        }
    }
}
