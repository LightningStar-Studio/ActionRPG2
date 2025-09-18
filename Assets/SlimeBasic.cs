using UnityEngine;

public class SlimeBasic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword")) print("hit");
    }
}
