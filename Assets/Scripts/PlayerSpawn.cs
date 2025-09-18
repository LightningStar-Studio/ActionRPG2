using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private Vector3 spawnPoint;

    private void Start()
    {
        spawnPoint = transform.position; // Set initial spawn point
    }

    public void Respawn()
    {
        transform.position = spawnPoint;
        // Optionally reset velocity if using Rigidbody
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
