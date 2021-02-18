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
              
                if (hit.distance <= 50)
                {
                    point.position = hit.point;    
                }
                
            }
        }
    }
}