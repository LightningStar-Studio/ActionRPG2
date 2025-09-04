using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public float moveTime = 2f;
    public float waitTime = 1.5f;

    private float moveTimer;
    private float waitTimer;
    private Vector3 moveDirection;

    private void Start()
    {
        waitTimer = waitTime;
    }

    void Update()
    {
        if (moveTimer > 0)
        {
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
            moveTimer -= Time.deltaTime;
        }
        else if (waitTimer > 0)
        {
            waitTimer -= Time.deltaTime;
        }
        else
        {
            // สุ่มทิศทางใหม่
            moveDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
            moveTimer = moveTime;
            waitTimer = waitTime;
        }
    }
}
