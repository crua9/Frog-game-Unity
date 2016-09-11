using UnityEngine;
using System.Collections;

public class FlySpawner : MonoBehaviour {

    [SerializeField]
    private GameObject flyPrefab;
    [SerializeField]
    private int totalFlyminium = 12;
    
    private float spawnArea = 25f;
    public static int totalFlies;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
