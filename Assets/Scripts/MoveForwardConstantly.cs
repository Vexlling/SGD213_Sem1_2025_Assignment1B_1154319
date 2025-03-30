using UnityEngine;
using System.Collections;

public class MoveForwardConstantly : MonoBehaviour
{

    // Create private ref to named scripts
    private EnemyMoveForward enemyMoveForward;

    private BulletMoveForward bulletMoveForward;


    // Use this for initialization
    void Start()
    {
        enemyMoveForward = GetComponent<EnemyMoveForward>();

        bulletMoveForward = GetComponent<BulletMoveForward>();
    }

    // Update is called once per frame
    void Update()
    {
        //
        bulletMoveForward.BulletMovement();

        //
        enemyMoveForward.EnemyMovement();
    }
}
