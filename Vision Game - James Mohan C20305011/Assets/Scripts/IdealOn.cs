using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdealOn : MonoBehaviour
{

    public GameObject Ideal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            Ideal.SetActive(true);
        }
        else
        {
            Ideal.SetActive(false);
        }
    }
}