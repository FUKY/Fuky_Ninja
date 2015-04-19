using UnityEngine;
using System.Collections;

public class CollisionWithPlayer : MonoBehaviour {

    // circle collider 2d cua enemy
    CircleCollider2D circle;

    // animator 
    public Animator anim_E;

    //khoang cach enemy vs player
    float distancePlayer;

    public Transform frontCheckTranform;

	// Use this for initialization
	void Start () {
        // get circle collider cua enemy
        circle = gameObject.GetComponent<CircleCollider2D>();

        //get animator cua enemy
        anim_E = GetComponent<Animator>();
	}

    bool stopGame = false;
	// Update is called once per frame
	void Update () {

        distancePlayer = transform.position.x - PlayerController.tranformPlayer.position.x;

        //neu khoang cach giua enemy vs Player < 6 set animation cho enemy
        if (distancePlayer < 90.0f && stopGame == false)
        {
            anim_E.SetBool("isRun_E", true);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-50.0f,0);
        }

        //Collider2D[] ListCol2D = Physics2D.OverlapPointAll(frontCheckTranform.position);

        //foreach (Collider2D col in ListCol2D)
        //{
        //    if (col.tag == "Player")
        //    {
        //        anim_E.SetBool("isRun_E", true);
        //    }
        //}
	}

    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            stopGame = true;
            MoveMaps.mapMoveSpeed = 0.0f;
            PlayerController.anim.SetBool("isFall", true);
            anim_E.SetBool("isFall_E",true);

            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

        }
    }
}
