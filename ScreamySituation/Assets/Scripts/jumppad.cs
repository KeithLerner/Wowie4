using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumppad : MonoBehaviour
{
    public float jumpForce = 10f;

    private void OnCollisionEnter2d(Collision2d collision)
    if(collision.gameObject.CompareTag("Player"))
    {
        collision.gameObject.CompareTag<Rigidbody2d>().AddForce(Vector2.up* jumpForce, ForceMode2d.Impulse);
    }
}
