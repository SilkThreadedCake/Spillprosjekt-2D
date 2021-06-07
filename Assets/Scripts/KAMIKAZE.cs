using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KAMIKAZE : MonoBehaviour
{
    public string discovery;
    public void Start()
    {
        TextManager.DisplayText(discovery);
        Destroy(this);
    }
}
