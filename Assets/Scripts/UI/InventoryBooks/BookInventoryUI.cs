using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
using UnityEngine.UI;

public class BookInventoryUI : MonoBehaviour
{
    [SerializeField] BookItemUI itemUIPrefab;
    [SerializeField] private GameObject SpicesContent;

    public void AddItemUI(BookItem item)
    {
        BookItemUI itemUI = Instantiate(itemUIPrefab, SpicesContent.transform);
        itemUI.UpdateUI(item);
    }
}