using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private Animator animator;
    private Vector2[] patrolPoints;
    private int currentPatrolIndex = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        patrolPoints = new Vector2[4];
        patrolPoints[0] = transform.position + Vector3.up; // up
        patrolPoints[1] = transform.position + Vector3.down; // down
        patrolPoints[2] = transform.position + Vector3.left; // left
        patrolPoints[3] = transform.position + Vector3.right; // right
    }

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        Vector2 targetPosition = patrolPoints[currentPatrolIndex];

        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            targetPosition = patrolPoints[currentPatrolIndex];
        }

        Vector2 moveDirection = (targetPosition - (Vector2)transform.position).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        UpdateAnimator(moveDirection);
    }

    void UpdateAnimator(Vector2 moveDirection)
    {
        animator.SetFloat("Horizontal", moveDirection.x);
        animator.SetFloat("Vertical", moveDirection.y);
    }
}
