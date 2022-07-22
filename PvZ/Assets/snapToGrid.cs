using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class snapToGrid : MonoBehaviour
{
    [SerializeField] float gridSize = 1;
    [SerializeField] LayerMask plantLayer;
    [SerializeField] LayerMask Selflayer;
    bool placed;
    private void Start()
    {
        
        
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && !placed)
        {
            Vector2 mouspos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mouspos;
        }
        else if (Input.GetMouseButtonUp(0) && !placed)
        {
            if (Physics2D.OverlapCircle(transform.position, 0.1f, plantLayer)) Destroy(gameObject);
            transform.position = new Vector2(Mathf.RoundToInt(transform.position.x / gridSize) * gridSize, Mathf.RoundToInt(transform.position.y / gridSize)* gridSize);
            placed = true;
            gameObject.layer = 6;
        }
    }

}
