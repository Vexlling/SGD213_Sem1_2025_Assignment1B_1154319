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

    // Update is called once per frame
    /*void Update()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        enemyRigidbody.AddForce(ForceToAdd);
    }*/

    //
    public void EnemyMovement()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        enemyRigidbody.AddForce(ForceToAdd);
    }
}
