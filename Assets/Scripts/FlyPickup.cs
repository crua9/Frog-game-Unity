using UnityEngine;
using System.Collections;

public class FlyPickup : MonoBehaviour {
    [SerializeField]
    private GameObject pickupPrefab;
	void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
