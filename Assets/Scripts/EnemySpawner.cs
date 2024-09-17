using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject slowEnemy;
    public GameObject smartEnemy;
    public GameObject fastEnemy;

    // x için -4.46 ile 4.46 arasında, z için -4.93 ile 3.16 arasında
    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(-4.46f, 4.46f);  // x aralığı
        float z = Random.Range(-4.93f, 3.16f);  // z aralığı
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
