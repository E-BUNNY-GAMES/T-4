using System.Collections.Generic;
using DG.Tweening;
using UnityEditor.Animations;
using UnityEngine;

namespace DefaultNamespace.Monster.Hands
{
    public class HandAnimatorController : MonoBehaviour
    {
        [SerializeField] private CapsuleCollider capsuleCollider;
        
        
        private Animator _animator;
        private float _defaultHeight;
        private float _defaultRadius;


        private void Awake()
        {
            _animator = GetComponent<Animator>();
            
            _defaultHeight = capsuleCollider.height;
            _defaultRadius = capsuleCollider.radius;
        }


        public void ActivateIdle()
        {
            _animator.SetTrigger("idle");
        }

        public void ActivateUpKick()
        {
            _animator.SetTrigger("up");
        }

        public void ActivateDownKick()
        {
            _animator.SetTrigger("down");
        }

        public void ActivateFlankKick()
        {
            _animator.SetTrigger("flank");
        }

        public void UpCapsule()
        {
            capsuleCollider.height += 5;
            capsuleCollider.radius += 0.3f;
        }

        public void ResetCapsuleHeight()
        {
            capsuleCollider.height = _defaultHeight;
            capsuleCollider.radius = _defaultRadius;
        }


    }
}