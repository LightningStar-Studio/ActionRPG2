using UnityEngine;

public class sprint : MonoBehaviour
{
    public float walkSpeed = 5f; // ความเร็วในการเดิน
    public float runSpeed = 10f; // ความเร็วในการวิ่ง
    private float currentSpeed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = walkSpeed; // เริ่มต้นด้วยความเร็วเดิน
    }

    void Update()
    {
        // ตรวจสอบว่ากดปุ่ม Shift หรือไม่
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            currentSpeed = runSpeed; // เปลี่ยนเป็นความเร็ววิ่ง
        }
        else
        {
            currentSpeed = walkSpeed; // กลับไปที่ความเร็วเดิน
        }

        // รับค่าการเคลื่อนที่จากปุ่มลูกศรหรือ WASD
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.linearVelocity = movement * currentSpeed;
    }
}
