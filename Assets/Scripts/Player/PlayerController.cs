using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = InputSystem.GetDevice<Keyboard>().dKey.ReadValue() - InputSystem.GetDevice<Keyboard>().aKey.ReadValue();
        movement.y = InputSystem.GetDevice<Keyboard>().wKey.ReadValue() - InputSystem.GetDevice<Keyboard>().sKey.ReadValue();

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (movement.x == 1 || movement.x == -1 || movement.y == 1 || movement.y == -1)
        {
            animator.SetFloat("LastMoveHorizontal", movement.x);
            animator.SetFloat("LastMoveVertical", movement.y);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }
}