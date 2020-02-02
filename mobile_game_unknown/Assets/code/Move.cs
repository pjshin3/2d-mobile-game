using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    GameObject playe;
    //GameObject MainCamera;
    Main main;
    //Maincamera_action camera;

    public void Init()
    {
        // MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        playe = GameObject.FindGameObjectWithTag("Player");
        main = playe.GetComponent<Main>();
        //camera = MainCamera.GetComponent<Maincamera_action>();

    }

    public void LeftUp()
    {
        main.inputleft = false;
    }
    public void LeftDown()
    {
        main.inputleft = true;
    }
    public void RightUp()
    {
        main.inputright = false;
    }
    public void RightDown()
    {
        main.inputright = true;
    }
    public void Atteck()
    {
        main.inpuAtteck = true;
        //camera.Shake = true;
    }
}
