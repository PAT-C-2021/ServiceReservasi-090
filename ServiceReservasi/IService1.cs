using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Login(string username, string password);

        [OperationContract]
        string Register(string username, string password, string kategori);

        [OperationContract]
        string UpdateRegister(string username, string password, string kategori, int id);

        [OperationContract]
        string DeleteRegister(string username);

        [OperationContract]
        List<DataRegister> DataRegist();

        [OperationContract]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi);//method proses input data

        [OperationContract]
        string editPemesanan(string IDPemesanan, string NamaCustomer, string No_telpon);

        [OperationContract]
        string deletePemesanan(string IDPemesanan);

        [OperationContract]
        List<CekLokasi> ReviewLokasi(); //nampilin data yang ada di database (select all) menampilkan isi dari yang ada contract

        [OperationContract]
        List<DetailLokasi> DetailLokasi();

        [OperationContract]
        List<Pemesanan> Pemesanan();
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    [DataContract]
    public class DataRegister
    {
        [DataMember(Order = 1)]
        public int id { get; set; }

        [DataMember(Order = 2)]
        public string username { get; set; }

        [DataMember(Order = 3)]
        public string password { get; set; }

        [DataMember(Order = 4)]
        public string kategori { get; set; }
    }


    [DataContract]
    public class CekLokasi //daftar lokasi nongrong
    {
        [DataMember]
        public string IDLokasi { get; set; } //variable dari public class

        [DataMember]
        public string NamaLokasi { get; set; }

        [DataMember]
        public string DeskripsiSingkat { get; set; }
    }

    [DataContract]
    public class DetailLokasi //menampilkan detail lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; } //variable dari public class

        [DataMember]
        public string NamaLokasi { get; set; }

        [DataMember]
        public string DeskripsiFull { get; set; }

        [DataMember]
        public int Kouta { get; set; }
    }


    [DataContract]
    public class Pemesanan //crate
    {
        [DataMember]
        public string IDPemesanan { get; set; } //variable dari public class

        [DataMember]
        public string NamaCustomer { get; set; } // method

        [DataMember]
        public string NoTelepon { get; set; }

        [DataMember]
        public int JumlahPemesanan { get; set; }

        [DataMember]
        public string Lokasi { get; set; }
    }
}

