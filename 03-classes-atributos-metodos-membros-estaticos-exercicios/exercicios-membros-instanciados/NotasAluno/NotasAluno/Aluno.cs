using System;

namespace NotasAluno {
    class Aluno {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;

        public double NotaFinal() {
            return NotaA + NotaB + NotaC;
        }

        public bool VerificaAprovacao() {
            return NotaFinal() >= 60.00;
        }

        public double FaltamQuantosPontos() {
            return 60.00 - NotaFinal();
        }
    }
}
