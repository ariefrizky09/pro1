using UnityEngine;

public class KMG_CekInput : MonoBehaviour
{

    public GameObject _munculHilang, _tergetHancur, _untukSpawn, _ubahWarna;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tombil spasi ditekan");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tombil O ditekan, object muncul");
            _munculHilang.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombil P ditekan, object hilang");
            _munculHilang.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombil Enter ditekan, object spawn");
            Instantiate(_untukSpawn, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.Euler(0, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject hancurkan = GameObject.FindGameObjectWithTag("sasaran");
            Debug.Log("Tombil M ditekan, object hancur");
            Destroy(_tergetHancur);
            Destroy(hancurkan);
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            SpriteRenderer _localSpriteRenderer = _ubahWarna.GetComponent<SpriteRenderer>();
            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            _localSpriteRenderer.color = warnaAcak;
        }
        
    }
}
