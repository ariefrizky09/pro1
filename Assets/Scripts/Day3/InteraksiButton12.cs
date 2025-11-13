using TMPro;
using UnityEngine;

public class InteraksiButton12 : MonoBehaviour
{
    //memanggil code dengan nama SquareMoveButton dengan variabel SquareMoveButton
    public SquareMoveButton squareMoveButton;
    //variabel skor dengan tipe data int untuk menyimpan data skor
    public int skor;
    //variabel TeksSkor dengan tipedata TMP_Text untuk mengubah nilai skor dari angka menjadi string
    public int nyawa;
    public TMP_Text TeksSkor;
    public TMP_Text TeksNyawa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //sebuah fungsi berfungsi untuk menentukan arah gerak square seruai dengan tombol yang ditekan
    //dipanggil dari code SquareMoveButton dengan enumerator ArahGerak dan variabel arahGerak
    //kode ini akan dipanggil di inspektor unity disandingkan dengan tombolnya lansung
    public void GerakAtas()
    {
        squareMoveButton.arahGerak = ArahGerak.atas;
    }
    public void GerakBawah()
    {
squareMoveButton.arahGerak = ArahGerak.bawah;
    }
    public void GerakKiri()
    {
squareMoveButton.arahGerak = ArahGerak.kiri;
    }
    public void GerakKanan()
    {
        squareMoveButton.arahGerak = ArahGerak.kanan;
    }
}
