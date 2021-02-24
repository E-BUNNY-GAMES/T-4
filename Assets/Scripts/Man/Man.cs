using System.Collections.Generic;
using DefaultNamespace.NavMesh;
using UnityEngine;

namespace DefaultNamespace.Man
{
    public class Man : MonoBehaviour
    {
        [SerializeField] private NavmeshAgentController navmeshAgentController;
        [SerializeField] private List<GameObject> bodyParts;
        
        private bool _isEnter;
        
        
        private void OnTriggerEnter(Collider other)
        {
            string tag = other.tag;
            if (tag.Equals("Destroy bal") && !_isEnter)
            {
                _isEnter = true;

                if (navmeshAgentController)
                {
                    navmeshAgentController.Deactivate();    
                }
                

                transform.parent.gameObject.SetActive(false);
                    //bodyPart.SetActive(false);
            }
        }
    }
}