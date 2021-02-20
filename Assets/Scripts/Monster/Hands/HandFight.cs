using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace.Monster.Hands
{
    public class HandFight : MonoBehaviour
    {
        [SerializeField] private float rotateDuration;
        
        [SerializeField] private List<Vector3> upPosition;
        [SerializeField] private List<Vector3> upRightPosition;
        [SerializeField] private List<Vector3> upLeftPosition;
        
        [SerializeField] private List<Vector3> downPosition;
        [SerializeField] private List<Vector3> downRightPosition;
        [SerializeField] private List<Vector3> downLeftPosition;
        
        [SerializeField] private List<Vector3> rightPosition;
        [SerializeField] private List<Vector3> leftPosition;

        private Vector3 _startRotatePosition;
        private List<Vector3> _currentRotateDirection;
        
        
        private void Awake()
        {
            _startRotatePosition = transform.rotation.eulerAngles;
        }


        public void ActivateFight(string direction)
        {
            switch (direction)
            {
                case "up":
                    Debug.Log("up");
                    _currentRotateDirection = upPosition; 
                    break;
                
                case "up right":
                    Debug.Log("up right");
                    _currentRotateDirection = upRightPosition;
                    break;
                
                case "up left":
                    Debug.Log("up left");
                    _currentRotateDirection = upLeftPosition;
                    break;
                
                case "down":
                    Debug.Log("down");
                    _currentRotateDirection = downPosition;
                    break;
                
                case "down right":
                    Debug.Log("down right");
                    _currentRotateDirection = downRightPosition;
                    break;
                
                case "down left":
                    Debug.Log("down left");
                    _currentRotateDirection = downLeftPosition;
                    break;
                
                case "right":
                    Debug.Log("right");
                    _currentRotateDirection = rightPosition;
                    break;
                
                case "left":
                    Debug.Log("left");
                    _currentRotateDirection = leftPosition;
                    break;
            }
            
            transform.rotation = Quaternion.Euler(_currentRotateDirection[0]);
            transform.DOLocalRotate(_currentRotateDirection[1], rotateDuration);
        }


    }
}