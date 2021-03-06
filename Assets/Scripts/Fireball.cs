using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public float speed;
    public Rigidbody2D myRigidbody;

    // Update is called once per frame
    public void Setup(Vector2 velocity, Vector3 direction)
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = velocity.normalized * speed;
        transform.rotation = Quaternion.Euler(direction);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
