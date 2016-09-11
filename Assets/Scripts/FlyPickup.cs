using UnityEngine;
using System.Collections;

public class FlyPickup : MonoBehaviour {

	void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
