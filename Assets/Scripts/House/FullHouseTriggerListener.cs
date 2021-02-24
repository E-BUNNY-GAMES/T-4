using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace DefaultNamespace.House
{
    public class FullHouseTriggerListener : MonoBehaviour
    {
        public UnityEvent triggerEnterEvent;


        private void OnTriggerEnter(Collider other)
        {
            string tag = other.tag;
            if (tag.Equals("Destroy bal"))
            {
                triggerEnterEvent.Invoke();
                Debug.Log("trigger full house enter");    
            }
            
        }
    }
}