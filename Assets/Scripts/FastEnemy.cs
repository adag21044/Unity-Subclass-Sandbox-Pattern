using UnityEngine;

public class FastEnemy : Enemy
{
    private void Start()
    {
        moveSpeed = 10f;
        base.Start();
    }

    public override void Move()
    {
        MoveTowardsPlayer();
    }
}