using UnityEngine;

public class moveObstacle : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 move_vel;
    public bool moved;

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(moved == false)
        {
            rb.velocity = move_vel;
            //moved = true;
        }
    }
}
