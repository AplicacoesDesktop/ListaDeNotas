using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Aluno
    {
        public string Ra { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public float P1 { get; set; }
        public float P2 { get; set; }

        public override string ToString()
        {
            return $"{Ra} - {Nome} - P1 = {P1} - P2 = {P2} ";
        }
    }
}
