using System.Collections;
using Bolt;
using DefaultNamespace.Monster.Hands;
using DG.Tweening;
using UnityEngine;


namespace DefaultNamespace
{
    public class HandsController : MonoBehaviour
    {
        [SerializeField] private HandAnimatorController leftHandAnimatorController;
        [SerializeField] private HandAnimatorController rightHandAnimatorController;
        [SerializeField] private CameraTriggerListener cameraTriggerListener;
        [SerializeField] private GameObject allUi;
        
        private HandAnimatorController _currentHandAnimatorController;
        private Vector3 _defaultPosition;
        private Vector3 _defaultRotation;
        
        private bool _lastLeft;
        private bool _timer;
        private bool _destroyActivate;

        private void Awake()
        {
            _defaultPosition = transform.localPosition;
        }
        
        public void ActivateHand(string direction)
        {
            _defaultRotation = transform.localRotation.eulerAngles;
            
            switch (direction)
            {
                case "left":
                    transform.DOLocalMove(new Vector3(0.25f, _defaultPosition.y, 0), 1f);
                    transform.DOLocalRotate(new Vector3(0, -90f, 0), 1.5f);
                    _currentHandAnimatorController = leftHandAnimatorController;
                    break;
                case "right":
                    transform.DOLocalMove(new Vector3(0.25f, _defaultPosition.y, 0), 1f);
                    transform.DOLocalRotate(new Vector3(0, 90f, 0), 1.5f);
                    _currentHandAnimatorController = rightHandAnimatorController;
                    break;
                case "finish":
                    transform.DOLocalMove(new Vector3(1f, 4f, -1), 1f);
                    transform.DOLocalRotate(new Vector3(0, 37f, 0), 1.5f);
                    _currentHandAnimatorController = rightHandAnimatorController;
                    break;
            }
            
        }


        public void FightHand(string direction)
        {
            CustomEvent.Trigger(allUi, "bar+", 0.04f);
            
            switch (direction)
            {
                case "up":
                    ChangeHand();
                    _currentHandAnimatorController.ActivateDownKick();
                    break;
                
                case "down":
                    ChangeHand();
                    _currentHandAnimatorController.ActivateUpKick();
                    break;
                
                case "left":
                    rightHandAnimatorController.ActivateFlankKick();
                    break;
                
                case "right":
                    leftHandAnimatorController.ActivateFlankKick();
                    break;
            }
            
            leftHandAnimatorController.UpCapsule();
            rightHandAnimatorController.UpCapsule();

            if (!_destroyActivate)
            {
                _destroyActivate = true;
                StartCoroutine(cameraTriggerListener.Timer());
            }
            
        }

        public void FinalFightHand()
        {
            _timer = true;            
            StartCoroutine(Timer());
        }

        IEnumerator Timer()
        {
            while (_timer)
            {
                ChangeHand();
                _currentHandAnimatorController.ActivateDownKick();
                
                yield return new WaitForSeconds(1.4f);
            }
        }

        private void ChangeHand()
        {
            if (_lastLeft)
            {
                _lastLeft = false;
                _currentHandAnimatorController = rightHandAnimatorController;
            }
            else
            {
                _lastLeft = true;
                _currentHandAnimatorController = leftHandAnimatorController;
            }
        }


        public void DestroyHand()
        {
            _timer = false;
            _destroyActivate = false;
            
            rightHandAnimatorController.ResetCapsuleHeight();
            leftHandAnimatorController.ResetCapsuleHeight();
            
            rightHandAnimatorController.ActivateIdle();
            leftHandAnimatorController.ActivateIdle();

            transform.localRotation = Quaternion.Euler(_defaultRotation);
            transform.localPosition = _defaultPosition;
        }

    }
}