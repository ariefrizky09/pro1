using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataBaseGambar", menuName = "Database/List Gambar")]
public class DataBaseGambar : ScriptableObject
{
    public List<Sprite> ListGambar = new List<Sprite>();
}
