using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour 
{

    private float acceleration = 50f;

    private float initialVelocity = 5f;

    private Rigidbody2D bulletRigidbody;

    // Use this for initialization
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();

        bulletRigidbody.velocity = Vector2.up * initialVelocity;
    }

    // When called by MoveForwardConstantly Script 
    public void BulletMovement()
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;

        bulletRigidbody.AddForce(ForceToAdd);
    }
}
