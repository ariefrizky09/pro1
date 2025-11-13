using UnityEngine;

public class SquareMoveButton : MonoBehaviour
{
    //ini merupakan deklarasi untuk memanggil enumerator berfungsi untuk mengatur arah gerak square
    public ArahGerak arahGerak = ArahGerak.kanan;
    //ini adalah deklarasi referensi gameobject dengan tipe data class InteraksiButton12
    //ini gunakan untuk bisa berkomunikasi dengan gameobject yang memiliki class InteraksiButton12
    //setelah deklarasi ini, harus assign gameobject dari hierarchy ke inspectornya
    public InteraksiButton12 interaksiButton12; 
    //ini adalah deklarasi variabel dengan tipe data float digunakan untuk menentukan kecepatan gerakan square
    public float kecepatan = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ini merupakan percabangan untuk menentukan arah gerak dari square
        //arah gerakan ditentukan dengan translate
        //variabel deklarasi arahGerak diambil dari enumerator
        switch (arahGerak)
        {
            case ArahGerak.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;

        }
    }
    //merupakan sebuah fungsi untuk mendeteksi tabrakan square dengan dinding dengan nama tag dinding
    //jika gameobject menabrak dinding sesuai dengan ketentuan arah, maka object akan berbalik ke arah yang berlawanan
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("dinding"))
        {
            Debug.Log("kotak tabrak dinding");
            if (arahGerak == ArahGerak.atas)
            {
                arahGerak = ArahGerak.bawah;
            }
            else if (arahGerak == ArahGerak.bawah)
            {
                arahGerak = ArahGerak.atas;
            }
            else if (arahGerak == ArahGerak.kanan)
            {
                arahGerak = ArahGerak.kiri;
            }
            else
            {
                arahGerak = ArahGerak.kanan;
            }
            //berfungsi untuk menambahkan skor serta memanggil fungsi TambahSkor
            interaksiButton12.skor++;
            TambahSkor();
        }

    }
    //merupakan sebuah fungsi dengan nama TambahSkor digunakan untuk mengubah text skor
    //memanggil variabel dari code interaksiButton12 dengan variabel TeksSkor dan mengubahnya menjadi string
    public void TambahSkor()
    {
        interaksiButton12.TeksSkor.text = "Skor : " + interaksiButton12.skor.ToString();
    }

}

//pendeklarasian sebuah enumerator dengan nama ArahGerak
//isi enumeratornya adalah atas, bawah, kiri, kanan

public enum ArahGerak

{
    atas,
    bawah,
    kiri,
    kanan

}
