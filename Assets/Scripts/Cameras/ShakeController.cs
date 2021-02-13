using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace
{
    public class ShakeController: MonoBehaviour
    {
        public float intensity;

        private bool _isShake;


       

        private IEnumerator Start()
        {
            Activate();
            
            while (true)
            {
                if (_isShake)
                {
                    transform.DOShakePosition(intensity -0.3f, .5f)
                        .SetEase(Ease.Linear);    
                }
                yield return new WaitForSeconds(intensity);
            }
        }

        public void Stop()
        {
            _isShake = false;
        }

        public void Activate()
        {
            _isShake = true;
        }
    }
}