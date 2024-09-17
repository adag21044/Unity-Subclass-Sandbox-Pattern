using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");    

        Vector3 movement = new Vector3(moveX, 0, moveZ);
         transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Debug.Log("Player has been destroyed");
        }
    }
}
