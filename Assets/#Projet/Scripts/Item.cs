using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool mouseOver = false;   
    
    public int scoreGameOver =0;
    public int scoreWin = 30;
    
    public Level_Manager manager;

    public bool jesuisblue;
    public bool choosed=false;
    public float timer =10f;
    public float timerZero = 0f;
    
   
    void Start()
    {
    }

    
    void Update()
    {
        if(Input.GetMouseButtonUp(0)&& mouseOver) 
        {
            Debug.Log("ciao");
            
            if(jesuisblue){
                manager.counter -=1;
                manager.scoreNow +=3;
                Destroy(gameObject);
                choosed=true;
            } 
            
            else
            {
                manager.counter -=1;
                manager.scoreNow +=1;
                Destroy(gameObject);
                choosed = true;
            }
        }
        else
        {
            StartCoroutine(SelfDestruct());
        }
        if (manager.scoreNow <30)
        {
            Debug.Log("total score: " + manager.scoreNow);
        }
        else
        {
            Debug.Log("YOU WIN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
        // timer -= Time.deltaTime;
        // // if (timer == timerZero)
        // // {
        // //     Destroy(gameObject);
        // // }
        // if (timer == timerZero)
        // {
        //     Destroy(gameObject);
        // }
        // timerZero += Time.deltaTime;
        // if (timerZero == timer)
        // {
        //     StartCoroutine(SelfDestruct());
        // }
        
        }
        
    
    void OnMouseOver() 
    {
        // transform.localScale = new Vector3(1,2,1);
        mouseOver = true;
        // animator.SetBool("MouseOver", true);
    }
    void OnMouseExit()
    {
        // transform.localScale = Vector3.one;
        mouseOver = false;
        // animator.SetBool("MouseOver", false);
    }
    public void HasBeenSelected(bool selected) 
    {
        // animator.SetBool("ItemSelected", selected);
        // animator.SetBool("MouseOver", false);
    }
    public void HasBeenMatch() 
    {
        // animator.SetBool("Item_Match", true);
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(timer);
        Destroy(gameObject);
    }
}