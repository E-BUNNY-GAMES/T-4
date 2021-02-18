using UnityEngine;
using UnityEngine.Networking;

namespace DefaultNamespace
{
    public class RayCastController : MonoBehaviour
    {
        public Transform point;    
        private void LateUpdate()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                point.position = hit.point;
            }
        }
    }
}