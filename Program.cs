using System;
using System.Collections.Generic;
using System.Linq;
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
        public static int privateKey;
        public static List<int> publickey;

        public int getPrivateKey() { return privateKey; }
        public List<int> getPublickey() { return publickey; }
        public RSA()
        {
            GenerateKey();
        }

        public int Crypt(int toCrypt)
        {
            return PowerModulo(toCrypt, publickey[1], publickey[0]);
        }

        public int Decrypt(int toDecrypt)
        {
            return PowerModulo(toDecrypt, privateKey, publickey[0]);
        }

        public int Decrypt(int toDecrypt, int privateK, int firstPublicKey)
        {
            return PowerModulo(toDecrypt, privateK, firstPublicKey);
        }

        public void GenerateKey()
        {
 
            RSAKey RSAKey = new RSAKey();
            publickey = RSAKey.GetPublicKey();

            privateKey = RSAKey.GetPrivateKey();

        }

        public static int PowerModulo(int M, int e, int mod)
        {
            //Calcul de c = M^e [mod]
            //Fonctionne
            int c = M;
            for (int a = 1; a < e; ++a) 
                c = (M * c) % mod;
            return c;
        }

    }

}

public class RSAKey
{

    /* private static List<int> PrimaryNumbers = new List<int>{
             74891, 361223, 229283, 217829, 486023, 302759,
             440773, 4049, 76379, 68501, 250799, 7009547, 265957, 559673, 210823, 7009603, 291979,
             184997, 387007, 588229, 171427, 290627, 205537, 569809, 318347,
             116993, 499027, 225509,
   }; */
    private static List<int> PrimaryNumbers = new List<int>
    {
       17,19,23,29,31,37,41,43
    };

    private static int Q;
    private static int P;
    private static int N;
    private static int E;
    private static int Phi;

    public RSAKey()
    {
   
        while(P == Q) {
            Q = GetRandomPrimaryNumber();
            P = GetRandomPrimaryNumber();
        }
     
        N = (Q * P);
        Phi = (P - 1) * (Q - 1);
        E = GetEncryptionExponent();


     }

    private static int GetRandomPrimaryNumber()
    {
        return PrimaryNumbers[new Random().Next(0, PrimaryNumbers.Count)];
    }

 

    private static int PGCD(int a, int b)
    {

        int modulo = a % b;
        if (modulo == 0) return b;
        return PGCD(b, modulo);

    }

    private static int GetEncryptionExponent()
    {
        Random rnd = new Random();
        while (true) {
            int e = rnd.Next(0, Phi);
            if ((PGCD(e, Phi) == 1) ) {
                return e;

            }

        }

    }

    public List<int> GetPublicKey()
    {
        return new List<int> { N, E };
    }

    public int GetPrivateKey()
    {
        return modInverse(E, Phi);
    }

    public static int modInverse(int X, int Y)
    { 
        /* RAPPORT :
        *
        * Quel est le projet
        * Qu'avons nous fait
        * Comment on l'a fait
        * Quels sont les problèmes
        * Bien parler de maths
        * Qu'avons-nous réalisé (screen, vidéo, etc.)
        * ---
        * Qu'avons-nous pensé du projet ?
        * Que voulions-nous faire de plus ?
        * ___________________
        * 10min presentation, 5min questions
        */

        List<List<int>> MatriceOperation =  new List<List<int>>();

            int a, b, q, r;

            a = X;
            b = Y;
            r = a % b;
            q = a / b;

            while (true)
            {

                List<int> futureLigne = new List<int>();
                a = b;
                b = r;
                r = a % b;
                q = a / b;
                futureLigne.Add(a);
                futureLigne.Add(q);
                futureLigne.Add(b);
                futureLigne.Add(r);
                MatriceOperation.Add(futureLigne);
                if (r == 0) break;

            }

            int nombreEtape = MatriceOperation.Count();
            int A, B, U, V = 0;

            for (int i = 0; i < nombreEtape - 1; ++i)
            {

                a = MatriceOperation[i][0];
                q = MatriceOperation[i][1];
                b = MatriceOperation[i][2];
                r = MatriceOperation[i][3];
            }

            /*
                     a[i]     q[i]    b[i]    r[i]
            0        1000   =  3  ×   257  +  229
            1        257   =   1  ×   229  +   28
            2        229   =   8  ×    28  +    5
            3        28   =    5  ×     5  +    3
            4        5   =     1  ×     3  +    2
            5        3   =     1  ×     2  +    1
            6        2   =     2  ×     1  +    0
           */

            V = 1;
            A = MatriceOperation[nombreEtape - 2][2];
            U = -(MatriceOperation[nombreEtape - 2][1]);
            B = MatriceOperation[nombreEtape - 2][0];

            int cpt = nombreEtape - 1;
            while (cpt != 1)
            {
                --cpt;

                int tmpV = V;
                int tmpB = B;
                int tmpU = U;

                B = MatriceOperation[cpt - 1][0];
                V = tmpU;
                A = tmpB;
                U = tmpV - (MatriceOperation[cpt - 1][1]) * U;
            }
            if (U < 0) {

                for (int k = 0; U < 0; ++k)
                    U = U + k * B;
            }
            return U;
    }
}
