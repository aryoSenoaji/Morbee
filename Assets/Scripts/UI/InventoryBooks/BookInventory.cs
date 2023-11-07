using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInventory : MonoBehaviour
{
    public List<BookItem> items;
    [SerializeField] private BookInventoryUI bookInventoryUI;

    public void AddItem(BookItem item)
    {
        items.Add(item);
        bookInventoryUI.AddItemUI(item);
    }

    public bool HasItem(BookItem item)
    {
        if (items.Contains(item)) return true;
        return false;
    }

    public void RemoveItem(BookItem item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
    }

    private void Awake()
    {
        Hide();
        //itemDescription.ResetDescription();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        //itemDescription.ResetDescription();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}