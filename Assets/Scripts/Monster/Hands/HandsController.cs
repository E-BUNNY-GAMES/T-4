using DefaultNamespace.Monster;
using DefaultNamespace.Monster.Hands;
using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace
{
    public class HandsController : MonoBehaviour
    {
        /*
        [SerializeField] private MonsterHand leftHand;
        [SerializeField] private MonsterHand rightHand;
        */

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

            //_currentHandFight
            

            /*
            if (left)
            {
                leftHand.enabled = true;
            }
            else
            {
                rightHand.enabled = true;
            }
            */

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