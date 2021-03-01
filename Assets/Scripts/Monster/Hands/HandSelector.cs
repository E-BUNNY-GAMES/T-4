using System.Collections.Generic;
using DefaultNamespace.Monster;
using UnityEngine;

namespace Monster.Hands
{
    public class HandSelector : MonoBehaviour
    {
        [SerializeField] private Randomizer randomizer;
        
        [SerializeField] private Mesh[] meshList;
        [SerializeField] private Material[] materialList;

        [SerializeField] private List<SkinnedMeshRenderer> skinnedMeshRenderers;
        

        private void Start()
        {
            Select();
        }

        private void Select()
        {
            var randomNumber = randomizer.randomNumber;
            
            foreach (var skinnedMeshRenderer in skinnedMeshRenderers)
            {
                skinnedMeshRenderer.material = materialList[randomNumber];
                skinnedMeshRenderer.sharedMesh = meshList[randomNumber];
            }
        }
    }
}