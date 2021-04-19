using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    List<string> items;
    public string held;
    List<Button> buttons;

    private void Start()
    {
        items = new List<string>();
        buttons = new List<Button>();
        foreach (Transform t in transform.Find("Hotbar"))
        {
            buttons.Add(t.GetComponent<Button>());
        }
        UpdateList();
    }

    public void AddItem(string item)
    {
        if (items.Count >= 6 || items.Contains(item)) return;

        items.Add(item);
        UpdateList();
    }
    
    public void RemoveItem(string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            if (held == item)
            {
                held = "";
            }
            UpdateList();
        }

    }

    private void HeldItem(string hold)
    {
        if (!items.Contains(hold)) return;

        if (held == hold)
        {
            held = "";
            return;
        }
        held = hold;
    }

    private void UpdateList()
    {
        for (int i = 0; i < items.Count; i++)
        {
            buttons[i].gameObject.transform.Find("Text").GetComponent<Text>().text = items[i];
            int counter = i;
            buttons[i].onClick.RemoveAllListeners();
            buttons[i].onClick.AddListener(delegate
            {
                HeldItem(items[counter]);
            });
        }
        for (int i = items.Count; i < 6; i++)
        {
            buttons[i].gameObject.transform.Find("Text").GetComponent<Text>().text = "";
            int counter = i;
            buttons[i].onClick.RemoveAllListeners();
        }
    }
}
