using System.Collections;
using System.Collections.Generic;
using DebugScripts;
using UnityEngine;
using static DebugScripts.CubeManager;
public class btn_Script_CreateNewCube : MonoBehaviour {
    public int addZ = 10;
    // Start is called before the first frame update
    public void CloneNewCube(GameObject oldCube) {
        oldCube.name = "cube_0";
        //Create new cube 
        var newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //Save old cube position
        var previousCubePosition = oldCube.transform.position;
        
        //Create new cube position
        var newCubePosition = new Vector3(previousCubePosition.x, previousCubePosition.y, previousCubePosition.z + addZ);
        newCube.name = "cube_" + (addZ/10).ToString();
        newCube.transform.position = newCubePosition;
        CubeManager.Instance.cubeList.Add(newCube);
        
        addZ += 10;
        Debug.Log("Create new cube: "+ newCube.name);
        Debug.Log("Current cubelist capacity: "+ CubeManager.Instance.cubeList.Count);
    } 
}
