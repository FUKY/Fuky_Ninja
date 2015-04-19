using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

    int numOfEnemy;

    public GameObject enemy1;

    public GameObject enemy2;

	// Use this for initialization
	void Start () {
        numOfEnemy = Random.Range(0,2);
        //Debug.Log(numOfEnemy);
        if (numOfEnemy == 0)
        {
            Instantiate(enemy1, transform.position, transform.rotation);
        }
        else if(numOfEnemy == 1)
        {
            Instantiate(enemy2, transform.position, transform.rotation);
        }
	}

    float subTime = 0.0f;
    public float distanceTime = 3.0f;
    float startTime;

	// Update is called once per frame
	void FixedUpdate () {
        subTime = Time.time - startTime;
        //Debug.Log(subTime);
        if (subTime > distanceTime )
        {
            RandomEnemy();
            startTime = Time.time;
        }

	}

    void RandomEnemy()
    {
        numOfEnemy = Random.Range(0, 2);
        Debug.Log(numOfEnemy);
        if (numOfEnemy == 0)
        {
            Instantiate(enemy1, transform.position, transform.rotation);
        }
        else if (numOfEnemy == 1)
        {
            Instantiate(enemy2, transform.position, transform.rotation);
        }
    }
}
