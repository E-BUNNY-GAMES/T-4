using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace DefaultNamespace
{
    public class ActionPositionTrigger : MonoBehaviour
    {
        public Vector3 endRotatePosition;
        public RotateEvent rotateEvent;
        
        
        
        private void OnTriggerEnter(Collider other)
        {   
            string tag = other.tag;

            if (tag.Equals("MainCamera"))
            {
                rotateEvent.Invoke(endRotatePosition);    
            }
            
        }
    }

    [Serializable]
    public class RotateEvent : UnityEvent<Vector3>{}
}