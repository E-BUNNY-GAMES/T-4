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

        public void Activate()
        {
            _rb.isKinematic = false;
            _meshCollider.isTrigger = false;
        }

    }
}