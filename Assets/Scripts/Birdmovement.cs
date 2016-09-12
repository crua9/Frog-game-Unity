using UnityEngine;
using System.Collections;

public class Birdmovement : MonoBehaviour {

    [SerializeField]
    private Transform target;
    private NavMeshAgent birdAgent;
    private Animator birdAnimator;

	// Use this for initialization
	void Start () {
        birdAgent = GetComponent<NavMeshAgent>();
        birdAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        birdAgent.SetDestination(target.position);

        float speed = birdAgent.velocity.magnitude;

        birdAnimator.SetFloat("Speed", speed);
	}
}
