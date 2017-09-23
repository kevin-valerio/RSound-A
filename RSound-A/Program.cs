using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSound_A
{
    static class Program
    {
 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrimaryForm());
        }
    }
}


namespace Encryption
{
    public class RSA
    {
        public RSA()
        {
            /* Git test */
        }

        public void GenerateKey()
        {

        }

        private static int Exposant(int M, int c)
        {
            // M^c
            while (true) {

            }
        }
    }



    public class RSAKeys
    {

        private static List<long> PrimaryNumbers = new List<long>{
            7009421, 7009427, 7009447, 7009469, 7009477, 7009481,
            7009487, 7009493, 7009507, 7009517, 7009543, 7009547, 7009553, 7009577, 7009601, 7009603, 7009609,
            7009663, 7009669, 7009699, 7009711, 7009757, 7009771, 7009777, 7009799, 7009801, 7009823, 7009859,
            7009867, 7009889, 7009897, 7009921, 7009969, 7009979, 7009991, 7009997, 7010011, 7010021, 7010023,
            7010033, 7010041, 7010051, 7010089, 7010099, 7010111, 7010119, 7010197, 7010209, 7010219, 7010231,
            7010281, 7010291, 7010293, 7010317, 7010323, 7010329, 7010347, 7010351, 7010357, 7010359, 7010417,
            7010447, 7010453, 7010459, 7010483, 7010491, 7010503, 7010513, 7010537, 7010543, 7010551, 7010569,
            7010573, 7010581, 7010603, 7010621, 7010651, 7010657, 7010659, 7010671, 7010687, 7010693, 7010719,
            7010789, 7010803, 7010821, 7010831, 7010833, 7010863, 7010879, 7010891, 7010909, 7010917, 7010921,
            7010923, 7010951, 7010957, 7010963, 7010977, 7011001, 7011023, 7011031, 7011049, 7011073, 7011079
        };


        private static long Q;
        private static long P;
        private static long N;
        private static long E;

        private static long GetRandomPrimaryNumber()
        {
            return PrimaryNumbers[new Random().Next(0, PrimaryNumbers.Count)];
        }

        private static long GetEulerIndicator()
        {
            return (P - 1) * (Q - 1);
        }

        private static long PGCD(long a, long b)
        {
            long modulo = a % b;
            if (modulo == 0) return b;
            return PGCD(b, modulo);
        }

        private static long GetEncryptionExponent()
        {

            Random rnd = new Random();
            while (true) {
                long e = rnd.Next();
                if ((PGCD(e, GetEulerIndicator()) == 1) && (e < GetEulerIndicator()))
                    return e;
            }

        }

        public static List<long> GetPublicKey()
        {
            Q = GetRandomPrimaryNumber();
            P = GetRandomPrimaryNumber();
            N = (Q * P);
            E = GetEncryptionExponent();

            return new List<long> {N, E};
        }

        public static long GetPrivateKey()
        {
            return 1;   
        }

        

        private static long GetDecryptionExponent()
        {
            //calculer l'entier naturel d, inverse de e modulo φ(n), et strictement inférieur à φ(n), 
            //appelé exposant de déchiffrement ; d peut se calculer efficacement par l'algorithme d'Euclide étendu.

            return 1;
        }

    }
}