using System.Collections;
using UnityEngine;


namespace DefaultNamespace
{
    public class CameraTriggerListener : MonoBehaviour
    {
        public ShakeController shakeController;
        public RotateController rotateController;
        public MoveObj moveObj;

        public float timer;
        
        
        
        private void OnTriggerEnter(Collider other)
        {
            shakeController.Stop();
            moveObj.Stop();

            StartCoroutine(Timer());
        }

        IEnumerator Timer()
        {
            yield return new WaitForSeconds(timer);
            
            moveObj.Activate();
            shakeController.Activate();
            rotateController.RotateToDefault();
            
        }
    }
}