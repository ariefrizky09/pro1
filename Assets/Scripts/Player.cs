using UnityEngine;

[System.Serializable]
public class Player
{
    public string name;
    public int lvl;
    public int health;

    public Player(string nama, int level, int Health)
    {
        name = nama;
        lvl = level;
        health = Health;
    }
}
