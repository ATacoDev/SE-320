using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public int dashCount = 1;
    public float dashDistance = 10f;
    private Rigidbody2D rb;
    private bool isDashing;
    private bool canMove;
    private bool lastKeyRight;
    private float dashTime;
    public float startDashTime = 0.1f;
    private SpriteRenderer spriteRenderer;
    public DashCooldown dashCooldown;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        dashTime = startDashTime;
        canMove = false;
    }

    void Update()
    {
        if(canMove){
            if (!isDashing)
            {
                float moveHorizontal = Input.GetAxisRaw("Horizontal");
                rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

                if (moveHorizontal > 0)
                {
                    spriteRenderer.flipX = true;
                    lastKeyRight = true;
                }

                if (moveHorizontal < 0)
                {
                    spriteRenderer.flipX = false;
                    lastKeyRight = false;
                }

                if (Input.GetKeyDown(KeyCode.Space) && dashCount > 0)
                {
                    isDashing = true;
                }
            }

            if (isDashing)
            {
                if (dashTime <= 0)
                {
                    dashCount = dashCount - 1;
                    isDashing = false;
                    dashTime = startDashTime;
                    rb.velocity = Vector2.zero;
                    StartCoroutine(DashCooldown());
                }
                else
                {
                    dashTime -= Time.deltaTime;
                    rb.velocity = Vector2.right * dashDistance * (rb.velocity.x >= 0 ? 1 : -1);
                    
                }
            }
        }
    }

    public void ToggleMovement(){
        if (canMove){
            canMove = false;
        }else{
            canMove = true;
        }
    }

    IEnumerator DashCooldown()
        {
            dashCooldown.StartCooldown();
            yield return new WaitForSeconds(1.5f);
            dashCount = dashCount + 1;
        }
}
