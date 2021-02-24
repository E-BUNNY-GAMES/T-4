using UnityEngine;

namespace DefaultNamespace
{
    public class SelectBonus : MonoBehaviour
    {
        [SerializeField] private Sprite[] spriteList;
        [SerializeField]private SpriteRenderer[] spriteRendererList;

        private void Awake()
        {
            Select();
        }

        private void Select()
        {
            int randomNumber = Random.Range(0, spriteList.Length);

            foreach (var spriteRenderer in spriteRendererList)
            {
                spriteRenderer.sprite = spriteList[randomNumber];    
            }
            
        }
    }
}