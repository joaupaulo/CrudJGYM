using AcademiaJGYM.Contexto;
using AcademiaJGYM.Models;
using AcademiaJGYM.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaJGYM.Service
{
    public class Alunorepo : IAluno
    {

        private readonly AlunoModelContext _aluno;
        public Alunorepo(AlunoModelContext aluno)
        {

            _aluno = aluno;

        }



        public void Delete(Aluno aluno)
        {
            _aluno.Aluno.Remove(aluno);
        }

        public List<Aluno> GetAll()
        {
            return _aluno.Aluno.ToList();
        }

        public Aluno GetById(int Id)
        {
            return _aluno.Aluno.Find(Id);
        }

        public void Insert(Aluno aluno)
        {
             _aluno.Aluno.Add(aluno);
        }

        public void Save()
        {
            _aluno.SaveChanges();
        }

        public void Update(Aluno aluno)
        {
            _aluno.Aluno.Update(aluno);
        }
    }
}
