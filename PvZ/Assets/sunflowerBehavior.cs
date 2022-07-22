using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunflowerBehavior : MonoBehaviour
{
    [SerializeField] float minTimer = 10;
    [SerializeField] float maxTimer = 20;
    float currentTimer;

    private void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        if(currentTimer >= 0)
        {
            currentTimer -= Time.deltaTime;
            
        }
        else
        {
            ResetTimer();
            Debug.Log("spawn");
        }
    }

    private void ResetTimer()
    {
        currentTimer = Random.Range(minTimer, maxTimer);
    }

}
