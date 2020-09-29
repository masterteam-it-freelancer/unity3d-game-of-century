using System.Collections;
using System.Collections.Generic;
using DebugScripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using static DebugScripts.CubeManager;

public class btn_Script_DeleteSmallestCube : MonoBehaviour
{
   //Get cube
   GameObject getCube(List<GameObject> cubeList) {
       GameObject returnCube = null; 
       if (cubeList.Count > 0) {
          returnCube = cubeList[0];
       }
       return returnCube;
   }
   
    public void DeleteSmallestCube() {
        if (getCube(CubeManager.Instance.cubeList) != null) {
            GameObject cubeNeedDelete = getCube(CubeManager.Instance.cubeList);
            Destroy(cubeNeedDelete);
            CubeManager.Instance.cubeList.RemoveAt(0);
        }
        Debug.Log("Current cube in scene: " + CubeManager.Instance.cubeList.Count);
    } 
}
