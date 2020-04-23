using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private float HorizontalInput;
    [SerializeField] float Speed = 10f;

    //player jump height and check if player is jumping
    [SerializeField] float JumpHeight = 10f;
    private bool IsJumping = false;

    //PLayer rigidbody
    private Rigidbody2D RBPlayer;

    // Start is called before the first frame update
    void Start()
    {
        RBPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get players horizontal Input
        HorizontalInput = Input.GetAxis("Horizontal");

        //Move player left and right using A/D
        transform.Translate(Vector2.right * Time.deltaTime * Speed * HorizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && IsJumping == false)
        {
            RBPlayer.AddForce(Vector2.up * JumpHeight, ForceMode2D.Impulse);
            IsJumping = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        
        //Player stops when colliding w/ platform
        if (collision.gameObject.tag == "Platform")
        {
            RBPlayer.velocity = Vector2.zero;
            IsJumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        //when player reaches leg they beat level
        if (collision.gameObject.tag == "right leg")
        {
            //Increase Player jump height
            JumpHeight = 10f;

            WinScene1();
        }

        if (collision.gameObject.tag == "ending")
        {
            //increase player speed
            Speed = 10f;

            WinScene2();
        }

        //When player falls they lose
        if (collision.gameObject.tag == "Ground")
        {
            DeathScene();
        }
    }

    //Loads win scene for level
    public void WinScene1()
    {
        SceneManager.LoadScene(5);
    }

    //Load lose scene
    public void DeathScene()
    {
        SceneManager.LoadScene(7);
    }

    public void WinScene2()
    {
        SceneManager.LoadScene(6);
    }
}
