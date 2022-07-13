using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
    public float speed = 150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        //get horizontal input
        float h = Input.GetAxisRaw("Horizontal");
        //set velocity(mouvement direction*speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
