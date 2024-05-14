using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;
//using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private SpriteRenderer characterRanderer;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");


        Vector2 direction = new Vector2(horizontal, vertical);
        direction = direction.normalized;

        rb.velocity = direction * speed;


        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRanderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
