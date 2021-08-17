using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace VoxelWorld
{
    public class WorldUiManager : MonoBehaviour
    {
        [Title("Buttons")]
        public Button loadWorld;
        
        private void Start()
        {
            if (!World.CheckSavesDirectory() || !World.CheckWorldDataFile())
            {
                loadWorld.interactable = false;
            }
        }

        public void NewWorld()
        {
            Utils.amplitude = Random.Range(1,4);
            Utils.frequency = Random.Range(1,4);
            Utils.offset = Random.Range(4096, 65536);
            
            Debug.Log(Utils.amplitude + " " + Utils.frequency + " " + Utils.offset);

            World.ClearSaveDirectory();
            
            World.SaveWorldData();

            SceneManager.LoadScene("Scenes/VoxelWorld");
        }

        public void LoadWorld()
        {
            if (!World.LoadWorldData())
            {
                Debug.LogError("Failed loading world.");
                NewWorld();
                return;
            }
            
            Utils.amplitude = World.levelData.amplitude;
            Utils.frequency = World.levelData.frequency;
            Utils.offset = World.levelData.offset;
            
            Debug.Log(Utils.amplitude + " " + Utils.frequency + " " + Utils.offset);
            
            World.SaveWorldData();
            
            SceneManager.LoadScene("Scenes/VoxelWorld");
        }

        public void Quit()
        {
            StopAllCoroutines();
            Application.Quit();
        }
    }
}
