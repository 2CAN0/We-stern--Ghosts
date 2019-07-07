using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Camera camera;
    public RenderTexture rTexture;
    public float zoomOut = 100;
    public float fov = 80;

    // Start is called before the first frame update
    void Start()
    {
        camera.depth = 0;
        camera.targetTexture = rTexture;
        camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y + zoomOut, camera.transform.position.z);
        camera.fieldOfView = fov;
    }

    // Update is called once per frame
    void Update()
    {
        //camera.fieldOfView = fov;
        //camera.targetTexture = rTexture;
    }
}
