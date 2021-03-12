using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RoomManager : MonoBehaviour
{
    private Dictionary<string, Room> rooms;
    

    int direction;
    string currentRoom;

    private void Start()
    {
        rooms = new Dictionary<string, Room>();
        foreach (Transform child in gameObject.transform)
            rooms[child.name] = child.GetComponent<Room>();

        direction = (int)Direction.Front;
        currentRoom = "Room 1";
        EnterRoom(currentRoom);
    }

    public void MoveLeft()
    {
        rooms[currentRoom].roomFacing[direction].SetActive(false);
        direction++;
        if (direction > 3) direction = 0;
        rooms[currentRoom].roomFacing[direction].SetActive(true);
    }

    public void MoveRight()
    {
        rooms[currentRoom].roomFacing[direction].SetActive(false);
        direction--;
        if (direction < 0) direction = 3;
        rooms[currentRoom].roomFacing[direction].SetActive(true);
    }

    public void MoveEnter()
    {
        if (!string.IsNullOrEmpty(rooms[currentRoom].roomMovement[direction]))
        {
            EnterRoom(rooms[currentRoom].roomMovement[direction]);
        }
    }

    public void EnterRoom(string roomName)
    {
        if (rooms.ContainsKey(currentRoom))
        {
            rooms[currentRoom].roomFacing[direction].SetActive(false);
            rooms[currentRoom].gameObject.SetActive(false);
        }

        if (rooms.ContainsKey(roomName))
        {
            rooms[roomName].roomFacing[direction].SetActive(true);
            rooms[roomName].gameObject.SetActive(true);

        }

        currentRoom = roomName;
    }
    enum Direction
    {
        Front,
        Left,
        Back,
        Right
    }
}
