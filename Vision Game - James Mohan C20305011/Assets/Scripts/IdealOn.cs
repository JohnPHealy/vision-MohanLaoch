using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IdealOn : MonoBehaviour
{

    public GameObject Ideal;
    public GameObject UnIdeal;

    public float Timer = 5;

    private bool IsIdeal = false;

    public int Uses = 3;

    public TextMeshProUGUI UsesText;

    public bool InsideBuildingTest;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UsesText.text = "V to use, R to reset\n" + "Uses Remaining: " + Uses.ToString("0");
        
        if (Input.GetKey(KeyCode.V) && Uses >0)
        {
            if (!IsIdeal)
            {
                StartCoroutine(Count());
            }
        }

        if (IsIdeal)
        {
            Ideal.SetActive(true);
            UnIdeal.SetActive(false);
        }
        else
        {
            UnIdeal.SetActive(true);
            Ideal.SetActive(false);
        }
    }

    public void startcount()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        if (PlayerPrefs.GetInt("IsPoweredUp") == 1)
        {
            
            FindObjectOfType<AudioManger>().Play("VisionChange");
            
            Uses--;
            IsIdeal = true;
            yield return new WaitForSeconds(Timer);
            IsIdeal = false;
            StartCoroutine(DetectCount());
        }
    }

    IEnumerator DetectCount()
    {
        InsideBuildingTest = true;
        yield return new WaitForSeconds(1);
        InsideBuildingTest = false;
    }

}