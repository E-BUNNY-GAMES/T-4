using Cinemachine;
using UnityEngine;

namespace DefaultNamespace
{
    public class MainCameraActivator : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera mainCamera;


        public void ChangeToMainCamera()
        {
            mainCamera.Priority = 11;
        }


    }
}