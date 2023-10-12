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
        patrolPoints = new Vector2[2];

        //set patrol points for each direction
        //patrolPoints[0] = new Vector2(transform.position.x, transform.position.y + 2.0f); // up
        //patrolPoints[1] = new Vector2(transform.position.x, transform.position.y - 2.0f); // down
        patrolPoints[0] = new Vector2(transform.position.x - 2.0f, transform.position.y); // left
        patrolPoints[1] = new Vector2(transform.position.x + 2.0f, transform.position.y); // right
    }

    void Update()
    {
        Patrol();
        UpdateAnimator();
    }

    void Patrol()
    {
        Vector2 targetPosition = patrolPoints[currentPatrolIndex];

        // move to the next patrol point
        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            targetPosition = patrolPoints[currentPatrolIndex];
        }

        Vector2 moveDirection = (targetPosition - (Vector2)transform.position).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    void UpdateAnimator()
    {
        Vector2 moveDirection = (patrolPoints[currentPatrolIndex] - (Vector2)transform.position).normalized;
        animator.SetFloat("Horizontal", moveDirection.x);
        //animator.SetFloat("Vertical", moveDirection.y);
    }
}
