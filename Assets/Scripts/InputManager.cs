using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerController playerController;
    public PauseManager pauseManager;
    public BookController bookController;
    public Interaction interaction;

    void Update()
    {
        HandlePlayerInput();
        HandlePauseInput();
        HandleBookInput();
        HandleInteractionInput();
    }

    void HandlePlayerInput()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        playerController.SetMovement(new Vector2(horizontal, vertical));
    }

    void HandlePauseInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseManager.TogglePause();
        }
    }

    void HandleBookInput()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            bookController.ToggleBook();
        }
    }

    void HandleInteractionInput()
    {
        if (interaction.AllowInteract)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                interaction.OnInteract();
            }
        }
    }
}
