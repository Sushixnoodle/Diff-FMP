using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    // Start is called before the first frame update
    Item item;

    public Button RemoveButton;

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);

        Destroy(gameObject);
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
    }

/*    public void UseItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.RedApple:
                Player.Instance.IncreasePoints(item.value);
            case Item.ItemType.GreenApple:
                break;

        }
    } */
}
