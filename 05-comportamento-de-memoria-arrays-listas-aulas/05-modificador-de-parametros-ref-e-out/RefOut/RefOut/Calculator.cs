﻿namespace RefOut {
    class Calculator {

        public static void TripleRef(ref int x) {
            x *= 3;
        }

        public static void TripleOut(int origin, out int result) {
            result = origin * 3;
        }

    }
}
