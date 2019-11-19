using System;
using System.Collections.Generic;
using System.Text;

namespace ResultadoAlunos
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
                return true;
            return false;
        }

        public double PontosNecessarios()
        {
            if(Aprovado())
                return 0;
            return 60 - NotaFinal();
        }
    }
}
