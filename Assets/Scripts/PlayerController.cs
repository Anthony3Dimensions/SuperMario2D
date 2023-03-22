using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int playerHealth = 3; 
    int ContadorMonedas;
    
    public float playerSpeed = 5.5f;
    public float jumpforce = 3f;
    string texto = "Hello World";
    private SpriteRenderer spriteRenderer; 
    private Rigidbody2D rBody;
    private GroundSensor sensor;
    public Animator anim;
    float horizontal;
    public Monedas monedas;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>(); 
       rBody = GetComponent<Rigidbody2D>();
       sensor = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
       anim = GetComponent<Animator>();

       playerHealth = 10;
       Debug.Log(texto);  
    }

    // Update is called once per frame
    void Update()
    {
       horizontal = Input.GetAxis("Horizontal");
       //transform.position += new Vector3(horizontal, 0, 0) *playerSpeed* Time.deltaTime; 
       if(horizontal < 0)
       {
          spriteRenderer.flipX = true;
          anim.SetBool("IsRunning", true);
       }
       else if(horizontal > 0)
       {
          spriteRenderer.flipX = false;
          anim.SetBool("IsRunning", true);
       } 
       else
       {
         anim.SetBool("IsRunning", false);
       } 

       if(Input.GetButtonDown("Jump") && sensor.isGrounded)
       {
          rBody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
          anim.SetBool("IsJumping", true);
       }

    }

      void FixedUpdate() 
    {
      rBody.velocity = new Vector2(horizontal * playerSpeed, rBody.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.tag == "Colisionmoneda")
      {
         Monedas monedas = collision.gameObject.GetComponent<Monedas>();
         monedas.Pick();
      }
    }

 
}
