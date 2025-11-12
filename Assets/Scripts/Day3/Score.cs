using UnityEngine;

public class Score : MonoBehaviour
{
    public PendeteksiInput objectPendeteksiInput;

    public int score;

    private void OnEnable()
    {
        //listen
        // objectPendeteksiInput.inputEvent += AddScore;
    }

    public void AddScore()
    {
        score = score + 1;
    }

    private void OnDisable()
    {
        //unlisten
        // objectPendeteksiInput.inputEvent -= AddScore;
    }
}
