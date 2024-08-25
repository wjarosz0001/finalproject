using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryPage : MonoBehaviour
{
    public void storyStartButton()
    {
        SceneManager.LoadScene(2);
    }

}
