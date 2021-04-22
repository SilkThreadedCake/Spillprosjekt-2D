using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class ItemManager : MonoBehaviour
{
    string[] items;
    public string held;
    List<Toggle> buttons;
    public ToggleGroup zen;
    public int itemsPicked;

    private void Start()
    {
        itemsPicked = 0;
        items = new string[6];
        for (int i = 0; i < 6; i++)
        {
            items[i] = "";
        }
        buttons = new List<Toggle>();
        foreach (Transform t in transform.Find("Hotbar"))
        {
            buttons.Add(t.GetComponent<Toggle>());
            t.Find("Label").GetComponent<TMP_Text>().text = "";
        }
        UpdateList();
    }

    public void AddItem(string item)
    {
        for (int i = 0; i < 6; i++)
        {
            if (items[i] == "" || items[i] == null)
            {
                itemsPicked++;
                items[i] = item;
                UpdateList();
                return;
            }
        }
    }

    public void RemoveItem(string item)
    {
        if (items.Contains(item))
        {
            for (int i = 0; i < 6; i++)
            {
                if (items[i] == item)
                {
                    items[i] = "";
                    UpdateList();
                    return;
                }
            }
        }

    }

    public void HeldItem()
    {
        Toggle t = zen.GetFirstActiveToggle();
        if (t == null)
        {
            held = "";
            return;
        }
        held = t.gameObject.transform.Find("Label").GetComponent<TMP_Text>().text;
    }

    private void UpdateList()
    {
        zen.SetAllTogglesOff();
        for (int i = 0; i < 6; i++)
        {
            if (items[i] != "")
            {
                buttons[i].GetComponent<Toggle>().interactable = true;
                buttons[i].gameObject.transform.Find("Label").GetComponent<TMP_Text>().text = items[i];
            }
            else
            {
                buttons[i].gameObject.transform.Find("Label").GetComponent<TMP_Text>().text = "";
                buttons[i].GetComponent<Toggle>().interactable = false;
            }
        }
    }
    public void EndGame()
    {
        if (held == "key")
        {
            gameObject.transform.Find("Ending").gameObject.SetActive(true);
            if (itemsPicked >= 7)
            {
                gameObject.transform.Find("Ending/Result 1").gameObject.SetActive(true);
            }
            else if (itemsPicked >= 5)
            {
                gameObject.transform.Find("Ending/Result 2").gameObject.SetActive(true);
            }
            else
            {
                gameObject.transform.Find("Ending/Result 3").gameObject.SetActive(true);
            }
        }
    }
}


