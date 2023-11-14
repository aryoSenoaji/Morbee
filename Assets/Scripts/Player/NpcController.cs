using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private Animator animator;
    private Transform[] patrolPoints; // Changed from Vector2 to Transform
    private int currentPatrolIndex = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        FindPatrolPoints();
    }

    void Update()
    {
        Patrol();
        UpdateAnimator();
    }

    void FindPatrolPoints()
    {
        // Find all GameObjects with the "PatrolPoint" tag
        GameObject[] patrolPointObjects = GameObject.FindGameObjectsWithTag("PatrolPoint");

        // Initialize the array with the length of the found objects
        patrolPoints = new Transform[patrolPointObjects.Length];

        // Assign the positions of the found objects to the patrolPoints array
        for (int i = 0; i < patrolPointObjects.Length; i++)
        {
            patrolPoints[i] = patrolPointObjects[i].transform;
        }
    }

    void Patrol()
    {
        Vector2 targetPosition = patrolPoints[currentPatrolIndex].position;

        // move to the next patrol point
        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }

        Vector2 moveDirection = (targetPosition - (Vector2)transform.position).normalized;
        transform.Translate(moveSpeed * Time.deltaTime * moveDirection);
    }

    void UpdateAnimator()
    {
        Vector2 moveDirection = ((Vector2)patrolPoints[currentPatrolIndex].position - (Vector2)transform.position).normalized;
        animator.SetFloat("Horizontal", moveDirection.x);
        //animator.SetFloat("Vertical", moveDirection.y);
    }
}