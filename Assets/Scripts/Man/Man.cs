using System.Collections.Generic;
using Bolt;
using DefaultNamespace.NavMesh;
using UnityEngine;

namespace DefaultNamespace.Man
{
    public class Man : MonoBehaviour
    {
        [SerializeField] private NavmeshAgentController navmeshAgentController;
        [SerializeField] private GameObject deadParticle;
        
        
        private GameObject _allUi;
        
        private bool _isEnter;


        private void Awake()
        {
            _allUi = GameObject.Find("All_UI");
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);
            
            string tag = other.tag;
            if (tag.Equals("Destroy bal") && !_isEnter)
            {
                _isEnter = true;

                if (navmeshAgentController)
                {
                    navmeshAgentController.Deactivate();    
                }

                Instantiate(deadParticle, new Vector3(transform.position.x, 41.5f, transform.position.z), Quaternion.Euler(Vector3.zero));
                
                transform.parent.gameObject.SetActive(false);
                
                CustomEvent.Trigger(_allUi, "bar+",0.01f);               
            }
        }
    }
}