using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace.Monster.Hands
{
    public class HandAnimatorController : MonoBehaviour
    {
        private Animator _animator;


        private void Awake()
        {
            _animator = GetComponent<Animator>();
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

        
        


    }
}