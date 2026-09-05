using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
public class Object_Interact : MonoBehaviour
{
    public bool playerInRange;
    public string ItemName;
    GameObject ItemPickUp;
    TextMeshProUGUI ItemPickUpText;
    void Start()
    {
        ItemPickUp = GameObject.Find("ItemPickUp");
        ItemPickUpText = ItemPickUp.GetComponentInChildren<TextMeshProUGUI>();
        ItemPickUp.GetComponent<HidingTheText>().HideText(ItemName);
    }
    public string GetItemName()
    {
        return ItemName;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HidingTheText hidingTheText = ItemPickUp.GetComponent<HidingTheText>();
            playerInRange = true;
            ItemPickUpText.text = ItemName;
            ItemPickUp.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
