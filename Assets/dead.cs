using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 lastSafePosition; // เก็บตำแหน่งล่าสุดที่ยืนอยู่
    public string fallZoneTag = "FallZone"; // tag ของพื้นที่ตก

    void Start()
    {
        // เริ่มแรก เก็บตำแหน่งเริ่มต้นไว้ก่อน
        lastSafePosition = transform.position;
    }

    void Update()
    {
        // อัพเดตตำแหน่งล่าสุดที่ปลอดภัย (เช่น เมื่อผู้เล่นอยู่บนพื้น)
        // คุณอาจเพิ่มเช็คว่าต้องอยู่บนพื้นจริง ๆ ด้วย Raycast หรือ CharacterController.isGrounded
        if (IsGrounded())
        {
            lastSafePosition = transform.position;
        }
    }

    private bool IsGrounded()
    {
        // ตรวจสอบว่าผู้เล่นอยู่บนพื้น (Raycast ลงด้านล่าง)
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        // ถ้าชนกับพื้นที่ตก
        if (other.CompareTag(fallZoneTag))
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        transform.position = lastSafePosition;
        // ถ้ามี Rigidbody ก็ควรรีเซ็ตความเร็วด้วย
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
