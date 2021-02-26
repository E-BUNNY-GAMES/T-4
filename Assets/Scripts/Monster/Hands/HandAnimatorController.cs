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


        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _defaultHeight = capsuleCollider.height;
        }


        public void ActivateIdle()
        {
            _animator.SetTrigger("idle");
        }

        public void ActivateUpKick()
        {
            _animator.SetTrigger("up");
            //capsuleCollider.height += 4f;
        }

        public void ActivateDownKick()
        {
            _animator.SetTrigger("down");
            //capsuleCollider.height += 4f;
        }

        public void ActivateFlankKick()
        {
            _animator.SetTrigger("flank");
            //capsuleCollider.height += 4f;
        }

        public void UpCapsuleHeight()
        {
            capsuleCollider.height += 4;
        }

        public void ResetCapsuleHeight()
        {
            capsuleCollider.height = _defaultHeight;
        }


    }
}