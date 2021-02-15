using UnityEngine;

namespace DefaultNamespace
{
    public class CelCollisionListener : MonoBehaviour
    {       
        private void OnTriggerEnter(Collider other)
        {
            other.GetComponent<DestroyFragment>().Activate();
            
            Debug.Log("trigger enter");
        }
    }
}