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
            
            
        private Vector3 _startRotatePosition;

        
        
        private void Awake()
        {
            _startRotatePosition = transform.rotation.eulerAngles;
        }

        
        
        public void RotateTo(Vector3 endRotatePosition)
        {
            legsAnimationController.ActivateStayAnimation();
            transform.DORotate(endRotatePosition, rotateDuration);
        }

        public void RotateToDefault()
        {
             handsController.DestroyHand();
            legsAnimationController.ActivateMoveAnimation();
            transform.DORotate(_startRotatePosition, rotateDuration);
        }

    }
}