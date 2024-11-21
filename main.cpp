#include <iostream>

class User
{
    public:
        // const int count = 10;
        // static int maxId;

        int id;
        int age;
        int level;
};

//int User::maxId = 1;

int main()
{
    // int a{};
    // std::cout << a;

    // int b = 3;
    // int c(4);
    // int d{5};

    // User u{};
    // std::cout << 10;


    User a{};
    User* b = new User{};

    User& c = a;


    return 0;
}