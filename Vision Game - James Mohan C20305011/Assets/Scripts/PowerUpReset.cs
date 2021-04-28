using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpReset : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("IsPoweredUp",0);
    }

}
