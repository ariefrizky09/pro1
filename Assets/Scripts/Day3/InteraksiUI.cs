
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraksiUI : MonoBehaviour
{
    public SquareMove12 squareMove12;
    public GameObject SquareUbahWarna;
    public TMP_Text KataBerubah;
    public TMP_Text NamaBerubah;
    public List<string> daftarNama;
    public int idNama = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NamaBerubah.text = daftarNama[idNama];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UbahKataKiri()
    {
        string kata = "Kiri";
        KataBerubah.text = kata;
    }

    public void UbahKataKanan()
    {
        string kata = "Kanan";
        KataBerubah.text = kata;
    }

    public void LanjutNama()
    {
        if (idNama < daftarNama.Count - 1)
        {
            idNama++;
        }
        else
        {
            idNama = 0;
        }
        NamaBerubah.text = daftarNama[idNama];
    }

    public void KembaliNama()
    {
        if (idNama <= 0)
        {
            idNama = daftarNama.Count - 1;
        }
        else
        {
            idNama--;
        }
        NamaBerubah.text = daftarNama[idNama];
    }

    public void UbahWarna(Color warna)
    {
        SpriteRenderer sr = SquareUbahWarna.GetComponent<SpriteRenderer>();
        sr.color = warna;
    }

    public void UbahWarnaMerah()
    {
        UbahWarna(Color.red);
    }

    public void UbahWarnaBiru()
    {
        UbahWarna(Color.blue);
    }

    public void UbahWarnaHijau()
    {
        UbahWarna(Color.green);
    }

    public void UbahWarnaRandom()
    {
        Color col = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        UbahWarna(col);
    }

    public void mulai()
    {
        squareMove12.isMove = true;
    }

    public void berhenti()
    {
        squareMove12.isMove = false;
    }
    public void gerakKanan()
    {
        squareMove12.isMoveRight = true;
    }
    public void gerakKiri()
    {
        squareMove12.isMoveRight = false;
    }
    
}
