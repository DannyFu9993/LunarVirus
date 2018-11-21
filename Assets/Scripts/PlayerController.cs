using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float jumpHeight;
    public GameObject laser;
    public float jumpTime;
    public GameObject laserSpawn;
    public float fireRate = 0.5f;

    private Rigidbody2D rb2d;
    private float myTime = 0f;
    
    // Use this for initialization
	void Start () {

        rb2d = GetComponent<Rigidbody2D>();


    }
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;
         if (Input.GetButton("Jump"))
        {
             rb2d.AddForce(transform.up * jumpHeight);

         }
        if (Input.GetButton("Fire1") && myTime > fireRate)
        {
            Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            myTime = 0.0f;

        }




        Debug.Log(myTime);

    }

    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        
        //float jump = Input.GetAxis("Jump");

        

        //float verti = Input.GetAxis("Vertical");
        //verti += jumpHeight
        Vector2 movement = new Vector2(horiz,0);
        
        //rb2d.AddForce(transform.up * 10);
        
        rb2d.velocity = movement * speed;
    }



}
