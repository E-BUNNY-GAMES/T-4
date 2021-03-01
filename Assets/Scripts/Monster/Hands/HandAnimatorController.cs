using UnityEngine;

namespace DefaultNamespace.Monster.Hands
{
    public class HandAnimatorController : MonoBehaviour
    {
        [SerializeField] private CapsuleCollider capsuleCollider;
        
        
        private Animator _animator;
        private Vector3 _defaultRotateValue;
        private float _defaultHeight;
        private float _defaultRadius;


        private void Awake()
        {
            _animator = GetComponent<Animator>();

            _defaultRotateValue = transform.localRotation.eulerAngles;
            
            _defaultHeight = capsuleCollider.height;
            _defaultRadius = capsuleCollider.radius;
        }


        public void ActivateIdle()
        {
            
            _animator.SetTrigger("idle");
        }

        public void ActivateUpKick()
        {
            transform.localRotation = Quaternion.Euler(Vector3.zero);
            _animator.SetTrigger("up");
        }

        public void ActivateDownKick()
        {
            transform.localRotation = Quaternion.Euler(Vector3.zero);
            _animator.SetTrigger("down");
        }

        public void ActivateFlankKick()
        {
            transform.localRotation = Quaternion.Euler(Vector3.zero);
            _animator.SetTrigger("flank");
        }

        public void UpCapsule()
        {
            capsuleCollider.height += 5;
            capsuleCollider.radius += 0.5f;
        }

        public void ResetCapsuleHeight()
        {
            transform.localRotation = Quaternion.Euler(_defaultRotateValue);
            
            capsuleCollider.height = _defaultHeight;
            capsuleCollider.radius = _defaultRadius;
        }


    }
}