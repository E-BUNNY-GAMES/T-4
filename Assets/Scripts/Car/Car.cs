using System.Collections.Generic;
using Bolt;
using DefaultNamespace.NavMesh;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using Sequence = DG.Tweening.Sequence;


namespace DefaultNamespace
{
    public class Car : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private NavmeshAgentController navmeshAgentController;
        [SerializeField] private GameObject fireParticle;
        [SerializeField] private GameObject smashParticle;
        
        [SerializeField] private List<GameObject> wheels;
        [SerializeField] private bool impact;

        
        private GameObject _allUi;
        private CapsuleCollider _capsuleCollider;
        private ChangeTexture _changeTexture;
        private Sequence _sequence;
        private bool _isDestroy;
        private bool _isEnterZone;
        

        private void Awake()
        {
            _changeTexture = GetComponent<ChangeTexture>();
            _allUi = GameObject.Find("All_UI");
            
        }

        private void OnTriggerEnter(Collider other)
        {
            string tag = other.tag;
            if (tag.Equals("Destroy bal") && !_isDestroy)
            {
                DestroyAction();
            }
            else if (tag.Equals("leg zone"))
            {
                _isEnterZone = true;
            }
            
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (_isEnterZone)
            {
                DestroyAction();
            }
        }

        private void DestroyAction()
        {
            Debug.Log("destory car");


            CustomEvent.Trigger(_allUi, "bar+", 0.01f);
            
            transform.tag = "Destroy bal";
                
            smashParticle.SetActive(true);

            _isDestroy = true;

            if (navmeshAgentController)
            {
                navmeshAgentController.Deactivate();
            }
            _changeTexture.Change();

            if (impact)
            {
                _sequence.Join(transform.DOLocalJump(new Vector3(0, 0, -20), 2f, 0, 1f).SetEase(Ease.Linear));
                _sequence.Join(transform.DOLocalRotate(new Vector3(360f, 0, 0), 1f, RotateMode.LocalAxisAdd));
            }
            else
            {
                transform.DOLocalJump(transform.localPosition, 2f, 0, 1f);
            }

            fireParticle.SetActive(true);

            foreach (var wheel in wheels)
            {
                wheel.SetActive(false);
            }
        }

        
    }
}