using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVezba1.BusinessLayer
{
    public abstract class  BusinessDataBase 
    {
    }

    public class BIspit : BusinessDataBase
    {
        public int IdIspit { get; set; }
        public int IdIspitniRok { get; set; }
        public int IdPredmet { get; set; }
        public string PredmetNaziv { get; set; }
        public DateTime? IspitDatum { get; set; }
        public string IspitniRokNaziv { get; set; }
        public bool Popravni { get; set; }
        public int Godina { get; set; }
        
    }

    public class BPredmetInfo : BusinessDataBase
    {
        public int IdPredmet { get; set; }
        public string Predmet { get; set; }
    }

    public class BIntString : BusinessDataBase
    {
        public int Id { get; set; }
        public string Tekst { get; set; }
    }
    public class BStudentIspit : BusinessDataBase
    {
        public int IdStudentIspit { get; set; }
        public int IdStudent { get; set; }
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Predmet { get; set; }
        public int? Ocena { get; set; }
    }
    public class BStudent : BusinessDataBase
    {
        public int IdStudent { get; set; }
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
    }
}
