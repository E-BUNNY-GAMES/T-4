using DefaultNamespace.Monster.Hands;
using UnityEngine;

namespace DefaultNamespace
{
    public class HandsController : MonoBehaviour
    {
        [SerializeField] private HandFight leftHandFight;
        [SerializeField] private HandFight rightHandFight;

        private HandFight _currentHandFight;
        private bool _lastLeft;


        public void ActivateHand(bool left)
        {
            _lastLeft = left;

            if (left)
            {
                _currentHandFight = leftHandFight;
            }
            else
            {
                _currentHandFight = rightHandFight;
            }
        }


        public void FightHand(string direction)
        {
            _currentHandFight.ActivateFight(direction);
        }


        public void DestroyHand()
        {
            
            /*
            if (_lastLeft)
            {
                leftHand.enabled = false;    
            }
            else
            {
                rightHand.enabled = false;    
            }
            */
            
        }

    }
}