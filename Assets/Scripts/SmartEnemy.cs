using UnityEngine;

public class SmartEnemy : Enemy
{
    private void Start()
    {
        moveSpeed = 2f;
        base.Start();
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