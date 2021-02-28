using System.Collections;
using UnityEngine;

namespace DefaultNamespace.Monster.Legs
{
    public class LegsController : MonoBehaviour
    {
        [SerializeField] private LegsAnimationController legsAnimationController;
        [SerializeField] private MoveObj moveObj;
        [SerializeField] private SphereCollider sphereCollider;

        private bool _changeRadius;
        
        public void Hit()
        {
            legsAnimationController.ActivateStomping();         
            moveObj.Stop();
            _changeRadius = true;
            
            StartCoroutine(Timer());
        }

        private void Update()
        {
            if (_changeRadius)
            {
                sphereCollider.radius += 10f * Time.deltaTime;
            }
        }

        private IEnumerator Timer()
        {
            yield return new WaitForSeconds(1f);
                
            moveObj.Activate();
            _changeRadius = false;
            sphereCollider.radius = 1;
        }

    }
}