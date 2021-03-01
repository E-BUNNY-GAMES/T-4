using UnityEngine;


namespace DefaultNamespace.Monster
{
    public class Randomizer : MonoBehaviour
    {
        [SerializeField] private int maxCount;
            
        public int randomNumber;


        private void Awake()
        {
            randomNumber = Random.Range(0, maxCount);
        }
    }
}