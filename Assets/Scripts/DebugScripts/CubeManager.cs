using System.Collections.Generic;
using UnityEngine;

namespace DebugScripts
{
   
   
    public class CubeManager
    {
        private CubeManager() {
            //Create singleton
        }
        private static CubeManager instance = null;  
        public static CubeManager Instance {  
            get {  
                if (instance == null) {  
                    instance = new CubeManager();  
                }  
                return instance;  
            }  
        }  
        public List<GameObject> cubeList = new List<GameObject>();
    }
}