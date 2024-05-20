using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul13_1302220093
{
    // Deklarasi class bernama PusatDataSingleton
    public class PusatDataSingleton
    {
        // deklarasi variabel
        private List<String> DataTersimpan;
        private static PusatDataSingleton _instance;

        // deklarasi constructor untuk DataTersimpan
        private PusatDataSingleton()
        {
            DataTersimpan = new List<String>();
        }

        // deklarasi method PusatDataSingleton untuk mengambil data Class PusatDataSingletin
        public static PusatDataSingleton GetDataSingleton() { 
            if (_instance == null)
            {
                _instance = new PusatDataSingleton();
            }
            return _instance;
        }


        // deklarasi method yang mengembalikan tipe List String untuk mengambil semua Data variabel DataTersimpan
        public List<String> GetSemuaData()
        {
            return DataTersimpan;
        }

        // deklarasi method PrintSemuaData untuk menampilkan semua DataTersimpan pada console
        public void PrintSemuaData()
        {
            for (int i = 0; i < DataTersimpan.Count; i++)
            {
                Console.WriteLine(DataTersimpan[i]);
            }
        }

        // deklarasi method AddSebuahData untuk menambahkan data baru pada list DataTersimpan
        public void AddSebuahData(String Input)
        {
            DataTersimpan.Add(Input);
        }

        // deklarasi method HapusSebuahData untuk menghapus data berdasarkan lokasi index
        public void HapusSebuahData(int index)
        {
            DataTersimpan.RemoveAt(index);
        }

    }
}
