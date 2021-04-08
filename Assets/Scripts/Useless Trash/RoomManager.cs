//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;


//public class RoomManager : MonoBehaviour
//{
//    //private Dictionary<string, Room> rooms;
    

//    int direction;
//    GameObject currentRoom;

//    private void Start()
//    {
//        //rooms = new Dictionary<string, Room>();
//        //foreach (Transform child in gameObject.transform)
//        //    rooms[child.name] = child.GetComponent<Room>();

//        direction = (int)Direction.Front;
//        currentRoom = transform.Find("Room 1").gameObject;
//        EnterRoom(currentRoom);
//    }

//    public void MoveLeft()
//    {
//        currentRoom.GetComponent<Room>().rooms[direction].SetActive(false);
//        direction++;
//        if (direction > 3) direction = 0;
//        currentRoom.GetComponent<Room>().rooms[direction].SetActive(true);
//    }

//    public void MoveRight()
//    {
//        currentRoom.GetComponent<Room>().rooms[direction].SetActive(false);
//        direction--;
//        if (direction < 0) direction = 3;
//        currentRoom.GetComponent<Room>().rooms[direction].SetActive(true);
//    }

//    public void MoveEnter()
//    {
//        if (currentRoom.GetComponent<Room>().roomMovement[direction] != null)
//        {
//            EnterRoom(currentRoom.GetComponent<Room>().roomMovement[direction]);
//        }
//    }

//    public void EnterRoom(GameObject room)
//    {
        
//        currentRoom.GetComponent<Room>().rooms[direction].SetActive(false);
//        currentRoom.gameObject.SetActive(false);

//        room.GetComponent<Room>().rooms[direction].SetActive(true);
//        room.GetComponent<Room>().gameObject.SetActive(true);

//        currentRoom = room;
//    }
//    enum Direction
//    {
//        Front,
//        Left,
//        Back,
//        Right
//    }
//}
