using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace.House
{
    public class FullHouseCollisionListener : MonoBehaviour
    {
        public UnityEvent collisionEnterEvent;


        private void OnTriggerEnter(Collider other)
        {
            collisionEnterEvent.Invoke();
            Debug.Log("trigger full house enter");
        }
    }
}