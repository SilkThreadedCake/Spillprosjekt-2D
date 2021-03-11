using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    private GameObject[] roomFacing = new GameObject[4];
    int direction;

    private void Start()
    {
        roomFacing[0] = gameObject.transform.Find("Front").gameObject;
        roomFacing[1] = gameObject.transform.Find("Left").gameObject;
        roomFacing[2] = gameObject.transform.Find("Back").gameObject;
        roomFacing[3] = gameObject.transform.Find("Right").gameObject;
        direction = 0;
    }

    public void MoveLeft()
    {
        roomFacing[direction].SetActive(false);
        direction++;
        if (direction > 3) direction = 0;
        this.roomFacing[direction].SetActive(true);
    }

    public void MoveRight()
    {
        roomFacing[direction].SetActive(false);
        direction--;
        if (direction < 0) direction = 3;
        this.roomFacing[direction].SetActive(true);
    }
    

    public void MoveBack()
    {

    }
}
