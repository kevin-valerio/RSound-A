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
        public static int privateKey;
        public static List<int> publickey;

        public RSA()
        {
           // GenerateKey();
        }

        public int Crypt(int toCrypt)
        {
            return PowerModulo(toCrypt, publickey[1], publickey[0]);
        }

        public int Decrypt(int toDecrypt)
        {
            return PowerModulo(toDecrypt, privateKey, publickey[0]);
        }

        public void GenerateKey()
        {
 
            RSAKey PublicRSAKey = new RSAKey();
            publickey = PublicRSAKey.GetPublicKey();

            RSAKey PrivateKey = new RSAKey();
            privateKey = PublicRSAKey.GetPrivateKey();

        }

        public static int PowerModulo(int M, int e, int mod)
        {
            //Calcul de c = M^e [mod]
            int c = M;
            for (int a = 1; a < e; ++a) 
                c = (M * c) % mod;
            return c;
        }

    }

}

public class RSAKey
{

    private static List<int> PrimaryNumbers = new List<int>{
            74891, 361223, 229283, 217829, 486023, 302759,
            440773, 4049, 76379, 68501, 250799, 7009547, 265957, 559673, 210823, 7009603, 291979,
            184997, 387007, 588229, 171427, 290627, 205537, 569809, 318347,
            116993, 499027, 225509,
  };


    private static int Q;
    private static int P;
    private static int N;
    private static int E;
    private static int Phi;

    public RSAKey()
    {
 
        Q = GetRandomPrimaryNumber();
        P = GetRandomPrimaryNumber();
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
        
       // return (a%b==0) ? b : (PGCD(b, a%b));
    }

    private static int GetEncryptionExponent()
    {

        Random rnd = new Random();
        while (true) {
            int e = rnd.Next(0, 100);
             //MessageBox.Show(Phi.ToString());

            if ((PGCD(e, ((P - 1) * (Q - 1))) == 1) && (e < Phi)) {
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
        return GetDecryptionExponent();
    }



    private static int GetDecryptionExponent()
    {
        //calculer l'entier naturel d, inverse de e modulo φ(n), et strictement inférieur à φ(n), 
        //appelé exposant de déchiffrement ; d peut se calculer efficacement par l'algorithme d'Euclide étendu.
        //return d * e congrue 1 mod phi(n)

        return modInverse(E, Phi);

    }


    private static int modInverse(int a, int n)
    {
        //Marche pas
        int i = n, v = 0, d = 1;
        while (a > 0) {
            int t = i / a, x = a;
            a = i % x;
            i = x;
            x = d;
            d = v - t * x;
            v = x;
        }
        v %= n;
        if (v < 0) v = (v + n) % n;
        return v;
    }
}
