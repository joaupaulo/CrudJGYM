using AcademiaJGYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaJGYM.Repositorios
{
   public interface IAluno
    {

        List<Aluno> GetAll();
        Aluno GetById(int Id);

        void Insert(Aluno aluno);
        void Update(Aluno aluno);
        void Delete(Aluno aluno);
        void Save();



    }
}
