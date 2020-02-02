using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public int Helth = 3;
    public int speed = 3;

    public bool inputright = false;
    public bool inputleft = false;
    public bool inpuAtteck = false;

    Vector3 moveVelocity = Vector3.zero;
    Vector3[] position = new Vector3[5];

    Animator animator;
    Rigidbody2D rigidbody;

    GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();

        effect = Resources.Load<GameObject>("effect/effect_A_01");

        Move ui = GameObject.FindGameObjectWithTag("move").GetComponent<Move>();
        ui.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        move();
        Atteck();
    }

    void move()
    {

        if (!inputleft && !inputright)
        {
            animator.SetBool("isrunning", false);
        }
        else if (inputleft)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            moveVelocity = Vector3.left;
            animator.SetBool("isrunning", true);

            transform.position += moveVelocity * speed * Time.deltaTime;
        }
        else if (inputright)
        {
            transform.localScale = new Vector3(1, 1, 1);
            moveVelocity = Vector3.right;
            animator.SetBool("isrunning", true);

            transform.position += moveVelocity * speed * Time.deltaTime;
        }
    }

    void Atteck()
    {
        if (inpuAtteck)
        {
            inpuAtteck = false;
            animator.SetTrigger("atteck");

            //if (transform.localScale.x == -1)
            //{
            //    GameObject werter = Instantiate(Werter, new Vector3(transform.position.x - 4, transform.position.y, 49), Quaternion.identity);
            //    werter.GetComponent<Werter>().init();
            //    werter.GetComponent<Werter>().isclone = true;

            //    Destroy(werter, 0.4f);
            //}
            //else
            //{
            //    GameObject werter = Instantiate(Werter, new Vector3(transform.position.x + 4, transform.position.y, 49), Quaternion.identity);
            //    werter.GetComponent<Werter>().isclone = true;
            //    werter.GetComponent<Werter>().init();
            //    werter.GetComponent<Werter>().input_darection = true;

            //    Destroy(werter, 0.4f);
            //}

        }
    }
}
