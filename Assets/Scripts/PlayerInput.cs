using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    // Create private ref to named scripts
    private PlayerMovementScript playerMovementScript;

    private ShootingScript shootingScript;


    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GetComponent<PlayerMovementScript>();

        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        // On input run function to move the player accordingly
        if (HorizontalInput != 0.0f)
        {
            playerMovementScript.HorizontalMovement(HorizontalInput);
        }

        // On input run function to spawn a bullet or issue a warning
        if (Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
                shootingScript.FiringShots();
            }

            else
            {
                Debug.Log("shootingScript not attached");
            }
        }

    }
}
