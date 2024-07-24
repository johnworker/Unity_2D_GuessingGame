using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject fallingObjectPrefab;
    public float spawnInterval = 1f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            SpawnFallingObject();
            timer = 0;
        }
    }

    void SpawnFallingObject()
    {
        float xPosition = Random.Range(-2.45f, 2.45f); // 調整這個值以適應你的場景寬度
        Vector3 spawnPosition = new Vector3(xPosition, 5f, 0); // 調整這個值以適應你的場景高度
        Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
    }
}
