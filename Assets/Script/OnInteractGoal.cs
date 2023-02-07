using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractGoal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            GameManager.Instance.score += 1;
            Debug.Log(GameManager.Instance.score);
            if(GameManager.Instance.score == 5){
                Debug.Log("You Win!");
            }
        }
    }
}
