using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermy : MonoBehaviour
{

    GameObject effectC;

    // Start is called before the first frame update
    void Start()
    {
        effectC = Resources.Load<GameObject>("effect/effect_c_02");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "PlayerAtteck")
        {
            if (transform.localScale.x == -1)
            {
                GameObject effect = Instantiate(effectC, new Vector3(transform.position.x -0.5f, transform.position.y, -2), Quaternion.identity);
                Destroy(effect, 0.4f);
            }
            else
            {
                GameObject effect = Instantiate(effectC, new Vector3(transform.position.x - 0.5f, transform.position.y, -2), Quaternion.identity);
                Destroy(effect, 0.4f);
            }
        }
    }
}
