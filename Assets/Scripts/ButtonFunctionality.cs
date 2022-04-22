using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        GetComponent<Button>().onClick.AddListener(debug);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.Play("FadeInOut");
        }


    }

void debug()
    {
        Debug.Log(gameObject.name);
    }
}
