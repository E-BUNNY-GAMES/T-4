using UnityEngine;
using UnityEngine.EventSystems;



namespace DefaultNamespace
{
    public class CelController : MonoBehaviour, IPointerClickHandler
    {
        public SphereCollider sphereCollider;
        public float destroyRadius;
        public DestroyObj destroyObj;

        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }


        public void OnPointerClick(PointerEventData eventData)
        {
            destroyObj.Activate();
            sphereCollider.radius = destroyRadius;
            sphereCollider.center = Vector3.forward * destroyRadius;

            _spriteRenderer.enabled = false;
        }
       
    }
}