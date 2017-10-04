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

void Bezout(float X, float Y){

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
    int A,B,U,V;

    for(unsigned i(0); i < nombreEtape -1 ; ++i){

        a = MatriceOperation[i][0];
        q = MatriceOperation[i][1];
        b = MatriceOperation[i][2];
        r = MatriceOperation[i][3];
        // cout << a << " = " << q << "×" << b << " + " << r << endl;
    }

     /*
             a[i]     q[i]    b[i]    r[i]
             1000   =  3  ×   257  +  229
             257   =   1  ×   229  +   28
             229   =   8  ×    28  +    5
             28   =    5  ×     5  +    3
             5   =    q 1  ×     3  +    2
             3   =     1  ×     2  +    1

    */

     U = 1;
     B = MatriceOperation[nombreEtape -1][2];
     A = MatriceOperation[nombreEtape -1][0];
     V = -(MatriceOperation[nombreEtape -1][1]) ;

     int cpt = 0;

     while(A != X && B != Y){
        int tmp = U;

        ++cpt;
        A = MatriceOperation[cpt-1][0];
        U = V;
        B = A;
        V = tmp - (MatriceOperation[cpt-1][1]) * V;


     }
     cout << U << " " << B << " " << V << " " << A;
}

int main()
{
    float X = 257;
    float Y = 1000;

     Bezout(X, Y);
    //Doit afficher 393

    return 0;
}
