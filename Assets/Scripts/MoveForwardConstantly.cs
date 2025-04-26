using UnityEngine;
using System.Collections;

public class MoveForwardConstantly : MonoBehaviour
{
    // Script indicates how often to run certain functions from other scripts 

    // Create private ref to named scripts
    private EnemyMovement enemyMoveForward;

    private BulletMoveForward bulletMoveForward;


    // Use this for initialization
    void Start()
    {
        enemyMoveForward = GetComponent<EnemyMovement>();

        bulletMoveForward = GetComponent<BulletMoveForward>();
    }

    // Update is called once per frame
    void Update()
    {

        // Not the most effecient, but without the if statements Unity complains the GameObjects referenced have no definition
        /*if (enemyMoveForward = null)
        {
            enemyMoveForward.MoveEnemy();
        }*/

        if (bulletMoveForward = null)
        {
            bulletMoveForward.BulletMovement();
        }
    }
}
