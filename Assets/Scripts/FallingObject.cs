using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float fallSpeed = 2f;

    void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        if (transform.position.y < -5f) // 調整這個值以適應你的場景高度
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // 增加分數或其他操作
            Destroy(gameObject);
        }
    }
}
