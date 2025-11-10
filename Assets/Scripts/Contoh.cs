using UnityEngine;

public class Contoh : MonoBehaviour
{

    int nyawa = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("ini fungtion Tambah " + Tambah(10, 9, 0));
        Debug.Log("ini fungtion Poition");
        Poition();
        Debug.Log("Nyawa sekarang " + nyawa);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Poition()
    {
        Debug.Log("Player use poition");
        Heal(30);
    }

    public void Heal(int tambahanNyawa)
    {
        nyawa = nyawa + tambahanNyawa;
    }
    
    public int Tambah(int ang1, int ang2, int ang3)
    {
        int result = ang1 * ang2 * ang3;
        return result;
    }
}
