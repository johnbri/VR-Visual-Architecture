using UnityEngine;
 using System.Collections;
 
 public class Rotate : MonoBehaviour
 {
   private bool canSpin = true;
   [SerializeField] private KeyCode var;

   void Update ()
   {
     if( canSpin == true && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(var)))
     {

      canSpin = false;
       StartCoroutine( Rotator(Vector3.up, 90, 1.0f) );

     }
   }
 
   IEnumerator Rotator( Vector3 axis, float angle, float duration = 1.0f)
   {
     Quaternion startPos = transform.rotation;
     Quaternion endPos = transform.rotation * Quaternion.Euler(axis * angle);
    
     float elapsed = 0.0f;
     while( elapsed < duration )
     {
       transform.rotation = Quaternion.Slerp(startPos, endPos, elapsed / duration );
       elapsed += Time.deltaTime;

       yield return null;
     }
     transform.rotation = endPos;
     canSpin = true;
   }
 }