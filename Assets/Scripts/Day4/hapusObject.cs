using System.Collections;
using UnityEngine;

public class hapusObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(hapus());
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // IEnumerator hapus()
    // {
    //     yield return new WaitForSeconds(1);
    //     Destroy(gameObject);
    // }
}
