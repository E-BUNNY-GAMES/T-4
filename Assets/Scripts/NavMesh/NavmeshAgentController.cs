using UnityEngine;
using UnityEngine.AI;

namespace DefaultNamespace.NavMesh
{
    public class NavmeshAgentController : MonoBehaviour
    {
        [SerializeField] private Transform target;
        
        private NavMeshAgent _navMeshAgent;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }


        private void Start()
        {
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