#include <iostream>
#include <vector>
using namespace std;



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
 int Bezout(int X, int Y){
    vector<vector<int>> MatriceOperation;
    int a,b,q,r;

    a = X;
    b = Y;
    r = a % b;
    q = a / b;

    while(true){

        vector<int> futureLigne;
        a = b;
        b = r;
        r = a % b;
        q = a / b;
        futureLigne.push_back(a);
        futureLigne.push_back(q);
        futureLigne.push_back(b);
        futureLigne.push_back(r);
        MatriceOperation.push_back(futureLigne);
        if(r == 0) break;

     }

    int nombreEtape = MatriceOperation.size();
    int A,B,U,V= 0;

    for(unsigned i(0); i < nombreEtape -1 ; ++i){

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
     A = MatriceOperation[nombreEtape -2][2];
     U = -(MatriceOperation[nombreEtape -2][1]);
     B = MatriceOperation[nombreEtape -2][0];

     unsigned cpt = nombreEtape - 1;
     while(cpt != 1){
         --cpt;

             int tmpV = V;
             int tmpB = B;
             int tmpU = U;

             B = MatriceOperation[cpt - 1][0];
             V = tmpU;
             A = tmpB;
             U = tmpV  - (MatriceOperation[cpt - 1][1]) * U;
        }
    if(U < 0){

        for(unsigned k(1); U < 0; ++k)
            U = U + k * B;
    }

    return U;

}

int main()
{
    int X = 1000;
    int Y = 257;

     cout << Bezout(X, Y);

    return 0;
}
