using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int score = 0;
    private int caseSwitch;
    private Scene m_Scene;

    void DestroyPrefabsInScene(string Preff)
    {
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag(Preff);
        foreach (GameObject prefab in prefabs)
        {
            Destroy(prefab);
        }
    }

    [System.Obsolete]
    


    void Awake()
    {

        if (instance == null)

            instance = this;

        else if (instance != this)

            Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()

    {
        m_Scene = SceneManager.GetActiveScene();

        if (m_Scene.name == "Level00" && score == 16)
        {
            caseSwitch = 1;
            Invoke("nextLevel", 3f);

        }
        if (m_Scene.name == "Level01" && score == 36)
        {
            caseSwitch = 10;
            Invoke("nextLevel", 3f);
        }

        if (m_Scene.name == "Level10" && score == 100)
        {

            caseSwitch = 20;
            Invoke("nextLevel", 3f);
        }
        if (m_Scene.name == "Level20" && score == 166) // (238 * 70%) = 166
        {
            DestroyPrefabsInScene("Pref");
            caseSwitch = 30;
            Invoke("nextLevel", 3f);
        }
        if (m_Scene.name == "Level30" && score == 435) 
        {
            DestroyPrefabsInScene("Pref");
            caseSwitch = 1111;
            Invoke("nextLevel", 3f);
        }

    }

    public void nextLevel()
    {

        switch (caseSwitch)
        {
            case 1:
                SceneManager.LoadScene(sceneName: "Level01");
                break;
            case 10:
                SceneManager.LoadScene(sceneName: "Level10");
                break;
            case 20:
                SceneManager.LoadScene(sceneName: "Level20");
                break;
            case 30:
                SceneManager.LoadScene(sceneName: "Level30");
                break;
            case 1111:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
            default:
                break;
        }

    }


    public void bubble_p()
    {
        score++;
        Debug.Log("score:" + score);
    }

    public void DestroyFiftyPrecentPrefabsInScene(string Preff)
    {
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag(Preff);
        Debug.Log("GameObjectCount " + prefabs.Length);
        foreach (GameObject prefab in prefabs)
        {
            float rnd = Random.Range(0.0f, 1.0f);
            
            if (rnd < 0.5f)
            {
                score++;
                Destroy(prefab);
            }
        }
    }

}
