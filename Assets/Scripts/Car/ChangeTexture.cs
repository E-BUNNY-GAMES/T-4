using UnityEngine;

namespace DefaultNamespace
{
    public class ChangeTexture : MonoBehaviour
    {
        [SerializeField] private Texture changeTexture;

        private MeshRenderer _meshRenderer;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        public void Change()
        {
            _meshRenderer.material.mainTexture = changeTexture;
        }

    }
}