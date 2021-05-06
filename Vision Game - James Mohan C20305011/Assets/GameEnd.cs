using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    
    public GameObject EndDialog;

    public static bool IsEnd;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            IsEnd = true;
            EndDialog.SetActive(true);
        }
    }
}
