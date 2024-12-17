#include <iostream>

// class User
// {
//     public:
//         // const int count = 10;
//         // static int maxId;

//         int id;
//         int age;
//         int level;
// };

// class Unit
// {
//     public:
//         int hp;
//         std::string title;

//         Unit(int hp, const std::string& title):
//             hp{hp},
//             title{title}
//         {}

//         Unit(int hp):
//             Unit{hp, "on_title"}
//         {}
// }

// //int User::maxId = 1;

// int main()
// {
//     // int a{};
//     // std::cout << a;

//     // int b = 3;
//     // int c(4);
//     // int d{5};

//     // User u{};
//     // std::cout << 10;


//     // User a{};
//     // User* b = new User{};

//     // User& c = a;

//     // int a = 4;
//     // int b = 5;
//     // int c;
//     // int d;
//     // d = c = a + b;


//     // for (int item: items)
//     // {

//     // }


//     // int arr[5];
//     // int* arr2 = new int[5];

//     // std::cout << arr2;
//     // std::cout << arr;

//     // std::cout << arr2 + 1;
//     // std::cout << arr + 1;

//     // arr2[2] = 100;      // *(arr2 + 2) = 100
//     // arr[2] = 100;       // *(arr + 2) = 100



//     int** arr = new int*[3];


//     return 0;
// }

// int func()
// {
//     //
//     //
//     return 4;
// }



// class Unit
// {
//     private:
//         int hp;

//     public:
//         Unit(int hp):
//             hp{hp}
//         {}

//         int getHp()
//         {
//             return this->hp;
//         }
//         void setHp(int hp)
//         {
//             this->hp = hp < 0 ? 0 : hp;
//         }
//         bool isFullHp()
//         {
//             return this->hp == 100;
//         }

// };


int mmmaxId;

class User
{
    public:
        static int maxId;
        int id;

        User():
            id{++User::maxId}
        {}

        static void resetMaxId()
        {
            User::maxId = 0;
        }
        void render()
        {
            std::cout << "id" << this->id << '\n';
        }
};

int User::maxId = 0;

int main()
{
    // render();
    mmmaxId = 45;
    // maxId = 34;
    User::maxId = 34;

    User* u = new User{};
    u->render();

    // resetMaxId();
    User::resetMaxId();
}


