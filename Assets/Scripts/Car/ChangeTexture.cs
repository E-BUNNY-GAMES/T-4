using UnityEngine;

namespace DefaultNamespace
{
    public class ChangeTexture : MonoBehaviour
    {
        [SerializeField] private Texture[] changeTextureList;

        private MeshRenderer _meshRenderer;
        private int _textureNumber;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            _textureNumber = 0;
        }

        public void Change()
        {
            if (_textureNumber <changeTextureList.Length)
            {
                _meshRenderer.material.mainTexture = changeTextureList[_textureNumber];
                _textureNumber++;    
            }
            
        }

    }
}