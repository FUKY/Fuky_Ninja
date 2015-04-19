using UnityEngine;
using System.Collections;

public class SpawnMap : MonoBehaviour {

    float subTime = 0.0f;
    public float distanceTime = 1.0f;
    float startTime;

    public GameObject MapGround;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        subTime = Time.time - startTime;
        if (subTime > distanceTime)
        {
            Instantiate(MapGround,transform.position,transform.rotation);
            startTime = Time.time;
        }
	}


}
