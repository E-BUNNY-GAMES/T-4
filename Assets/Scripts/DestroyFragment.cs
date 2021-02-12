using UnityEngine;

namespace DefaultNamespace
{
    public class DestroyFragment : MonoBehaviour
    {
        private Rigidbody _rb;


        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        public void Activate()
        {
            _rb.isKinematic = false;
        }

    }
}