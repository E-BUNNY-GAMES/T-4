using UnityEngine;

namespace DefaultNamespace
{
    public class DestroyFragment : MonoBehaviour
    {
        private Rigidbody _rb;
        private MeshCollider _meshCollider;


        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _meshCollider = GetComponent<MeshCollider>();
        }
        
        private void OnTriggerEnter(Collider other)
        {
            string tag = other.tag;
            if (tag.Equals("Destroy bal"))
            {
                Debug.Log("enter fragment");
                Activate();    
            }
            
        }

        private void Activate()
        {
            _rb.isKinematic = false;
            _meshCollider.isTrigger = false;
        }

        
    }
}