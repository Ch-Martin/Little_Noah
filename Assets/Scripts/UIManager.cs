using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{




    public GameObject inventoryPanel;
    public Button inventoryButton;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleInventory();
        }
    }


    public void ToggleInventory()
    {

        inventoryPanel.SetActive(!inventoryPanel.activeInHierarchy);
        if (inventoryPanel.activeInHierarchy)
        {
            foreach (Transform t in inventoryPanel.transform)
            {
                Destroy(t.gameObject);
            }
            FillInventory();
        }
    }

    public void FillInventory()
    {
        WeaponManager manager = FindObjectOfType<WeaponManager>();
        List<GameObject> weapons = manager.GetAllWeapons();
        int i = 0;
        foreach (GameObject w in weapons)
        {
            Button tempB = Instantiate(inventoryButton, inventoryPanel.transform);
            tempB.GetComponent<InventoryButton>().type = InventoryButton.ItemType.WEAPON;
            tempB.GetComponent<InventoryButton>().itemIdex = i;
            tempB.onClick.AddListener(() => tempB.GetComponent<InventoryButton>().ActivateButton());
            tempB.image.sprite = w.GetComponent<SpriteRenderer>().sprite;
            i++;
        }

    }




}
