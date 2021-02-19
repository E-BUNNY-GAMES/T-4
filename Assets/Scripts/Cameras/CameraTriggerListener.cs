using System.Collections;
using UnityEngine;


namespace DefaultNamespace
{
    public class CameraTriggerListener : MonoBehaviour
    {
        
        public ShakeController shakeController;
        public RotateController rotateController;
        public MoveObj moveObj;
        public SphereCollider destroySphere;
        
        
        public float timer;


        private void OnTriggerEnter(Collider other)
        {
         
            string tag = other.tag;
            if (tag.Equals("action") && transform.tag.Equals("MainCamera"))
            {
                shakeController.Stop();
                moveObj.Stop();
                destroySphere.enabled = true;

                StartCoroutine(Timer());                
            }
            else if(tag.Equals("finish action"))
            {
                shakeController.Stop();
                moveObj.Stop();
                destroySphere.enabled = true;
            }

        }

        IEnumerator Timer()
        {
            yield return new WaitForSeconds(timer);
            
            moveObj.Activate();
            shakeController.Activate();
            rotateController.RotateToDefault();

            destroySphere.enabled = false;

        }
    }
}