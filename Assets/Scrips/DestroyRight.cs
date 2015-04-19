using UnityEngine;
using System.Collections;

public class DestroyRight : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
       
	}

    //void OnCollisionEnter2D(Collision2D coll)
    //{
    //    Debug.Log("ok");
    //    Destroy(coll.gameObject);
        

    //}

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("ok");
        Destroy(col.gameObject);
    }
}
