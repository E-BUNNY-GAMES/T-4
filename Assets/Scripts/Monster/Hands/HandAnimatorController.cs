using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace.Monster.Hands
{
    public class HandAnimatorController : MonoBehaviour
    {
//        [SerializeField] private float rotateDuration;
//        
//        [SerializeField] private List<Vector3> upPosition;
//        [SerializeField] private List<Vector3> upRightPosition;
//        [SerializeField] private List<Vector3> upLeftPosition;
//        
//        [SerializeField] private List<Vector3> downPosition;
//        [SerializeField] private List<Vector3> downRightPosition;
//        [SerializeField] private List<Vector3> downLeftPosition;
//        
//        [SerializeField] private List<Vector3> rightPosition;
//        [SerializeField] private List<Vector3> leftPosition;
//
//        private Vector3 _startRotatePosition;
//        private List<Vector3> _currentRotateDirection;
//        private RotateMode _rotateMode;
//        private bool _isActive;

        private Animator _animator;


        private void Awake()
        {
            _animator = GetComponent<Animator>();
//            _startRotatePosition = transform.rotation.eulerAngles;
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


        public void ActivateFight(string direction)
        {
//            switch (direction)
//            {
//                case "up":
//                    Debug.Log("up");
//                    _currentRotateDirection = upPosition;
//                    _rotateMode = RotateMode.Fast;
//                    break;
//                
//                case "up right":
//                    Debug.Log("up right");
//                    _currentRotateDirection = upRightPosition;
//                    _rotateMode = RotateMode.Fast;
//                    break;
//                
//                case "up left":
//                    Debug.Log("up left");
//                    _currentRotateDirection = upLeftPosition;
//                    _rotateMode = RotateMode.Fast;
//                    break;
//                
//                case "down":
//                    Debug.Log("down");
//                    _currentRotateDirection = downPosition;
//                    _rotateMode = RotateMode.Fast;
//                    break;
//                
//                case "down right":
//                    Debug.Log("down right");
//                    _currentRotateDirection = downRightPosition;
//                    _rotateMode = RotateMode.Fast;
//                    break;
//                
//                case "down left":
//                    Debug.Log("down left");
//                    _currentRotateDirection = downLeftPosition;
//                    _rotateMode = RotateMode.Fast;
//                    break;
//                
//                case "right":
//                    Debug.Log("right");
//                    _currentRotateDirection = rightPosition;
//                    _rotateMode = RotateMode.Fast;
//                    break;
//                
//                case "left":
//                    Debug.Log("left");
//                    _currentRotateDirection = leftPosition;
//                    _rotateMode = RotateMode.Fast;
//                    break;
//            }
//
//            if (!_isActive)
//            {
//                _isActive = true;
//                
//                transform.localRotation = Quaternion.Euler(_currentRotateDirection[0]);
//                transform.DOLocalRotate(_currentRotateDirection[1], rotateDuration, _rotateMode)
//                    .OnComplete(() => { _isActive = false; });    
//            }
            
        }


    }
}