using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToMouse : MonoBehaviour
{

    public bool travarMouse = true;
    public float sensibilidade = 2.0f;

    private float mouseX = 0.0f, mouseY = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (!travarMouse)
        {
            return;
        }
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensibilidade;
        mouseY -= Input.GetAxis("Mouse Y") * sensibilidade;

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
