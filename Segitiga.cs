//13. Menentukan jenis segitiga berdasarkan input user
using System;

class Segitiga{
    public static string KlasifikasiSegitiga(int sisiA, int sisiB, int sisiC){
        if (sisiA == sisiB && sisiB == sisiC){
            return "Segitiga Sama Sisi";
        } else if (sisiA == sisiB || sisiA == sisiC || sisiB == sisiC){
            return "Segitiga Sama Kaki";
        } else {
            return "Segitiga Sembarang";
        }
    }

    static void Main(){
        Console.WriteLine ("===Menentukan jenis segitiga===");
        Console.Write("Masukkan panjang sisi A: ");
        int sisiA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan panjang sisi B: ");
        int sisiB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan panjang sisi C: ");
        int sisiC = Convert.ToInt32(Console.ReadLine());
       
        string jenisSegitiga = KlasifikasiSegitiga(sisiA, sisiB, sisiC);

        Console.WriteLine($"Berdasarkan panjang sisinya, segitiga tersebut adalah {jenisSegitiga}");
    }
}