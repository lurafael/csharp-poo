namespace CotacaoDolar {
    class ConversorDeMoeda {

        public static double Iof = 6.0;
        public static double Conversao(double cotacao, double quantia) {
            double total = quantia * cotacao;
            return total + (total * Iof / 100);
        }
    }
}
