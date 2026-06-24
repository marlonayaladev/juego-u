using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public Transform spawnPoint;

    void Start()
    {
        if (spawnPoint != null)
        {
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
        }
    }
}
