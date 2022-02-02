using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L02Character : MonoBehaviour
{
    private string title = "A Walk in the City";
    private string leftText = "You just pressed A";
    private string rightText = "You just pressed D";

    private bool isLeft=true;

    private Vector3 oScale;
    private Animator anim;
    private SpriteRenderer sr;

    [SerializeField] private float speed = 1.0f;
    [SerializeField] Transform leftBound, rightBound;
    [SerializeField] Text textobj;
    [SerializeField] Font font1, font2;
    void Start()
    {
        oScale = transform.localScale;
        anim = GetComponent<Animator>();    
        sr=GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            isLeft = true;
            transform.localScale = oScale;
            textobj.text = leftText;
            textobj.font = font1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            isLeft=false;
            transform.localScale = new Vector3(-oScale.x,oScale.y,oScale.z);
            textobj.text = rightText;
            textobj.font = font2;
        }
        
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Walk", true);
            transform.Translate(new Vector3(speed * Time.deltaTime * (isLeft ? -1 : 1), 0));
            if(transform.position.x<leftBound.position.x)
                transform.position = new Vector3(leftBound.position.x, transform.position.y, transform.position.z);
            if (transform.position.x > rightBound.position.x)
                transform.position = new Vector3(rightBound.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.color = new Color(Random.Range(.3f, .8f), Random.Range(.3f, .8f), Random.Range(.3f, .8f));
            textobj.text = title;
            textobj.font = font1;
        }
    }
}
