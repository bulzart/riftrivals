using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direction * 7f, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 5f);
        }
        onCharacterMovement();
    }

    public void onCharacterMovement()
    {
        if(direction < 0f){
            spriteRenderer.flipX = true;
        }
        else if(direction > 0f){
            spriteRenderer.flipX = false;
        }
    }
}
