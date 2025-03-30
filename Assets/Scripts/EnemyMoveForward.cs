using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour 
{

    private float acceleration = 75f;

    private float initialVelocity = 2f;

    private Rigidbody2D enemyRigidbody;

    // Use this for initialization
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();

        enemyRigidbody.velocity = Vector2.down * initialVelocity;
    }

    // When called by MoveForwardConstantly Script
    public void EnemyMovement()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        enemyRigidbody.AddForce(ForceToAdd);
    }
}
