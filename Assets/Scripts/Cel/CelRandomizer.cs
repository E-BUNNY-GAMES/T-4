using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class CelRandomizer : MonoBehaviour
    {
        [SerializeField] private List<GameObject> cels;

        
        public void GetRandomCel()
        {
            int randomCelNumber = Random.Range(0, cels.Count);
            
            cels[randomCelNumber].SetActive(true);
            cels.Remove(cels[randomCelNumber]);
        }

    }
}