using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_manager03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CameraMoove03(int amount)
    {



    }

    public void OnMouseDown()
    {
        Camera.main.transform.Translate(+18, 0, 0);
    }
}
