using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected Transform playerTransform;
    protected float moveSpeed;

    protected virtual void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected void MoveTowardsPlayer()
    {
        if(playerTransform != null)
        {
            Vector3 direction = (playerTransform.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }

    public abstract void Move();
}