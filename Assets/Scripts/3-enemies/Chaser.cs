using System.Collections;
using UnityEngine;
 
/**
 * This component chases a given target object.
 */
public class Chaser: TargetMover {
    [Tooltip("The object that we try to chase")]
    [SerializeField] Transform targetObject = null;
    //private bool iswaiting = false;


    public Vector3 TargetObjectPosition() {
        return targetObject.position;
    }



  
    private void Update() {
        if (targetObject != null)
        {
            SetTarget(targetObject.position);
        }
    
    }
        
        
       
}



