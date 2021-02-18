using DefaultNamespace.Monster;
using UnityEngine;

namespace DefaultNamespace
{
    public class HandsController : MonoBehaviour
    {
        [SerializeField] private MonsterHand leftHand;
        [SerializeField] private MonsterHand rightHand;


        public void ActivateHand()
        {
            leftHand.enabled = true;
            rightHand.enabled = true;
        }

        public void DestroyHand()
        {
            leftHand.enabled = false;
            rightHand.enabled = false;
        }

    }
}