using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerController playerController;
    public PauseManager pauseManager;
    public BookController bookController;
    public Interaction interaction;
    public bool submitPressed = false;

    void Update()
    {
        HandlePlayerInput();
        HandlePauseInput();
        HandleBookInput();
        HandleInteractionInput();
        HandleSubmitInput();
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

    void HandleSubmitInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            submitPressed = true;
        }
        else
        {
            submitPressed = false;
        }
    }


}
