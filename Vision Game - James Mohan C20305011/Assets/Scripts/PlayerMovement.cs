using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float MaxSpeed;
    public float Acceleration;
    
    public IdealOn VisionMechanic;

    public GameManager GameManager_;

    public GameObject UsesText;

    public GameObject LeftBarSet;
    public GameObject RightBarSet;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (!GameEnd.IsEnd)
        {
            if (!startCutscene.isCutsceneOn)
            {
                if (rb.velocity.magnitude < MaxSpeed)
                {
                    if (Input.GetKey(KeyCode.W))
                    {
                        rb.AddForce((transform.forward * Acceleration));
                    }

                    if (Input.GetKey(KeyCode.S))
                    {
                        rb.AddForce((transform.forward * -Acceleration));
                    }

                    if (Input.GetKey(KeyCode.A))
                    {
                        rb.AddForce((transform.right * -Acceleration));
                    }

                    if (Input.GetKey(KeyCode.D))
                    {
                        rb.AddForce((transform.right * Acceleration));
                    }
                }
            }
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("powerup"))
        {
            UsesText.SetActive(true);
            PlayerPrefs.SetInt("IsPoweredUp",1);
            Destroy(other.gameObject);
            VisionMechanic.startcount();
        }

        if (other.gameObject.CompareTag("Death"))
        {
            GameManager_.RespawnPlayer();
        }

        if (other.gameObject.CompareTag("Key1"))
        {
            Destroy(other.gameObject);
            Destroy(RightBarSet);
        }
        
        if (other.gameObject.CompareTag("Key2"))
        {
            Destroy(other.gameObject);
            Destroy(LeftBarSet);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Objects"))
        {
            if (VisionMechanic.InsideBuildingTest)
           {
               GameManager_.RespawnPlayer();
           }
        }
    }
}
