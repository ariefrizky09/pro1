using TMPro;
using UnityEngine;

public class InteraksiButton12 : MonoBehaviour
{
    public SquareMoveButton squareMoveButton;
    public int skor;
    public TMP_Text TeksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
