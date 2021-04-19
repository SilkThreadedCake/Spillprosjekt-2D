using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUse : MonoBehaviour
{
    public GameObject closedDoor;
    public GameObject openDoor;
    public GameObject keyItem;

    private void OnTriggerEnter(Collider obj)
    {
        if(obj.gameObject.tag == "Key")
        {
            Debug.Log("Key has been used");
            closedDoor.SetActive(false);
            openDoor.SetActive(true);
            keyItem.SetActive(false);
        }
    }
}
