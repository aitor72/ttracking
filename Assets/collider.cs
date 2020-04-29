using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class collider : MonoBehaviour
{


    public Text countText;
    public Text winText;
    private int count;


    void Start()
    {

    	count = 0;
        SetCountText ();
        winText.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
             count = count + 1;
            SetCountText ();
        }
    }


       void SetCountText ()
    {
        countText.text =  count.ToString ();
        if (count >= 8)
        {
            winText.text = "You Win!";
        }
    }


}
