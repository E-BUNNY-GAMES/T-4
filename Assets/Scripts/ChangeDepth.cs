using Bolt;
using UnityEngine;


namespace DefaultNamespace
{
    public class ChangeDepth : MonoBehaviour
    {
        [SerializeField]private GameObject attackVolume;
        [SerializeField]private GameObject defaultVolume;
        [SerializeField]private GameObject finishVolume;

        [SerializeField] private GameObject allUi;


        private void Awake()
        {
            ChangeToDeafult();
        }

        public void ChangeToDeafult()
        {
            CustomEvent.Trigger(allUi, "task_road");
            
            attackVolume.SetActive(false);
            defaultVolume.SetActive(true);
        }

        public void ChangeToAttack()
        {
            CustomEvent.Trigger(allUi, "task_building");
            
            defaultVolume.SetActive(false);
            attackVolume.SetActive(true);
        }

        public void ChangeToFinish()
        {
            CustomEvent.Trigger(allUi, "task_finish");
            
            defaultVolume.SetActive(false);
            attackVolume.SetActive(false);
            finishVolume.SetActive(true);
        }

    }
}