using UnityEngine;
using System.Collections;

public class AutoDestroyMap : MonoBehaviour {

    public Transform tranformDestroyMap;
	// Use this for initialization
	void Start () {
       // Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.Log(transform.position);
     
        if (transform.position.x == tranformDestroyMap.position.x)
        {
            Debug.Log("des");
            Destroy(gameObject);
        }
	}
}
