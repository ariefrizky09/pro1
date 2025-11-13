using UnityEngine;

public class BolaJahat : MonoBehaviour
{

     public InteraksiButton12 interaksiButton12; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interaksiButton12.nyawa = 10;
        KurangNyawa();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("kotakjahat"))
        {
            Debug.Log("Nyawa -1");
            //berfungsi untuk menambahkan skor serta memanggil fungsi TambahSkor
            interaksiButton12.nyawa-= 1;
            KurangNyawa();
        }

    }
    
    public void KurangNyawa()
    {
        interaksiButton12.TeksNyawa.text = "Nyawa : " + interaksiButton12.nyawa.ToString();
    }
}
