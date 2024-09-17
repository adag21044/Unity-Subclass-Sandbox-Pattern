public class SlowEnemy : Enemy
{
    private void Start()
    {
        moveSpeed = 0.25f;
        base.Start();
    }

    void Update()
    {
        Move();  // Düşman, her frame oyuncuya doğru hareket eder
    }

    public override void Move()
    {
        MoveTowardsPlayer();
    }
}