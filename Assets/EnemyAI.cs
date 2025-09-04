using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // ตรวจสอบว่าชนกับ Player หรือไม่
        if (collision.gameObject.tag == "Player")
        {
            // เข้าถึง Gameplay script ของ Player
            Gameplay gameplay = collision.gameObject.GetComponent<Gameplay>();
            if (gameplay != null)
            {
                gameplay.ReducePlayerHP(10); // ลด HP ลง 10
            }
        }
    }
}
