using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charCTRLR : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        animator.SetFloat("speed", y);

        float x = Input.GetAxis("Horizontal");
        animator.SetFloat("neckBroken", x);
    }
}
