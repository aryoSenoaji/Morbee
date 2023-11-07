using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
using UnityEngine.UI;

public class BookItemUI : MonoBehaviour
{
    [SerializeField] private Image itemImage;

    public void UpdateUI(BookItem item)
    {
        itemImage.sprite = item.spiceImage;
    }
}
