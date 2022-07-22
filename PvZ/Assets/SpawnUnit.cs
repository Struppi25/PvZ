using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnit : MonoBehaviour
{
    [SerializeField] GameObject sunflower;

    private void Update()
    {
        Vector2 mouspos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(sunflower, mouspos, transform.rotation);
        }
        
    }

}
