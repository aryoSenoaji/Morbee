using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : Interaction
{
    [SerializeField] private BookInventory inventory;
    [SerializeField] private BookItem itemToAdd;
    public override void OnInteract()
    {
        base.OnInteract();
        inventory.AddItem(itemToAdd);
        DisableInteract();
    }

    protected void DisableInteract()
    {
        interactUI.SetActive(false);
        gameObject.SetActive(false);
    }
}
