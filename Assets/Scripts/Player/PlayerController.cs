using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    public void SetMovement(Vector2 inputMovement)
    {
        movement = inputMovement;
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (inputMovement.x == 1 || inputMovement.x == -1 || inputMovement.y == 1 || inputMovement.y == -1)
        {
            animator.SetFloat("LastMoveHorizontal", inputMovement.x);
            animator.SetFloat("LastMoveVertical", inputMovement.y);
        }
    }

    void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}