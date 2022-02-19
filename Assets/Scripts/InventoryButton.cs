using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{

    public enum ItemType
    {
        WEAPON = 0, ITEM = 1
    };

    public int itemIdex;
    public ItemType type;


    public void ActivateButton()
    {
        switch (type)
        {
            case ItemType.WEAPON:
                FindObjectOfType<WeaponManager>().ChangeWeapon(itemIdex);
                break;
            case ItemType.ITEM:
                Debug.Log("Consumir item (pendiente)");
                break;
            
           
        }
        //ShowDescription();
    }

}
