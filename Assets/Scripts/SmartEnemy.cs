using UnityEngine;

public class SmartEnemy : Enemy
{
    protected override void Start()
    {
        moveSpeed = 0.5f;
        base.Start();
    }

    private void Update()
    {
        Move();  // Düşman, her frame oyuncuya doğru hareket eder
    }

    public override void Move()
    {
        if(playerTransform != null)
        {
            Vector3 direction = (playerTransform.position - transform.position).normalized;
            direction.x += Mathf.Sin(Time.time) * 0.5f; // Zig-zag movement
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}