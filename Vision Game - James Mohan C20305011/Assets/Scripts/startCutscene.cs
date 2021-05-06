using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{

   [SerializeField] private Animator CameraAnimationController;
   public static bool isCutsceneOn;
   
   private void OnTriggerEnter(Collider collision)
   {
      if (collision.tag == "Player")
      {
         isCutsceneOn = true;
         CameraAnimationController.SetBool("playCameraAnimation", true);
         Invoke(nameof(StopCutscene), 3f);
      }
   }

   void StopCutscene()
   {
      isCutsceneOn = false;
      CameraAnimationController.SetBool("playCameraAnimation", false);
      Destroy(gameObject);
   }
}
