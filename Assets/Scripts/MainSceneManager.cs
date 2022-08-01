using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    public static string currentSelectedCar = "RallyCar";
    private bool onOff = false;

    public void showNewCar(string nextCar)//pass in name of car then find current car then diable the current car we looking at. we over ride the selected car up the top
    {
       // GameObject.Find(ColourSwitcher.instance.getCurrentTracked().name + "/ActiveItems/" + MainSceneManager.currentSelectedCar).SetActive(false);
       // currentSelectedCar = nextCar;
       // GameObject.Find(ColourSwitcher.instance.getCurrentTracked().name + "/ActiveItems/" + MainSceneManager.currentSelectedCar).SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ChangeLevel(string scene)//game controller main menu level on menu2 in the indooroutdoor panel
    {
        SceneManager.LoadScene(scene);
    }
}
