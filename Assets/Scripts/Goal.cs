using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Goal : MonoBehaviour
{
    public GameObject textUI;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    // when the player enters the goal
    void OnTriggerEnter(Collider other)
    {
        // if the player enters the goal
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You win!");
            textUI.SetActive(true);
        }
    }
}
