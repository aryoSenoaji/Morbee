using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;


    private InputAction pauseMenu;

    private bool isPaused;


    private void OnEnable()
    {
        pauseMenu = new InputAction(binding: "<Keyboard>/Escape");
        pauseMenu.Enable();
        pauseMenu.started += Pause;
    }

    private void OnDisable()
    {
        pauseMenu.Disable();
        pauseMenu.started -= Pause;
    }

    private void Pause(InputAction.CallbackContext context)
    {
        if (!isPaused)
        {
            isPaused = true;
            Time.timeScale = 0f;
        }
        else
        {
            isPaused = false;
            Time.timeScale = 1f;
        }
        pauseMenuUI.SetActive(isPaused);
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(isPaused);
    }
}
