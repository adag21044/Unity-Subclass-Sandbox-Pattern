using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject slowEnemy;
    public GameObject smartEnemy;
    public GameObject fastEnemy;

    void Start()
    {
        SpawnEnemy(slowEnemy, new Vector3(-5, 0, 0));
        SpawnEnemy(smartEnemy, new Vector3(0, 0, 0));
        SpawnEnemy(fastEnemy, new Vector3(5, 0, 0));
    }

    private void SpawnEnemy(GameObject enemy, Vector3 position)
    {
        Instantiate(enemy, position, Quaternion.identity);
    }
}