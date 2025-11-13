using JetBrains.Annotations;
using UnityEngine;

public class squareKeMouse : MonoBehaviour
{
    public Transform CubeTransform;
    public Vector2 PosisiKlik;
    // Update is called once per frame
    void Update()
    {
        //geser object mengikuti pointer
        // Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, worldMousePosition, 0.1f);

        //geser object sesuai klik
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PosisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, PosisiKlik, 0.05f);
    }
}
