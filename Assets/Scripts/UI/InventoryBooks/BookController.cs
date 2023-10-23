using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BookController : MonoBehaviour
{
    [SerializeField]
    private BookPages bookUI;

    private InputAction toggleBookAction;

    private void OnEnable()
    {
        toggleBookAction = new InputAction(binding: "<Keyboard>/i");
        toggleBookAction.Enable();
        toggleBookAction.started += ToggleBook;
    }

    private void OnDisable()
    {
        toggleBookAction.Disable();
        toggleBookAction.started -= ToggleBook;
    }

    private void ToggleBook(InputAction.CallbackContext context)
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
