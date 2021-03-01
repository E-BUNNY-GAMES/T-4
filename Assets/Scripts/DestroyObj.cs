
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public GameObject fullObj;
    public GameObject destroyObj;


    
    public void Activate()
    {
        fullObj.SetActive(false);
        destroyObj.SetActive(true);
    }
    
}
