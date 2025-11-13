using TMPro;
using UnityEngine;

public class ManagerNov13 : MonoBehaviour
{
    public int skor;
    public TMP_Text teksSkor, teksKet;
    public SquareMoveMouse squareMoveMouse;
    public GameObject BolaJatuh;
    public PemainLompat pemainLompat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateTeksSkor();
         teksKet.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Kklik kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("Posisi mouse ada di " + vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
            squareMoveMouse.isMoveRight = false;
            teksKet.text = "Kiri";
            //MunculDariAtas();
            pemainLompat.lompat();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Kklik kanan");
            KurangSkor();
            UpdateTeksSkor();
            squareMoveMouse.isMoveRight = true;
            teksKet.text = "Kanan";
        }
       
    }

    void TambahSkor()
    {
        skor++;
        Debug.Log("skor nambah 1");
    }
    void KurangSkor()
    {
        skor--;
        Debug.Log("skor kurang 1");
    }
    void UpdateTeksSkor()
    {
        teksSkor.text = skor.ToString();
        Debug.Log("skor diubah");
    }

    // void ToggleKiriKanan()
    // {
    //     if (squareMoveMouse.isMoveRight)
    //     {
    //         squareMoveMouse.isMoveRight = false;
    //         teksKet.text = "Kanan";
    //     } else
    //     {
    //         squareMoveMouse.isMoveRight = true;
    //         teksKet.text = "Kiri";
    //     }
    // }

    void MunculDariAtas()
    {
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition); //mengambil posisi cursor
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3 (0, Screen.height, 0)); //mengambil titik paling atas layar
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0); //menggunakan posisi kursor sumbu x dan y titk paling atas layar

        Instantiate(BolaJatuh, tempatJatuh, Quaternion.identity); //memunculkan object di posisi tempat jatuh dengan rotasi quarternion.identity
    }
}
