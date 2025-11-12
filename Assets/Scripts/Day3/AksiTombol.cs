
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AksiTombol : MonoBehaviour
{
    //Sprite adalah aset gambar yang ingin dimasukkan ke object image
    public Sprite assetGambar;
    // image adalah component dari object image yang ada di dalam scene
    public Image image;
    // ubah text ketika klik
    public TMP_Text objectText;
    public void Aksi()
    {
        image.sprite = assetGambar;
        objectText.text = "Aduh aduh aduh";
        Debug.Log("Tombol diklik!");

        // SceneManager.LoadScene("Day3 SceneBaru");
    }
}
