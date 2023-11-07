using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour
{
    [SerializeField]
    private BookInventory bookUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleBook();
        }
    }

    private void ToggleBook()
    {
        if (bookUI.isActiveAndEnabled == false)
        {
            bookUI.Show();
        }
        else
        {
            bookUI.Hide();
        }
    }
}
