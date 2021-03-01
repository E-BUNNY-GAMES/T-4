using System.Collections;
using UnityEngine;

namespace DefaultNamespace.Monster
{
    public class MonsterCreator : MonoBehaviour
    {
        [SerializeField] private MoveObj monsterMoveObj;
        [SerializeField] private GameObject handController;
        [SerializeField] private GameObject legsController;
        [SerializeField] private GameObject[] monsters; 
        public int randomNumber;

        
        private void Awake()
        {
            randomNumber = Random.Range(0, 3);
            monsters[randomNumber].SetActive(true);
        }

        public void DestroyMonster()
        {
            StartCoroutine(Timer());
        }


        IEnumerator Timer()
        {
            yield return new WaitForSeconds(1.5f);
            
            monsters[randomNumber].SetActive(false);
            
            handController.SetActive(true);
            legsController.SetActive(true);

            monsterMoveObj.enabled = true;
        }
    }
}