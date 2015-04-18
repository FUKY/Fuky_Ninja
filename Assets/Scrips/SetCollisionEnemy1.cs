using UnityEngine;
using System.Collections;

public class SetCollisionEnemy1 : MonoBehaviour {

    float distanceWithPlayer;

    bool isAttack = true;

    Animator anim;

    public Transform frontCheck;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

        distanceWithPlayer = transform.position.x - PlayerController.tranformPlayer.position.x;

        Collider2D[] ListCollider2D = Physics2D.OverlapPointAll(frontCheck.position);

        //Collider2D[] ListCollider2D = Physics2D.OverlapPointAll(frontCheck.position);
        anim.SetBool("isAttack2", false);
        foreach (Collider2D col in ListCollider2D)
        {
            if (col.tag == "Player" && isAttack == true)
            {
                XulyVaCham();
            }
        }

        if (distanceWithPlayer < 0.0f)
        {
            isAttack = false;
            anim.SetBool("isAttack2", false);
            
        }

	}

    void XulyVaCham()
    {
        MoveMaps.mapMoveSpeed = 0.0f;
        anim.SetBool("isAttack2", true);
        PlayerController.anim.SetBool("isFall", true);
        isAttack = false;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        { 
            MoveMaps.mapMoveSpeed = 0.0f;
            anim.SetBool("isAttack2", true);
            PlayerController.anim.SetBool("isFall", true);
        }

    }

    void FixedUpdate()
    {
        
    }

}
