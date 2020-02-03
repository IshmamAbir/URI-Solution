 #include<iostream>
using namespace std;

class rectengle{
    int height;
    int  weight;
    public:
    int area();
    int set(int a,int b);
    };
 int rectengle::area(){
        return height*weight;
}
int rectengle::set(int a,int b){
    height= a;
    weight=b;
}
int main()
{
    rectengle obj;
    obj.set(5,6);

    cout<<"area= " << obj.area()<< endl;

    return 0;
}
