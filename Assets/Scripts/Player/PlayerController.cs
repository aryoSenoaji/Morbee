using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (movement.x == 1 || movement.x == -1 || movement.y == 1 || movement.y == -1)
        {
            animator.SetFloat("LastMoveHorizontal", movement.x);
            animator.SetFloat("LastMoveVertical", movement.y);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }

}


// in this below script before using the movement new input system key binding
//public class PlayerController : MonoBehaviour
//{
//    public float moveSpeed = 2f;

//    public Rigidbody2D rb;
//    public Animator animator;

//    Vector2 movement;

//    // Update is called once per frame
//    void Update()
//    {
//        movement.x = InputSystem.GetDevice<Keyboard>().dKey.ReadValue() - InputSystem.GetDevice<Keyboard>().aKey.ReadValue();
//        movement.y = InputSystem.GetDevice<Keyboard>().wKey.ReadValue() - InputSystem.GetDevice<Keyboard>().sKey.ReadValue();

//        animator.SetFloat("Horizontal", movement.x);
//        animator.SetFloat("Vertical", movement.y);
//        animator.SetFloat("Speed", movement.sqrMagnitude);

//        Debug.Log("Movement Vector: " + movement);

//        if (movement.x == 1 || movement.x == -1 || movement.y == 1 || movement.y == -1)
//        {
//            animator.SetFloat("LastMoveHorizontal", movement.x);
//            animator.SetFloat("LastMoveVertical", movement.y);
//        }
//    }

//    void FixedUpdate()
//    {
//        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
//    }
//}