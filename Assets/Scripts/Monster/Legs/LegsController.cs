using System.Collections;
using UnityEngine;

namespace DefaultNamespace.Monster.Legs
{
    public class LegsController : MonoBehaviour
    {
        [SerializeField] private LegsAnimationController legsAnimationController;
        [SerializeField] private MoveObj moveObj;
        [SerializeField] private SphereCollider sphereCollider;
        [SerializeField] private GameObject hitParticle;

        private bool _changeRadius;


        public void Hit()
        {
            StartCoroutine(HitTimer());
        }

        private IEnumerator HitTimer()
        {
            legsAnimationController.ActivateStomping();         
            moveObj.Stop();
            
            yield return new WaitForSeconds(.5f);
            _changeRadius = true;
            Instantiate(hitParticle, new Vector3(transform.position.x, 41.5f, transform.position.z), Quaternion.Euler(Vector3.zero));
            //hitParticle.SetActive(true);
            
            StartCoroutine(DestroyTimer());
        }

        private void Update()
        {
            if (_changeRadius)
            {
                sphereCollider.radius += 10f * Time.deltaTime;
            }
        }

        private IEnumerator DestroyTimer()
        {
            yield return new WaitForSeconds(1.2f);

            //hitParticle.SetActive(false);
            moveObj.Activate();
            _changeRadius = false;
            sphereCollider.radius = 1;
        }

    }
}