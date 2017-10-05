#include <iostream>
#include <vector>
using namespace std;

void afficheMatrice(vector<vector<int>> MatriceOperation){

    for(int x=0;x<MatriceOperation.size();x++) {
         for(int y=0;y<MatriceOperation[x].size();y++)
             cout << MatriceOperation[x][y] << "    ";
         cout << endl;
     }
}

 void Bezout(int X, int Y){
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
        // cout << a << " = " << q << "×" << b << " + " << r << endl;
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

     U = 1;
     B = MatriceOperation[nombreEtape -2][2];
     V = -(MatriceOperation[nombreEtape -2][1]);
     A = MatriceOperation[nombreEtape -2][0];

     int cpt = nombreEtape - 1;

     while( B != X && A != Y ){

        --cpt;

        int tmpU = U;
        int tmpA = A;
        int tmpV = V;

        A = MatriceOperation[cpt - 1][0];
        U = tmpV;
        B = tmpA;
        V = tmpU  - (MatriceOperation[cpt - 1][1]) * tmpV;

     }
     cout << "U = " << U << endl << endl <<  "B = " << B << " V =  " << V << " A = " << A<< endl;
}

int main()
{
    int X = 257;
    int Y = 1000;

     Bezout(X, Y);
    //Doit afficher 393

    return 0;
}
