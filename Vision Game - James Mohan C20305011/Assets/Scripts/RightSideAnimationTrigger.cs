using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSideAnimationTrigger : MonoBehaviour
{
    [SerializeField] private Animator RightDoorAnimationController;
    
   
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            RightDoorAnimationController.SetBool("RightSideTrigger", true);
            Invoke(nameof(StopCutscene), 1f);
            FindObjectOfType<AudioManger>().Play("DoorOpening");
        }
    }

    void StopCutscene()
    {
        Destroy(gameObject);
    }
}
