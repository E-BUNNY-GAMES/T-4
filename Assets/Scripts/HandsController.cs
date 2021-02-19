using DefaultNamespace.Monster;
using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace
{
    public class HandsController : MonoBehaviour
    {
        [SerializeField] private MonsterHand leftHand;
        [SerializeField] private MonsterHand rightHand;

        
        private bool _lastLeft;


        public void ActivateHand(bool left)
        {
            _lastLeft = left;
            
            if (left)
            {
                leftHand.enabled = true;
                //leftHand.transform.DOLocalMoveZ(leftHand.transform.localPosition.z + 1f,.5f);
            }
            else
            {
                rightHand.enabled = true;
                //rightHand.transform.DOLocalMoveZ(rightHand.transform.localPosition.z + 1f,.5f);
            }
            
        }

        
        
        public void DestroyHand()
        {
            if (_lastLeft)
            {
                leftHand.enabled = false;
                //leftHand.transform.DOLocalMoveZ(leftHand.transform.localPosition.z - 1f,.5f);    
            }
            else
            {
                rightHand.enabled = false;
                //rightHand.transform.DOLocalMoveZ(rightHand.transform.localPosition.z - 1f,.5f);    
            }
            
        }

    }
}