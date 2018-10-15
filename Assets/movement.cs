using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour {

    public Rigidbody2D rbody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        rbody.AddForce(new Vector2(0f, 10f * Time.deltaTime));
		//addforce
        //.velocity
        //moveposition

        //addtorque
        //angularVelocity
        //moverotation
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("tests");
        }
            if (Input.GetKeyDown(KeyCode.Space))
        {

            rbody.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rbody.AddForce(new Vector2(-20f, 0f));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rbody.AddForce(new Vector2(20f, 0f));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rbody.AddForce(new Vector2(0f, 20f));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rbody.AddForce(new Vector2(0f, -30f));
        }
    }
    //enter
    //exit
    //stay
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("hit!");
        SceneManager.LoadScene("tests");
    }
}
