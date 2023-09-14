//
// Singleton method/pattern
// Disini saya menggunakan C#
// Dan saya mengambil topik ranah ADMIN dalam sebuah sistem informasi
//
using System;


namespace Program{
    // Dibuat sebuah kelas terpisah
    public sealed class ManageUser
    {

        // Membuat constructor contoh
        private ManageUser(){
            // isi dari constructor
        }

        // Dklarasi Instance dari class
        private static ManageUser _instance;

        public static ManageUser GetInstance()
        {

            if (_instance == null)
            {
                _instance = new ManageUser();
            }
            return _instance;

        }

        public void SetUser(){
            // Set User
        }

        public void GetUser(){
            // Get User
        }


    }


    // Class Main
    class Program {

        static void Main(string[] args){

            // Mencoba mempraktekkan jika object dipanggil berulang kali
            ManageUser mUser1 = ManageUser.GetInstance();
            ManageUser mUser2 = ManageUser.GetInstance();

            // Cek apakah jika class ManageUser walaupun dipanggil berkali-kali 
            // tetap berada di instance yang sama
            if (mUser1 == mUser2){
                Console.WriteLine("instance yang tergenerate hanya satu");
            } else {
                Console.WriteLine("instance yang tergenerate lebih dari satu");
            }

            // Mencontohkan fungsionalitas object yang sudah 
            // dibuat menggunakan Singleton method
            mUser1.SetUser();
            mUser2.GetUser();
            
        }

    }
}

// Hint = Cache 


// Tetapi sayangnya...
// Method menyalahi SOLID Principle (Single responsibilty principle)
//