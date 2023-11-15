using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] protected GameObject interactUI;
    public bool AllowInteract { get { return allowInteract; } }

    private bool allowInteract = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactUI.SetActive(true);
        allowInteract = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactUI.SetActive(false);
        allowInteract = false;
    }

    private void Update()
    {
        if (allowInteract)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnInteract();
            }
        }
    }

    public virtual void OnInteract()
    {
        interactUI.SetActive(false);
    }
}
