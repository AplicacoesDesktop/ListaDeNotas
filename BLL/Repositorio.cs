using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio
    {
        public List<Aluno> Alunos { get; set; } = new List<Aluno>() { };

        public void Incluir (Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void Remover(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }


    }
}
