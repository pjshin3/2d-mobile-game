using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincamera_action : MonoBehaviour
{
    public GameObject player;
    public GameObject Maincamera;

    public float offsetX = 0f;
    public float offsetY = 0f;
    public float offsetZ = 0f;
    public int followspeed = 0;

    public bool Shake = false;

    Vector3 cameraPosition;



    // Start is called before the first frame update
    void Start()
    {
        Maincamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void LateUpdate()
    {
        MoveCamera();
    }


    void MoveCamera()
    {
        cameraPosition.x = player.transform.position.x + offsetX;
        cameraPosition.y = player.transform.position.y + offsetY;
        cameraPosition.z = player.transform.position.z + offsetZ;

        transform.position = Vector3.Lerp(transform.position, cameraPosition, followspeed * Time.deltaTime);
    }
}
