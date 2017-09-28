#include <iostream>
#include <vector>
using namespace std;

void afficheMatrice(vector<vector<int>> MatriceOperation){

    for(int x=0;x<MatriceOperation.size();x++)
     {
         for(int y=0;y<MatriceOperation[x].size();y++)
         {
             cout << MatriceOperation[x][y] << "    ";
         }
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

   // afficheMatrice(MatriceOperation);

    int nombreEtape = MatriceOperation.size();

    for(unsigned i(nombreEtape); i > 0; --i){
        a = MatriceOperation[i-1][0];
        q = MatriceOperation[i-1][1];
        b = MatriceOperation[i-1][2];
        r = MatriceOperation[i-1][3];
    }
}

int main()
{
    float X = 257;
    float Y = 1000;

     Bezout(X, Y);
    //Doit afficher 393

    return 0;
}
