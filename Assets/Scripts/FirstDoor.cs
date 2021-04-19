using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDoor : MonoBehaviour
{
    public GameObject openMe;
    private int click = 0;

    private void OnMouseDown()
    {
        PressMe();
    }

    private void PressMe()
    {
            Debug.Log(click);
        if(click < 3)
        {
            Debug.Log(click);
            click++;
        }
        if (click > 3)
        {
            Debug.Log(click);
            Destroy(openMe);
        }
    }
}
