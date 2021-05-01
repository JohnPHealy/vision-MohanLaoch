using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetBack : MonoBehaviour
{
    [SerializeField] private Collider playerCheck;
   // [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.RespawnPlayer();
        }
    }
}