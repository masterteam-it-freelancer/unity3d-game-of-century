using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeCubePosition(GameObject cube) {
        if (cube != null) {
            
            //Duplicate cube
            var newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var oldCubePosition = cube.transform.position;
            newCube.transform.position = oldCubePosition;
            
            //Next current cube to left
            Vector3 newPosition =  new Vector3( oldCubePosition.x ,
                                            oldCubePosition.y,
                                            oldCubePosition.z+ 5);
            oldCubePosition = newPosition;
            cube.transform.position = newPosition;
        }
        Debug.Log("Change position completed");
        
    } 
}
