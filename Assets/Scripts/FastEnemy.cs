using UnityEngine;

public class FastEnemy : Enemy
{
    private void Start()
    {
        moveSpeed = 2.5f;
        base.Start();
    }

    public override void Move()
    {
        MoveTowardsPlayer();
    }

    private void Update()
    {
        Move();
    }
}