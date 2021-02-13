using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace
{
    public class RotateController : MonoBehaviour
    {
        public float rotateDuration;

        private Vector3 _startRotatePosition;

        
        
        private void Awake()
        {
            _startRotatePosition = transform.rotation.eulerAngles;
        }

        
        
        public void RotateTo(Vector3 endRotatePosition)
        {
            transform.DORotate(endRotatePosition, rotateDuration);
        }

        public void RotateToDefault()
        {
            transform.DORotate(_startRotatePosition, rotateDuration);
        }

    }
}