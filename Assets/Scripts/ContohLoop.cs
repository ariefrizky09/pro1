using UnityEngine;

public class ContohLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int ang = 4;
        int hasil = 1;

        for (int i = ang; i > 0; i--)
        {
            hasil *= i;
            Debug.Log("Faktorial ke- " + i);
        }
        Debug.Log("Faktorial dari " + ang + " = " + hasil);

        for (int i = 1; i <= 5; i++)
{
    string baris = "";
    for (int j = 1; j <= i; j++)
    {
        baris += "*";
    }
    Debug.Log(baris);
}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
