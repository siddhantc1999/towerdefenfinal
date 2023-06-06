using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour
{
    public bool isPlacable;
    [SerializeField] GameObject towerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //will have to change here
    private void OnMouseDown()
    {
        Debug.Log("in mouse down");
        if(isPlacable)
        {
            GameObject.Instantiate(towerPrefab,transform.position,Quaternion.identity);
            isPlacable = false;
        }
    }
}
