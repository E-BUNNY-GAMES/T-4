using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;


namespace DefaultNamespace.Tower
{
    public class Floor : MonoBehaviour, IPointerClickHandler
    {
        public int number;
        public Vector3 clickScale;
        public Floor nextFloor;
        
        
        private int _currentCount;
        private bool _isActivate;
        private bool _isAnimated;
        private Vector3 _defaultScale;

        private ChangeTexture _changeTexture;
        
        private void Awake()
        {
            _currentCount = number * 3;
            _defaultScale = transform.localScale;

            _changeTexture = GetComponent<ChangeTexture>();
        }

        public void Activate()
        {
            _isActivate = true;
        }

        public void Deactivate()
        {
            _isActivate = false;
        }


        public void OnPointerClick(PointerEventData eventData)
        {
            if (_isActivate)
            { 
                
                _changeTexture.Change();
                
                if (_currentCount <= 0)
                {
                    Debug.Log("floor deactivate");
                    if (nextFloor)
                    {
                        nextFloor.Activate();    
                    }
                    gameObject.SetActive(false);
                }
                
                _currentCount--;
                    
                ClickAnimation();                
            }
        }

        private void ClickAnimation()
        {
            if (!_isAnimated)
            {
                _isAnimated = true;
                transform.DOScale(clickScale, 0.2f).SetEase(Ease.Linear)
                    .OnComplete(() =>
                    {
                        _isAnimated = false;
                        transform.localScale = _defaultScale;
                    });
            }
        }

    }
}