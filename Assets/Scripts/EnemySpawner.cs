using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject slowEnemy;
    public GameObject smartEnemy;
    public GameObject fastEnemy;

    
    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(-12.52f, 12.52f);  // x aralığı
        float z = Random.Range(-6f, 6f);  // z aralığı
        float y = -1.09f;  // y sabit

        return new Vector3(x, y, z);
    }

    void Start()
    {
        // Düşmanları rastgele konumlarda spawn ediyoruz.
        SpawnEnemy(slowEnemy);
        SpawnEnemy(smartEnemy);
        SpawnEnemy(fastEnemy);
    }

    private void SpawnEnemy(GameObject enemy)
    {
        Vector3 randomPosition = GetRandomPosition();
        Instantiate(enemy, randomPosition, Quaternion.identity);
    }
}
