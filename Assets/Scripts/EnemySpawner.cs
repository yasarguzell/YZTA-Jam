using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float x = Random.Range(-6f, 6f);
        Vector3 pos = new Vector3(x, transform.position.y, 0);
        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }
}
