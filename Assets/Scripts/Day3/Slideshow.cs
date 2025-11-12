using UnityEngine.UI;
using UnityEngine;

public class Slideshow : MonoBehaviour
{
    public DataBaseGambar databaseGambar;
    public Image objectImage;
    public int index;
    public void Next()
    {
        if (index >= databaseGambar.ListGambar.Count - 1)
        {
            index = 0;
        }
        else
        {
            index = index + 1;
        }
        objectImage.sprite = databaseGambar.ListGambar[index];
    }
    public void Prev()
    {
        if (index <= 0)
        {
            index = databaseGambar.ListGambar.Count - 1;
        } else

            {
            index = index - 1;
        }        
        objectImage.sprite = databaseGambar.ListGambar[index];
    }
}
