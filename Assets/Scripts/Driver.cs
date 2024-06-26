using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] string actualSpeed = "Normal";
 
    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

      
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            actualSpeed = "Fast";
        }

    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }


}
