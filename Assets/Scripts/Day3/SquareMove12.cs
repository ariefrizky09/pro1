using UnityEngine;

public class SquareMove12 : MonoBehaviour
{
    public bool isMoveRight = true;
    public float kecepatan = 5.0f;
    public bool isMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bergerak
            //ke kanan
            //ke kiri

        //tidak bergerak
        if (isMove == true)
        {
            //dia bergerak
            if (isMoveRight == true)
            {
                //dia gerak ke kanan
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
            } else
            {
                //dia gerak ke kiri
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
            }
        } else
        {
            //dia tidak bergerak
            gameObject.transform.Translate(0, 0, 0);
        }
    }
}
