using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sp;

    public float moveSpeed;

    public bool canMove;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        if (rb == null) rb = GetComponent<Rigidbody2D>();
        if (anim == null) anim = GetComponent<Animator>();
        if (sp == null) sp = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (canMove)
        { 
            MovementInput();
            Animate();
        }

        AdjustRigidbody();
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void MovementInput()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();
    }

    private void Animate()
    {
        if (movement != Vector2.zero)
        {
            anim.SetBool("moving", true);

            if (movement.x < 0)
                sp.flipX = true;
            else if (movement.x > 0)
                sp.flipX = false;
        }
        else
            anim.SetBool("moving", false);
    }

    private void AdjustRigidbody()
    {
        if (movement == Vector2.zero)
            rb.bodyType = RigidbodyType2D.Kinematic;
        else
            rb.bodyType = RigidbodyType2D.Dynamic;
    }

    private void Movement()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //rb.velocity = new Vector2(movement.x * moveSpeed * Time.fixedDeltaTime, movement.y * moveSpeed * Time.fixedDeltaTime);
    }

    public void StopMovement()
    {
        canMove = false;
    }

    public void ResumeMovement()
    {
        canMove = true;
    }

    public bool CurrentCharacter()
    {
        return canMove;
    }
}
