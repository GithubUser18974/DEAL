using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAfterTime : MonoBehaviour
{
    public GameObject notDeal;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("WTF", 5);
    }

   void WTF()
    {
        notDeal.SetActive(false);
    }
}
