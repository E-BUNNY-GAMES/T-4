using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace.Tower
{
    public class TowerController : MonoBehaviour
    {
        public Floor[] floors;
        public UnityEvent deactivateEvent;
        
        public void ActivateFloors()
        {
           floors[0].Activate();

           StartCoroutine(Timer());
        }

        IEnumerator Timer()
        {
            yield return new WaitForSeconds(15f);
            
            DeactivateFloors();
        }



        public void DeactivateFloors()
        {
            Debug.Log("all floor deactivate");
            deactivateEvent.Invoke();
            
            foreach (var floor in floors)
            {
                floor.Deactivate();
            }
        }

    }
}