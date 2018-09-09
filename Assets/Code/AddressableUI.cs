using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddressableUI : MonoBehaviour
{
    public InventoryItemAddressable Item;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        Item.ItemSprite.Instantiate<Sprite>().Completed += e =>
            GetComponent<Image>().sprite = e.Result;
    }
}
