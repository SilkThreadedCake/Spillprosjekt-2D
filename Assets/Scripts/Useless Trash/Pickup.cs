using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{


    //Must be changed for mobile. Current for testing only.
    private void OnMouseDown()
    {
        //create item in inventory

        Destroy(gameObject);
    }
}
