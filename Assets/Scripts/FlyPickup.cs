using UnityEngine;
using System.Collections;

public class FlyPickup : MonoBehaviour {
    [SerializeField]
    private GameObject pickupPrefab;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);
            FlySpawner.totalFlies--;
            Destroy (gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
}
