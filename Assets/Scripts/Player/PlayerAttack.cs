using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;

    public Animator anim;
    /*private PlayerController playerController;
    private float cooldownTimer = Mathf.Infinity;*/

    public Rigidbody2D rb;
    private float attackTime = 0.25f;
    private float attackCounter = 0.25f;
    private bool isAttacking;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        /*playerController = GetComponent<PlayerController>();*/
    }

    private void Update()
    {
        if (isAttacking)
        {
            rb.velocity = Vector2.zero;
            attackCounter -= Time.deltaTime;
            if (attackCounter <= 0)
            {
                anim.SetBool("isAttacking", false);
                isAttacking = false;
            }
        }

        if (Input.GetMouseButton(0))
        {
            attackCounter = attackTime;
            anim.SetBool("isAttacking", true);
            isAttacking = true;
        }
        /*if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerController)
            Attack();

        cooldownTimer += Time.deltaTime;*/
    }

    private void Attack()
    {
        
    }
}
