using UnityEngine;

public class DEAD : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Try to get a PlayerSpawn component from the player
            PlayerSpawn playerSpawn = other.GetComponent<PlayerSpawn>();
            if (playerSpawn != null)
            {
                playerSpawn.Respawn();
            }
            else
            {
                // If no PlayerSpawn script, just move to (0,0,0) as fallback
                other.transform.position = Vector3.zero;
            }
        }
    }
}
