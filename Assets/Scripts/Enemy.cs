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

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Debug.Log("Player has been destroyed");
        }
    }

    public abstract void Move();
}