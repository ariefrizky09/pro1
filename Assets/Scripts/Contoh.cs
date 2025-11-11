using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class Contoh : MonoBehaviour
{
    [SerializeField]
    // Player player, player2, player3;
    // Player[] ArrayPlayer;
    List<Player> ListPlayer = new List<Player>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player newPlayer = new Player("d", 24, 240);
        ListPlayer.Add(newPlayer);
        Player player = ListPlayer.Find(element => element.lvl > 15);
        Debug.Log(player.name);
        bool isExist = ListPlayer.Exists(element => element.name == "a");
        Debug.Log(isExist);

        // for (int index = 0; index < ArrayPlayer.Length; index++)
        // {
        //     Debug.Log(ArrayPlayer[index].name);
        // }

        // foreach (Player player in ArrayPlayer)
        // {
        //     Debug.Log(player.name);
        //     Debug.Log(player.lvl);
        //     Debug.Log(player.health);
        // }

        // Debug.Log(ArrayPlayer.Length);
        // Debug.Log(player.name);
        // Debug.Log(player.lvl);
        // Debug.Log(player.health);
        // Debug.Log("");
        // Debug.Log(player2.name);
        // Debug.Log(player2.lvl);
        // Debug.Log(player2.health);
        // Debug.Log("");
        // Debug.Log(player3.name);
        // Debug.Log(player3.lvl);
        // Debug.Log(player3.health);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // public void Poition()
    // {
    //     Debug.Log("Player use poition");
    //     Heal(30);
    // }

    // public void Heal(int tambahanNyawa)
    // {
    //     nyawa = nyawa + tambahanNyawa;
    // }
    
    // public int Tambah(int ang1, int ang2, int ang3)
    // {
    //     int result = ang1 * ang2 * ang3;
    //     return result;
    // }
}
