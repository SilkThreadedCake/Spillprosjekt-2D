using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMovement : MonoBehaviour
{
    public GameObject startRoom;
    GameObject currentRoom;

    public GameObject[] botan = new GameObject[4];

    private void Start()
    {

        EnterRoom(startRoom);
    }

    public void MoveEnter(int direction)
    {
        if (currentRoom.GetComponent<Room>().rooms[direction] != null)
        {
            EnterRoom(currentRoom.GetComponent<Room>().rooms[direction]);
        }
    }

    public void EnterRoom(GameObject room)
    {
        if (currentRoom != null)
            currentRoom.gameObject.SetActive(false);

        Room roomScript = room.GetComponent<Room>();
        roomScript.gameObject.SetActive(true);

        currentRoom = room;

        for (int i = 0; i < 4; i++)
        {
            botan[i].SetActive(roomScript.rooms[i] != null);
        }
    }
    enum Direction
    {
        Front,
        Left,
        Back,
        Right
    }
}