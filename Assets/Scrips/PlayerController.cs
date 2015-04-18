using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public static Animator anim;

    public float jumbForce = 500.0f;

    public LayerMask layerMaskGoundCheck;

    public Transform tranformGroundCheck;

    bool grounded;

    public static Transform tranformPlayer;

	// Use this for initialization
	void Start () {
	    anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        tranformPlayer = gameObject.transform;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumbForce));
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,jumbForce);
        }

        CheckGround();

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("attack");
            anim.SetBool("isAttack", true);
        }
	}

    void CheckGround()
    {
        grounded = Physics2D.OverlapCircle(tranformGroundCheck.position, 0.1f, layerMaskGoundCheck);
        anim.SetBool("isRun", grounded);
    }

}
