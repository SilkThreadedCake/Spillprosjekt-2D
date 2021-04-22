using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FirstDoor : MonoBehaviour//, IPointerClickHandler
{
    public GameObject openMe;
    private int click = 0;
    RoomMovement move;
    private void Start()
    {
        move = GameObject.Find("RoomManager").gameObject.GetComponent<RoomMovement>();
    }

    public void clickMe(Button buttonClicked)
    {
        if (click < 3)
        {
            click++;
        }
        if (click >= 3)
        {
            move.UpdateRoom(true);
            Destroy(openMe);

        }
    }
}
