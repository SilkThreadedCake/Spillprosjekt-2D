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
    public string success;
    public string fail;

    void Start()
    {
        //fail = "It does not go there";

        coco = GameObject.Find("Player").GetComponent<ItemManager>();
        updateRoom = GameObject.Find("RoomManager").GetComponent<RoomMovement>();
    }
    public void CheckItem()
    {
        string held = coco.held;
        if (string.IsNullOrEmpty(held) && !string.IsNullOrEmpty(pickup))
        {
            coco.AddItem(pickup);
            TextManager.DisplayText(success);
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
            TextManager.DisplayText(success);
            Destroy(gameObject);
        }
        else
        {
            TextManager.DisplayText(fail);
            coco.unequip();
        }

    }
}
