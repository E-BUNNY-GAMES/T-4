using DefaultNamespace.Monster.Hands;
using UnityEngine;


namespace DefaultNamespace
{
    public class HandsController : MonoBehaviour
    {
        [SerializeField] private HandAnimatorController leftHandAnimatorController;
        [SerializeField] private HandAnimatorController rightHandAnimatorController;

        
        private Vector3 _defaultRotation;
        private Vector3 _defaultPosition;
        
        private HandAnimatorController _currentHandAnimatorController;
        private bool _lastLeft;

        private void Awake()
        {
            _defaultRotation = transform.localRotation.eulerAngles;
            _defaultPosition = transform.localPosition;
            
            
//            _currentHandAnimatorController = leftHandAnimatorController;
        }
        
        public void ActivateHand(bool left)
        {
            transform.localPosition = new Vector3(0, _defaultPosition.y, 0);
            //_lastLeft = left;

            if (left)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0,-90,0));
                _currentHandAnimatorController = leftHandAnimatorController;
            }
            else
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0,90,0));
                _currentHandAnimatorController = rightHandAnimatorController;
            }
        }


        public void FightHand(string direction)
        {
            switch (direction)
            {
                case "up":
                    ChangeHand();
                    _currentHandAnimatorController.ActivateDownKick();
//                    leftHandAnimatorController.ActivateDownKick();
//                    rightHandAnimatorController.ActivateDownKick();
                    break;
                
                case "down":
                    ChangeHand();
                    _currentHandAnimatorController.ActivateUpKick();
//                    leftHandAnimatorController.ActivateUpKick();
//                    rightHandAnimatorController.ActivateUpKick();
                    break;
                
                case "left":
                    rightHandAnimatorController.ActivateFlankKick();
                    break;
                
                case "right":
                    leftHandAnimatorController.ActivateFlankKick();
                    break;
            }
            
            
            
//            if(_currentHandFight)
//                _currentHandFight.ActivateFight(direction);
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
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            transform.localPosition = _defaultPosition;
        }

    }
}