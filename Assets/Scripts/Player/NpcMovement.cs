using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Kecepatan gerakan musuh
    private Vector2 initialPosition; // Posisi awal musuh
    private bool movingRight = true; // Apakah musuh bergerak ke kanan

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            transform.localScale = new Vector2(-1, 1); // Flip sprite jika bergerak ke kanan
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            transform.localScale = new Vector2(1, 1); // Kembalikan sprite jika bergerak ke kiri
        }

        if (transform.position.x >= initialPosition.x + 2.0f) // Atur jarak patroli
        {
            movingRight = false;
        }

        if (transform.position.x <= initialPosition.x - 2.0f) // Atur jarak patroli
        {
            movingRight = true;
        }
    }
}
