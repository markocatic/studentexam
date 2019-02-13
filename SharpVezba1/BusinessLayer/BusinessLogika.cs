using SharpVezba1.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVezba1.BusinessLayer
{
    class BusinessLogika
    {

        private StudijeEntities entiteti = new StudijeEntities();

        public StudijeEntities Entiteti
        {
            get { return entiteti; }
            set { entiteti = value; }
        }

        public BIspit[] getIspiti(int idPredmet = 0)
        {
            IEnumerable<BIspit> ieIspiti =
                from ispit in this.entiteti.Ispits
                join predmet in this.entiteti.Predmets
                    on ispit.idPredmet equals predmet.idPredmet
                where ((idPredmet == 0) ? true : predmet.idPredmet == idPredmet)
                join ispitniRok in this.entiteti.IspitniRoks
                    on ispit.idIspitniRok equals ispitniRok.idIspitniRok
                orderby ispitniRok.godina, ispit.ispitDatum
                select new BIspit
                {
                    IdIspit = ispit.idIspit,
                    PredmetNaziv = predmet.predmetNaziv,
                    IspitDatum = ispit.ispitDatum,
                    Godina = ispitniRok.godina,
                    IspitniRokNaziv = ispitniRok.ispitniRokNaziv,
                    Popravni = ispitniRok.popravni
                };
            BIspit[] tmpNiz = ieIspiti.ToArray();
            return tmpNiz;
        }

        public BIspit[] getIspitiKoristeSeRelacije()
        {
            IEnumerable<BIspit> ieIspiti =
                from ispit in this.entiteti.Ispits
                orderby ispit.IspitniRok.godina, ispit.ispitDatum
                select new BIspit
                {
                    IdIspit = ispit.idIspit,
                    PredmetNaziv = ispit.Predmet.predmetNaziv,
                    IspitniRokNaziv = ispit.IspitniRok.ispitniRokNaziv,
                    Godina = ispit.IspitniRok.godina,
                    IspitDatum = ispit.ispitDatum,
                    Popravni = ispit.IspitniRok.popravni
                };
            BIspit[] tmpIspiti = ieIspiti.ToArray();
            return tmpIspiti;
        }

        public List<BStudentIspit> getStudentNaIspitu(int idIspit)
        {
            IEnumerable<BStudentIspit> ieStudentIspit =
                from studentIspit in this.entiteti.StudentIspits
                where studentIspit.idIspit == idIspit
                select new BStudentIspit
                {
                    IdStudentIspit = studentIspit.idStudentIspit,
                    IdStudent = studentIspit.idStudent,
                    ImePrezime = studentIspit.Student.imePrezime,
                    BrojIndeksa = studentIspit.Student.indeksCalc,
                    Predmet = studentIspit.Ispit.Predmet.predmetNaziv,
                    Ocena = studentIspit.ocena
                };
            List<BStudentIspit> lista = ieStudentIspit.ToList();
            return lista;
        }
        public BIntString[] getPredmetiInfo()
        {
            IEnumerable<BIntString> iePredmeti =
                 from predmet in this.entiteti.Predmets
                 orderby predmet.predmetNaziv
                 select new BIntString
                 {
                     Id = predmet.idPredmet,
                     Tekst = predmet.predmetNaziv
                 };
            BIntString[] tmpPredmet = iePredmeti.ToArray();
            return tmpPredmet;
        }
        public BStudent[] getStudent()
        {
            IEnumerable<BStudent> ieStudenti =
                from studenti in this.entiteti.Students
                select new BStudent
                {
                    IdStudent = studenti.idStudent,
                    BrojIndeksa = studenti.indeksCalc,
                    ImePrezime = studenti.imePrezime
                };
            BStudent[] tmpStudent = ieStudenti.ToArray();
            return tmpStudent;
        }

        public void dodajStudenta(string ime, string prezime, int brojInd, int godInd)
        {
            try
            {
                int idStudent = 0;
                ObjectParameter idStudentPar = new ObjectParameter("idStudent", typeof(int));
                this.entiteti.StudentInsert(ime, prezime, brojInd, godInd, idStudentPar);
                if(idStudentPar !=null)
                {
                    idStudent = (int)idStudentPar.Value;
                }

            }
            catch(Exception ex)
            {

            }
        }
    }
}
