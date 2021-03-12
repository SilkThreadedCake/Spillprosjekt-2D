using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room : MonoBehaviour
{
    public GameObject[] roomFacing;

    public string[] roomMovement = new string[4];

    private void Awake()
    {
        roomFacing = new GameObject[4];

        roomFacing[0] = gameObject.transform.Find("Front").gameObject;
        roomFacing[1] = gameObject.transform.Find("Left").gameObject;
        roomFacing[2] = gameObject.transform.Find("Back").gameObject;
        roomFacing[3] = gameObject.transform.Find("Right").gameObject;

        gameObject.SetActive(false);
    }
}
