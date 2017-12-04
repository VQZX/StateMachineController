using UnityEngine;

namespace Flusk.Management
{
    public class Initialisation
    {
        private const string PATH = "MainPrefab";

        [RuntimeInitializeOnLoadMethod]
        public static void StartUp ()
        {
            GameObject mainPrefab = Resources.Load(PATH) as GameObject;
            if (mainPrefab == null)
            {
                Debug.LogErrorFormat("[Initialisation] {0} DOES NOT EXIST!", PATH);
                return;
            }
            MainPrefab mp = mainPrefab.GetComponent<MainPrefab>();
            mp.ForceSet();
            mp.Initialise();
        }
    }
}
