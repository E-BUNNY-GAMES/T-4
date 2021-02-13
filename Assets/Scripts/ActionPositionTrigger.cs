using System;
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
            rotateEvent.Invoke(endRotatePosition);
        }
    }

    [Serializable]
    public class RotateEvent : UnityEvent<Vector3>{}
}