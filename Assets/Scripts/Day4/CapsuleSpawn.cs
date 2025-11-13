using System.Collections;
using UnityEngine;

public class CapsuleSpawn : MonoBehaviour
{
    public GameObject spawnObject;
    public bool sedangSpawn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(MunculkanObject());
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    IEnumerator MunculkanObject()
    {
        while(sedangSpawn == true)
        {
            //spawn object
            Instantiate(spawnObject, new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
}
