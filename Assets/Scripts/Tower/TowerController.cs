using System.Collections;
using UnityEngine;

namespace DefaultNamespace.Tower
{
    public class TowerController : MonoBehaviour
    {
        public Floor[] floors;
        
        
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
            
            foreach (var floor in floors)
            {
                floor.Deactivate();
            }
        }

    }
}