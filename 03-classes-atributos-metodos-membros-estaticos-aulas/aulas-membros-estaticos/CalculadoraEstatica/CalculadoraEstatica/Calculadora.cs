
//Quando é declarada uma classe com atributos e métodos estáticos, não se instancia para uma variável
//para usar seus atributos e métodos, é só chamar a classe direto e qualquer um de seus membros
//estáticos. Basta colocar a palavra chave static neles.

namespace CalculadoraEstatica {
    class Calculadora {
        public static double Pi = 3.14;

        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
