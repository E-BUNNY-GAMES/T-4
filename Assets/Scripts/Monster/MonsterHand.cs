using UnityEngine;

namespace DefaultNamespace.Monster
{
    public class MonsterHand : MonoBehaviour
    {
        [SerializeField] private Transform lookTarget;

        private void Update()
        {
            transform.LookAt(lookTarget);
        }
    }
}