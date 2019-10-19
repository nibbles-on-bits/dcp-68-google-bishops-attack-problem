using System;

namespace dcp_68_google_bishops_attack_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] test1 = new int[,] {{0,0},{1,2},{2,2},{4,0}};
            Console.WriteLine("test1 ---> " + Bishops.CountBishopAttacks(test1));
        }
    }

    class Bishops
    {
        public static void Test() {
            Console.WriteLine("Test");
        }

        public static int CountBishopAttacks(int[,] bishopPositions) {
            int ret = 0;

            int[] b1Pos = new int[2], b2Pos = new int[2];
            for (int i = 0; i < (bishopPositions.Length/2-1); i++) {
                b1Pos[0] = bishopPositions[i, 0];
                b1Pos[1] = bishopPositions[i, 1];
                for (int j = i + 1; j < bishopPositions.Length/2; j++) {
                    b2Pos[0] = bishopPositions[j, 0];
                    b2Pos[1] = bishopPositions[j, 1];
                    if (BishopsAttack(b1Pos,b2Pos)) {
                        ret++;
                    }
                }    
            }


            return ret;
        }

        public static bool BishopsAttack(int[] bishop1Pos, int[] bishop2Pos) {
            if (Math.Abs(bishop1Pos[0]-bishop2Pos[0]) == Math.Abs(bishop1Pos[1]-bishop2Pos[1])) {
                return true;
            }
            return false;
        }

    }
}
