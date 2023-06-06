using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public List<waypoint> Path;
    GameObject pathLane;
    // Start is called before the first frame update
    void Start()
    {
        FindPath();
        StartCoroutine(Move());
    }


    private void FindPath()
    {
        pathLane = GameObject.FindGameObjectWithTag("path");
        foreach(Transform child in pathLane.transform)
        {
            Path.Add(child.GetComponent<waypoint>());
        }
    }

    IEnumerator Move()
    {
       foreach(waypoint waypoint in Path)
        {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = new Vector3(waypoint.transform.position.x,1f, waypoint.transform.position.z);
            float timer = 0;
            while(timer<=1f)
            {
                transform.position = Vector3.Lerp(startPosition,endPosition,timer);
                timer += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("here in log");
    //}
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("here in log");
    }
}
