using UnityEngine;

namespace DefaultNamespace
{
    public class CelTriggerListener : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            //other.GetComponent<DestroyFragment>().Activate();
            Debug.Log("trigger");
        }
    }
}