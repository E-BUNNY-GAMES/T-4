using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace.Monster
{
    public class LocalRotateController : MonoBehaviour
    {
        
        
        public void ActivateLocalRotate(Vector3 localRotate)
        {
            transform.DOLocalRotate(localRotate, 1f);

        }

    }
}