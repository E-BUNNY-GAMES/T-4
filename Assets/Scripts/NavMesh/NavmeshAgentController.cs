using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace DefaultNamespace.NavMesh
{
    public class NavmeshAgentController : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float timer;
        
        
        private NavMeshAgent _navMeshAgent;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }


        private IEnumerator Start()
        {
            yield return new WaitForSeconds(timer);
            Activate();
        }


        public void Activate()
        {
            _navMeshAgent.SetDestination(target.position);
        }

        public void Deactivate()
        {
            _navMeshAgent.ResetPath();
        }


    }
}