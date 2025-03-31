using UnityEngine;

public class WallSpawner : MonoBehaviour

{
    public GameObject Obstacle;
    public float spawnRate = 1f;
    public float moveSpeed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        Obstacle.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

    }
}
