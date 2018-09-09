using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NonAddressableUI : MonoBehaviour {
    public InventoryItem Item;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        GetComponent<Image>().sprite = Item.ItemSprite;
    }
}
