
namespace Class72Params {
    internal class Calculator {

        public static double Sum(params double[] nums) {
            double soma = 0;
            for (int i = 0; i < nums.Length; i++) {
                soma += nums[i];
            }
            return soma;
        }

        public static void Duple(int origin, out int result) {
            result = origin * 2;
        }

        public static void Triple(ref double x) {
            x *= 3;
        }

    }
}
