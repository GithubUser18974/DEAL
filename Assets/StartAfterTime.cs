using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAfterTime : MonoBehaviour
{
    public GameObject notDeal;
    // Start is called before the first frame update
   
    private void OnEnable()
    {
        Invoke("WTF", 0.5f);
    }
    private void OnDisable()
    {
        Invoke("WTFF", 0.5f);
    }
    void WTF()
    {
        notDeal.SetActive(true);
    }
    void WTFF()
    {
        notDeal.SetActive(false);
    }
}
