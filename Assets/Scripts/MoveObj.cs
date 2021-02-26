using UnityEngine;

namespace DefaultNamespace
{
    public class MoveObj : MonoBehaviour
    {
        public float speed;

        private bool _isMoved;

        private void Awake()
        {
            Activate();
        }


        private void Update()
        {
            Move();
        }
        
        private void Move()
        {
            if (_isMoved)
            {
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }
        }


        public void Activate()
        {
            _isMoved = true;
        }

        public void Stop()
        {
            _isMoved = false;
        }
    }
}