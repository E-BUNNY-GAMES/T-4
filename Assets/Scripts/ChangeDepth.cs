using UnityEngine;


namespace DefaultNamespace
{
    public class ChangeDepth : MonoBehaviour
    {
        [SerializeField]private GameObject attackVolume;
        [SerializeField]private GameObject defaultVolume;
        
        

        public void ChangeToDeafult()
        {
            attackVolume.SetActive(false);
            defaultVolume.SetActive(true);
        }

        public void ChangeToAttack()
        {
            defaultVolume.SetActive(false);
            attackVolume.SetActive(true);
        }
    }
}