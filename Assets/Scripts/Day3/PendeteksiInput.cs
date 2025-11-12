using System;
using UnityEngine;
using UnityEngine.Events;

public class PendeteksiInput : MonoBehaviour
{
    public UnityEvent inputEvent;
    // public Action<int> inputEvent; //manual dari code
    //public Score objectScore; //input score direct object
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //objectScore.AddScore(); //input score direct object
            inputEvent.Invoke();
        }
    }
}
