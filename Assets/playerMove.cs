using UnityEngine;

public class playerMove : MonoBehaviour
{
    public bool jump;
    public Rigidbody2D rb;
    public Vector2 jump_vel;
    public bool collided;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Floor")
        {
            collided = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        collided = false;

    }

    void FixedUpdate()
    {
        if(jump == true & collided == true)
        {
            rb.AddForce(jump_vel);
        }
    }
}
