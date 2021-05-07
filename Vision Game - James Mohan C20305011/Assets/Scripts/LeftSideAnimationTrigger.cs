using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LeftSideAnimationTrigger : MonoBehaviour
{

    [SerializeField] private Animator LeftDoorAnimationController;
    
   
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            LeftDoorAnimationController.SetBool("LeftSideTrigger", true);
            Invoke(nameof(StopCutscene), 1f);
            FindObjectOfType<AudioManger>().Play("DoorOpening");
        }
    }
    

    void StopCutscene()
    {
        Destroy(gameObject);
    }
}
