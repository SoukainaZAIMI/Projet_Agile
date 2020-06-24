using UnityEngine;
using System;
﻿using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed = 800.0f;
    public Text scoreText;
    private int count = 0;
    public Text winText;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        scoreText.text = "score : "+count;
        GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
    	if (other.gameObject.tag == "PickUp")
    	{
    		other.gameObject.SetActive(false);
        count+=1;
        scoreText.text = "score : "+count;
    	}
      if(count >=4){
        winText.gameObject.SetActive(true);
      }
    }

}
