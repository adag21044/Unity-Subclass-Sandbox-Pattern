public class SlowEnemy : Enemy
{
    private void Start()
    {
        moveSpeed = 1f;
        base.Start();
    }
    public override void Move()
    {
        MoveTowardsPlayer();
    }
}