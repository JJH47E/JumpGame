using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    public bool jump;
    public Rigidbody2D rb;
    public Vector2 jump_vel;
    public bool collided;
    public bool endgame;
    public int s;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") == true)
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
            Debug.Log("Floor Collision");
        }
        if(col.gameObject.tag == "Enemy")
        {
            endgame = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        collided = false;

    }

    void Start()
    {
        SceneManager.UnloadSceneAsync("StartScreen");
    }

    void FixedUpdate()
    {
        if(endgame == true)
        {
            Debug.Log("Collision detected; ending game");
            SceneManager.LoadScene("gameOver");
        }
        if(jump == true & collided == true)
        {
            rb.AddForce(jump_vel);
        }
    }
}
