
using Cinemachine;
using DefaultNamespace.Monster.Legs;
using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace
{
    public class RotateController : MonoBehaviour
    {
        public float rotateDuration;
        
        public HandsController handsController;
        public LegsAnimationController legsAnimationController;
        public CinemachineBrain cinemachineBrain;           
            
        private Vector3 _startRotatePosition;

        
        
        public void RotateTo(Vector3 endRotatePosition)
        {
            cinemachineBrain.enabled = false;
            legsAnimationController.ActivateStayAnimation();

            _startRotatePosition = transform.rotation.eulerAngles;
            transform.DORotate(endRotatePosition, rotateDuration);
        }

        public void RotateToDefault()
        {   
            handsController.DestroyHand();
            legsAnimationController.ActivateMoveAnimation();
            transform.DORotate(_startRotatePosition, rotateDuration).OnComplete(() =>
                {
                    cinemachineBrain.enabled = true;
                });
        }

    }
}