using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerController playerController;
    public PauseManager pauseManager;
    public BookController bookController;
    public Interaction interaction;
    public bool dialoguePressed = false;
    public bool submitPressed = false;

    void Update()
    {
        HandlePlayerInput();
        HandlePauseInput();
        HandleBookInput();
        HandleInteractionInput();
        HandleDialogueInput();
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

    void HandleDialogueInput()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            dialoguePressed = true;
        }
        else
        {
            dialoguePressed = false;
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

    public bool GetDialoguePressed()
    {
        bool result = dialoguePressed;
        dialoguePressed = false;
        return result;
    }

    public bool GetSubmitPressed()
    {
        bool result = submitPressed;
        submitPressed = false;
        return result;
    }

    public void RegisterSubmitPressed()
    {
        submitPressed = false;
    }
}
