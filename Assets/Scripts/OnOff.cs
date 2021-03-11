using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject front;
    public GameObject back;
    GameObject currentRoom;
    int direction;
    private GameObject[] roomFacing = new GameObject[4];
    //public List<GameObject> roomFacing = new List<GameObject>();

    private void Start()
    {
        roomFacing[0] = back;
        roomFacing[1] = right;
        roomFacing[2] = front;
        roomFacing[3] = left;
        direction = 2;
    }

    public void MoveLeft()
    {
        this.gameObject.SetActive(false);
        int tempDir = direction >= 3 ? 0 : direction++;
        this.roomFacing[tempDir].SetActive(true);
        //this.roomFacing[].SetActive(true);
    }

    public void MoveRight()
    {
        this.gameObject.SetActive(false);
        int tempDir = direction <= 0 ? 3 : direction--;
        this.roomFacing[tempDir].SetActive(true);
    }

    public void MoveBack()
    {

    }


}
