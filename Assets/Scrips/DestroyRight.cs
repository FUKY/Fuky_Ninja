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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ground")
        {
            Debug.Log("ok");
        }
        //Debug.Log("ok");
        Destroy(col.gameObject);
    }
}
