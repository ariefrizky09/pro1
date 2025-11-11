using UnityEngine;

public class warna : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Color _warna;

        ColorUtility.TryParseHtmlString("#75ffe1ff", out _warna);
        _spriteRenderer.color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
