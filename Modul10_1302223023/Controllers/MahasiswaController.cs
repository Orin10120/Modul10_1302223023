using Microsoft.AspNetCore.Mvc;

namespace Modul10_1302223023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController
    {
        public static List<Mahasiswa> mahasiswaList = new List<Mahasiswa> {
            new Mahasiswa("Rindang bani", "1302223023", ["Rekayasa Perangkat Lunak"], 2022),
            new Mahasiswa("Son Goku", "1302227777", ["Rekayasa Perangkat Lunak", "Teknik Informatika"], 2022),
            new Mahasiswa("Budi", "1302228888", ["Rekayasa Perangkat Lunak",  "Teknik Informatika", "Data Science"], 2022),
            new Mahasiswa("Ahmad", "1302229999", ["Rekayasa Perangkat Lunak",  "Teknik Informatika", "Data Science", "Teknologi Informasi"], 2022),
        };


        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }


        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
           
        }
    }
}
