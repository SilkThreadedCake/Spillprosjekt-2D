using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KAMIKAZE : MonoBehaviour
{
    public string discovery;
    public void Awake()
    {
        TextManager.DisplayText(discovery);
        Destroy(this);
    }
}
