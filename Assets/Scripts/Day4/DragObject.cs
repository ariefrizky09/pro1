using UnityEngine;

public class DragObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // void OnMouseEnter()
    // {
    //     Debug.Log("enter");
    // }
    // void OnMouseDown()
    // {
    //     Debug.Log("down");

    // }
    void OnMouseDrag()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //untuk mengatur posisi
        Vector2 squarePosition = new Vector2(worldMousePosition.x, worldMousePosition.y); //kalau sesuai posisi pakai transform.position
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        squarePosition.x = Mathf.Clamp(squarePosition.x, minimum.x, maximum.x);
        squarePosition.y = Mathf.Clamp(squarePosition.y, minimum.y, maximum.y);
        transform.position = squarePosition;
    }
    // void OnMouseExit()
    // {
    //     Debug.Log("exit");
        
    // }
}
