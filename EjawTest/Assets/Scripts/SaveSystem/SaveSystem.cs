using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public string LoadData(string figureName)
    {
        string data = File.ReadAllText(Application.dataPath + "/Resources/figuresNames.json");
        FiguresName figuresName = JsonUtility.FromJson<FiguresName>(data);

        if (figureName == "Capsule")
            return figuresName.capsuleName;
        else if (figureName == "Cube")
            return figuresName.cubeName;
        else if (figureName == "Sphere")
            return figuresName.sphereName;
        else
            return "Error";
    }

    private class FiguresName
    {
        public string cubeName;
        public string sphereName;
        public string capsuleName;
    }
}


