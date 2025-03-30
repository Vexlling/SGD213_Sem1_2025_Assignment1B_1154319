using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour 
{

    private float acceleration = 50f;

    private float initialVelocity = 5f;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    // When called by MoveForwardConstantly Script 
    public void BulletMovement()
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;

        ourRigidbody.AddForce(ForceToAdd);
    }
}
