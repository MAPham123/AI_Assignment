using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5;
    public float lerpSpeed = 20f;

    private void Update()
    { 
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
      
        Vector3 input = new Vector3(x, 0, y);
     
        Vector3 velocity = input * speed * Time.deltaTime;
       
        transform.position += velocity;

        if (velocity.magnitude > 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(velocity), lerpSpeed * Time.deltaTime);
        }



    }


}
