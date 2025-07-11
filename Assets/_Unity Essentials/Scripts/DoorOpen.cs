using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator doorAnimator;

   void Start()
   {
       // Get the Animator component attached to the same GameObject as this script
       doorAnimator = GetComponent<Animator>();
   }


   private void OnTriggerEnter(Collider other)
   {
       // Check if the object entering the trigger is the player (or another specified object)
       if (other.CompareTag("Player")) // Make sure the player GameObject has the tag "Player"
       {
           if (doorAnimator != null)
           {
               // Trigger the Door_Open animation
               doorAnimator.SetTrigger("Door_Open");
           }
       }
   }
}
