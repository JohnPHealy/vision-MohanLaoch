using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    
    public GameObject EndDialog;
    public GameObject TheEnd;
  

    public static bool IsEnd;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            IsEnd = true;
            StartCoroutine(WaitBeforeShow());
        }

        IEnumerator WaitBeforeShow()
        {
            EndDialog.SetActive(true);
            yield return new WaitForSeconds(7);
            TheEnd.SetActive(true);
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
