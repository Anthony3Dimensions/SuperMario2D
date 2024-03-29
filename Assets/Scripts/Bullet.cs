using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rBody2D;
    public float bulletSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();

        rBody2D.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 6)
        {
            Enemie enemie = collider,gameObject.GetComponent<Enemie>();
            enemieScript(Die);
        }
        if(collider.gameObject.tag == "Player" || collider.gameObject.tag == "Monedas")
        {
            return;
        }
        Destroy(this.gameObject);
    }
}
