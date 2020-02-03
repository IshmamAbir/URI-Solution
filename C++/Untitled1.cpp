#include<iostream>
using namespace std;
class BMW_wheel
{
private:
    float radious;
public:
    BMW_wheel():radious(12){}
    void wheel_spin(double distance)
    {
        double pi=3.1416;
        int spin=distance/2*pi*radious;
        cout<<"Number of spin  "<<spin<<endl;
    }

};
int main()
{
    double d;
    BMW_wheel w1;
    cout<<"Give distance  ";cin>>d;
    w1.wheel_spin(d);
}
