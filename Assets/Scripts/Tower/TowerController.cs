using System.Collections;
using Bolt;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace.Tower
{
    public class TowerController : MonoBehaviour
    {
        public Floor[] floors;
        public UnityEvent deactivateEvent;
        public GameObject allUi;
        
        
        public void ActivateFloors()
        {
           floors[0].Activate();
           CustomEvent.Trigger(allUi, "bar_start");
           StartCoroutine(Timer());
        }

        IEnumerator Timer()
        {
            yield return new WaitForSeconds(12f);
            
            DeactivateFloors();
        }



        public void DeactivateFloors()
        {
            Debug.Log("all floor deactivate");   
            CustomEvent.Trigger(allUi, "win_show");
            deactivateEvent.Invoke();
            
            foreach (var floor in floors)
            {
                floor.Deactivate();
            }
        }

    }
}