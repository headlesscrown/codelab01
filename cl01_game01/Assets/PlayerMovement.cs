using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirX = 0f;
    [SerializeField]private float moveSpeed = 7f; //serialise = expose to editor, change directly in unity
    [SerializeField]private float jumpForce = 14f; //public = not as good, allows access to all scripts

    //int wholeNumber = 16; //store whole number in variable
    //float decimalNumber = 4.56f; //floating point literal
    //string text = "blank"; //entry text
    //bool boolean = false; //check true/false conditions, executes based on condition

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("Hello, world!");

        dirX = Input.GetAxisRaw("Horizontal"); //left: -1, right: +1
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);


        if (Input.GetButtonDown("Jump")) //GBD vs GKD, uses input system
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); //call rigidbody + add speed
        }

        UpdateAnimationState(); //call method
    }

    private void UpdateAnimationState() //no results returned, exclusive execution
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false; //flip sprite, match to right movement

        }
        else if (dirX < 0)
        {
            anim.SetBool("running", true); //running to the left
            sprite.flipX = true; //flip sprite, match to left movement
        }
        else
        {
            anim.SetBool("running", false); //set to idle
        }
    }
}
