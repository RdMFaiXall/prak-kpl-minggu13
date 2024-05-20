using modul13_1302220093;
using System;

namespace ProgramUtama
{
    public class Program
    {
        static void Main(string[] args)
        { 
            // deklarasi variabel data1 dan data2 bertipe data PusatDataSingleton
            PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
            PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

            // menambahkan semua nama anggota kelompok dan asprak pada list
            data1.AddSebuahData("Rd. M. Faisal Ramadhan Junaidi");
            data1.AddSebuahData("Cokorda Arturito Revan Putra Diarta");
            data1.AddSebuahData("Faishal Harits Al-Fajri");
            data1.AddSebuahData("Rifqi Alghifari");
            data1.AddSebuahData("Farrel Haykal Giffari");
            data1.AddSebuahData("Riva Dwi Fadhillah Fajri Permana");
            data1.AddSebuahData("NCA");

            // menampilkan data pada classs PusatDataSingleton
            data2.PrintSemuaData();
            Console.WriteLine();

            // menghapus data asprak pada index 6 list
            data2.HapusSebuahData(6);

            // menampilkan data lagi pada class PusatDataSingleton
            data1.PrintSemuaData();
            Console.WriteLine();

            // menampilkan jumlah data pada data1 dan data2
            Console.WriteLine(data1.GetSemuaData().Count());
            Console.WriteLine(data2.GetSemuaData().Count()); 


        }   
    }
}