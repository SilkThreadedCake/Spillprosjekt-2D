using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poi : MonoBehaviour
{
    private ItemManager coco;
    private RoomMovement updateRoom;
    public string pickup;
    public string use;
    public string usePickup;
    public GameObject door;

    void Start()
    {
        coco = GameObject.Find("Player").GetComponent<ItemManager>();
        updateRoom = GameObject.Find("RoomManager").GetComponent<RoomMovement>();
    }
    public void CheckItem()
    {
        string held = coco.held;
        if (string.IsNullOrEmpty(held) && !string.IsNullOrEmpty(pickup))
        {
            coco.AddItem(pickup);
            Destroy(gameObject);
        }
        else if (!string.IsNullOrEmpty(held) && !string.IsNullOrEmpty(use) && held == use)
        {
            coco.RemoveItem(held);
            if (door != null)
            {
                Destroy(door);
                updateRoom.UpdateRoom(true);
            }
            if (!string.IsNullOrEmpty(usePickup))
            {
                coco.AddItem(usePickup);
            }
            Destroy(gameObject);
        }

    }
}
