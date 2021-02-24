using System.Collections.Generic;
using DefaultNamespace.NavMesh;
using DG.Tweening;
using UnityEngine;


namespace DefaultNamespace
{
    public class Car : MonoBehaviour
    {
        [SerializeField] private NavmeshAgentController navmeshAgentController;
        [SerializeField] private GameObject fireParticle;
        [SerializeField] private GameObject smashParticle;
        [SerializeField] private List<GameObject> wheels;
        

        private CapsuleCollider _capsuleCollider;
        private ChangeTexture _changeTexture;
        private bool _isEnter;
        private Sequence _sequence;

        private void Awake()
        {
            _changeTexture = GetComponent<ChangeTexture>();
        }

        private void OnTriggerEnter(Collider other)
        {
            string tag = other.tag;
            if (tag.Equals("Destroy bal") && !_isEnter)
            {
                Debug.Log("destory car");


                transform.tag = "Destroy bal";
                
                smashParticle.SetActive(true);

                _isEnter = true;
                
                navmeshAgentController.Deactivate();
                _changeTexture.Change();
                
                //_sequence.Join(transform.DOScale(new Vector3(1f, 0.5f, 0.5f), 1f));
                _sequence.Join(transform.DOLocalJump(new Vector3(0, 0, -20), 2f, 0, 1f).SetEase(Ease.Linear)
                    .OnComplete(() =>
                        {
                            fireParticle.SetActive(true);    
                        }
                    ));
                _sequence.Join(transform.DOLocalRotate(new Vector3(360f, 0, 0), 1f, RotateMode.LocalAxisAdd));

                foreach (var wheel in wheels)
                {
                    wheel.SetActive(false);
                }
            }
            
        }
    }
}