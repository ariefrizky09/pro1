using UnityEngine;

public class HexaBesar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += new Vector3(5, 2, 6) * Time.deltaTime;
    }
}
