using UnityEngine;

public class PemainLompat : MonoBehaviour
{
    public bool diLantai;
    public float forceMultiplier = 7.0f; //variabel untuk 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void lompat()
    {
        if (diLantai)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        } else
        {
            Debug.Log("Lagi lompat");
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("lantai"))
        {
            diLantai = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("lantai"))
        {
            diLantai = false;
        }
    }
}
