using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Level_Manager : MonoBehaviour
{
    public GameObject blue_cube;
    public GameObject red_cube;
    public GameObject[] prefabs;
    public int counter=0;
    public int scoreNow=0;
    public Item item;

    


    void Start()
    {
        InvokeRepeating("CreateMyInstance", 3.0f, 1.0f);
    }

    void CreateMyInstance()
    {
        // Instantiate(prefab, Vector3.zero, Quaternion.identity);
        float x = Random.Range(1f, 6f);
        float z = Random.Range(2f, 5f);
        float y = Random.Range(3f,7f);
        

        int randoColor = Random.Range(0,5);
        Vector3 position = new Vector3(x , y, z);
        
        if (counter<10)
        {
            GameObject c;
            if(randoColor == 0)
            {
                c = Instantiate(blue_cube, position, Quaternion.identity);

            }
        else
            {
                c = Instantiate(red_cube, position, Quaternion.identity);

            }
            c.GetComponent<Item>().manager = this;

        counter+=1;
        }
        
    }

    IEnumerator DoDelay(float seconds, System.Action callback) {
        yield return new WaitForSeconds(seconds);
        callback();
 } 

    void StartDelay() { 
        StartCoroutine(DoDelay(1.0f,CreateMyInstance));
    }


    void GameOver()
    {

    }


    }
    
 


